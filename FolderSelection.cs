using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONBIT.CreateProjectFolder
{
    public partial class FolderSelection : Form
    {
        public FolderSelection()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Read data and write it back
            List <FolderSelection.FolderName> FolderNames = new List <FolderSelection.FolderName>();
            FolderNames = GetFolderNames();

            //Check for duplicates
            if (FolderNames.GroupBy(f => f.Name).Any(g => g.Count() > 1))
            {
                return;
            }
            
            SelectedFolders = FolderNames;
            this.Close();
        }

    }
}
