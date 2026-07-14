using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONBIT.CreateProjectFolder
{
    public partial class FolderSelection : Form
    {
        // Location where it should read the standard structure from, maximum allowed depth is 2 levels (e.g. root\Sub1\Sub2)
        private const string StandardStructureRoot = @"M:\Temp\MOR\Vault Industrial";

        private const int RowHeight = 26;
        private const int IndentWidth = 23;
        private const int LeftMargin = 12;

        /// Max time to wait for the network location to respond before giving up.
        private const int StructureLoadTimeoutMs = 4000;

        private readonly List<FolderRow> _rows = new List<FolderRow>();
        private int _yPos = 12;
        private bool _loopPrevention;
        private bool _loadFailed;

        public List<FolderName> SelectedFolders;

        public FolderSelection()
        {
            InitializeComponent();

            Exception loadError = null;

            var loadTask = Task.Run(() =>
            {
                try
                {
                    return ReadStandardStructure(StandardStructureRoot);
                }
                catch (Exception ex)
                {
                    loadError = ex;
                    return null;
                }
            });

            // Wait() with a timeout returns control to us even if the underlyingI/O call is still stuck (e.g. an unresponsive network share).
            // The background task itself is abandoned in that case - it may finish later, but nothing reads its result and it won't
            // block app shutdown.
            bool completedInTime = loadTask.Wait(StructureLoadTimeoutMs);

            if (completedInTime && loadError == null && loadTask.Result != null)
            {
                BuildFolderRows(loadTask.Result, depth: 0, parentRow: null);
            }
            else
            {
                _loadFailed = true;

                string message = !completedInTime
                    ? string.Format(
                        "Timed out waiting for the standard folder structure at:\n{0}\n\nThe network location may be unavailable. Check your connection and try again.",
                        StandardStructureRoot)
                    : string.Format(
                        "Could not read the standard folder structure from:\n{0}\n\n{1}\n\nCheck that the network location is available and try again.",
                        StandardStructureRoot, loadError.Message);

                MessageBox.Show(message, "Standard folder structure unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_loadFailed)
            {
                this.Shown += (s, e) => this.Close();
            }
        }

        public void SetDefaultNames(string ProjNum)
        {
            foreach (var row in _rows)
            {
                row.TextBox.Text = string.Format("{0}{1}", ProjNum, row.OriginalName);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Read data and write it back
            List<FolderName> FolderNames = GetFolderNames();

            //Check for duplicates
            if (FolderNames.GroupBy(f => f.Name).Any(g => g.Count() > 1))
            {
                MessageBox.Show("Not all active folder names are unique!", "Duplicate folder names", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedFolders = FolderNames;
            this.Close();
        }

        private static List<DiskFolder> ReadStandardStructure(string rootPath)
        {
            if (!Directory.Exists(rootPath))
                throw new DirectoryNotFoundException($"Standard folder structure root not found: {rootPath}");

            return ReadSubfolders(rootPath);
        }

        private static List<DiskFolder> ReadSubfolders(string path)
        {
            var result = new List<DiskFolder>();

            IEnumerable<string> subDirs;
            try
            {
                // Alphanumeric ordering so folder names sort the same way Explorer shows them.
                subDirs = Directory.GetDirectories(path)
                                    .OrderBy(d => Path.GetFileName(d), StringComparer.OrdinalIgnoreCase);
            }
            catch (UnauthorizedAccessException)
            {
                // Skip anything we can't read rather than failing the whole form.
                return result;
            }

            foreach (var dir in subDirs)
            {
                var attrs = File.GetAttributes(dir);
                if (attrs.HasFlag(FileAttributes.Hidden) || attrs.HasFlag(FileAttributes.System))
                    continue;

                result.Add(new DiskFolder
                {
                    Name = Path.GetFileName(dir),
                    Children = ReadSubfolders(dir)
                });
            }

            return result;
        }

        private void BuildFolderRows(IEnumerable<DiskFolder> folders, int depth, FolderRow parentRow)
        {
            foreach (var folder in folders)
            {
                var chk = new CheckBox
                {
                    AutoSize = true,
                    Checked = true,
                    Location = new Point(LeftMargin + depth * IndentWidth, _yPos)
                };

                var txt = new TextBox
                {
                    BackColor = SystemColors.Control,
                    Location = new Point(LeftMargin + depth * IndentWidth + 21, _yPos - 3),
                    Width = panelFolders.ClientSize.Width - (depth * IndentWidth + 45),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    Text = folder.Name
                };

                var row = new FolderRow
                {
                    OriginalName = folder.Name,
                    CheckBox = chk,
                    TextBox = txt,
                    Parent = parentRow,
                    ArchivedChecked = true
                };
                parentRow?.Children.Add(row);
                _rows.Add(row);

                chk.CheckedChanged += (s, e) => OnFolderCheckChanged(row);

                panelFolders.Controls.Add(chk);
                panelFolders.Controls.Add(txt);

                _yPos += RowHeight;

                if (folder.Children.Count > 0)
                    BuildFolderRows(folder.Children, depth + 1, row);
            }
        }

        private void OnFolderCheckChanged(FolderRow row)
        {
            if (_loopPrevention) { return; }
            _loopPrevention = true;

            // "Parent" behavior: restore/archive children when this row's own state flips.
            if (row.Children.Count > 0)
            {
                if (row.CheckBox.Checked)
                {
                    foreach (var child in row.Children)
                    {
                        if (child.CheckBox.Checked != child.ArchivedChecked)
                        {
                            child.CheckBox.Checked = child.ArchivedChecked;
                        }
                    }
                }
                else
                {
                    foreach (var child in row.Children)
                    {
                        child.ArchivedChecked = child.CheckBox.Checked;
                        child.CheckBox.Checked = false;
                    }
                }
            }

            // "Child" behavior: checking a child while its parent is off re-checks the parent.
            if (row.Parent != null && row.CheckBox.Checked && !row.Parent.CheckBox.Checked)
            {
                foreach (var sibling in row.Parent.Children)
                {
                    if (sibling != row)
                    {
                        sibling.ArchivedChecked = false;
                    }
                }
                row.Parent.CheckBox.Checked = true;
            }

            _loopPrevention = false;
        }

        private List<FolderName> GetFolderNames()
        {
            var result = new List<FolderName>();

            foreach (var row in _rows.Where(r => r.Parent == null))
            {
                List<string> activeChildren = row.Children.Count > 0
                    ? row.Children.Where(c => c.CheckBox.Checked)
                                   .Select(c => c.TextBox.Text)
                                   .Distinct()
                                   .ToList()
                    : null;

                result.Add(new FolderName(row.TextBox.Text, row.CheckBox.Checked, activeChildren));
            }

            //Filter inactive entries
            return result.Where(f => f.Active).ToList();
        }

        private class DiskFolder
        {
            public string Name;
            public List<DiskFolder> Children = new List<DiskFolder>();
        }

        private class FolderRow
        {
            public string OriginalName;
            public CheckBox CheckBox;
            public TextBox TextBox;
            public FolderRow Parent;
            public List<FolderRow> Children = new List<FolderRow>();
            public bool ArchivedChecked;
        }

        public class FolderName
        {
            //Class to save the folder data to
            public string Name;
            public bool Active;
            public List<string> ActiveChildren;

            public FolderName(string name, bool active, List<string> actchildren)
            {
                //Initialization for class
                Name = name;
                Active = active;
                ActiveChildren = actchildren;
            }
        }
    }
}
