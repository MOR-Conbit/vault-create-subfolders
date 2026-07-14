using Autodesk.Connectivity.Explorer.ExtensibilityTools;
using Autodesk.Connectivity.Extensibility.Framework;
using Autodesk.Connectivity.WebServices;
using Autodesk.Connectivity.WebServicesTools;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Connections;
using Autodesk.DataManagement.Client.Framework.Vault.Services.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

[assembly: ApiVersion("18.0")]
[assembly: ExtensionId("1e7fb205-0d13-46d9-9d6c-6409b31782c5")]

namespace CONBIT.CreateProjectFolder
{
    public class EventHandlers : IWebServiceExtension
    {
        #region IWebServiceExtension Members
        public string ProjectNumber;

        public void OnLoad()
        {
            #region register events
            // register for events here
            // comment out events not being used

            // File Events
            //DocumentService.AddFileEvents.GetRestrictions += new EventHandler<AddFileCommandEventArgs>(AddFileEvents_GetRestrictions);
            //DocumentService.AddFileEvents.Post += new EventHandler<AddFileCommandEventArgs>(AddFileEvents_Post);
            //DocumentService.AddFileEvents.Pre += new EventHandler<AddFileCommandEventArgs>(AddFileEvents_Pre);
            //DocumentService.CheckinFileEvents.GetRestrictions += new EventHandler<CheckinFileCommandEventArgs>(CheckinFileEvents_GetRestrictions);
            //DocumentService.CheckinFileEvents.Pre += new EventHandler<CheckinFileCommandEventArgs>(CheckInFileEvents_Pre);
            //DocumentService.CheckinFileEvents.Post += new EventHandler<CheckinFileCommandEventArgs>(CheckInFileEvents_Post);
            //DocumentService.CheckoutFileEvents.GetRestrictions += new EventHandler<CheckoutFileCommandEventArgs>(CheckoutFileEvents_GetRestrictions);
            //DocumentService.CheckoutFileEvents.Pre += new EventHandler<CheckoutFileCommandEventArgs>(CheckoutFileEvents_Pre);
            //DocumentService.CheckoutFileEvents.Post += new EventHandler<CheckoutFileCommandEventArgs>(CheckoutFileEvents_Post);
            //DocumentService.DeleteFileEvents.GetRestrictions += new EventHandler<DeleteFileCommandEventArgs>(DeleteFileEvents_GetRestrictions);
            //DocumentService.DeleteFileEvents.Pre += new EventHandler<DeleteFileCommandEventArgs>(DeleteFileEvents_Pre);
            //DocumentService.DeleteFileEvents.Post += new EventHandler<DeleteFileCommandEventArgs>(DeleteFileEvents_Post);
            //DocumentService.DownloadFileEvents.GetRestrictions += new EventHandler<DownloadFileCommandEventArgs>(DownloadFileEvents_GetRestrictions);
            //DocumentService.DownloadFileEvents.Pre += new EventHandler<DownloadFileCommandEventArgs>(DownloadFileEvents_Pre);
            //DocumentService.DownloadFileEvents.Post += new EventHandler<DownloadFileCommandEventArgs>(DownloadFileEvents_Post);

            //DocumentServiceExtensions.UpdateFileLifecycleStateEvents.GetRestrictions += new EventHandler<UpdateFileLifeCycleStateCommandEventArgs>(UpdateFileLifecycleStateEvents_GetRestrictions);
            //DocumentServiceExtensions.UpdateFileLifecycleStateEvents.Pre += new EventHandler<UpdateFileLifeCycleStateCommandEventArgs>(UpdateFileLifecycleStateEvents_Pre);
            //DocumentServiceExtensions.UpdateFileLifecycleStateEvents.Post += new EventHandler<UpdateFileLifeCycleStateCommandEventArgs>(UpdateFileLifecycleStateEvents_Post);

            // Folder Events
            //DocumentService.AddFolderEvents.GetRestrictions += new EventHandler<AddFolderCommandEventArgs>(AddFolderEvents_GetRestrictions);
            //DocumentService.AddFolderEvents.Pre += new EventHandler<AddFolderCommandEventArgs>(AddFolderEvents_Pre);
            DocumentService.AddFolderEvents.Post += AddFolderEvents_Post;
            //DocumentService.DeleteFolderEvents.GetRestrictions += new EventHandler<DeleteFolderCommandEventArgs>(DeleteFolderEvents_GetRestrictions);
            //DocumentService.DeleteFolderEvents.Pre += new EventHandler<DeleteFolderCommandEventArgs>(DeleteFolderEvents_Pre);
            //DocumentService.DeleteFolderEvents.Post += new EventHandler<DeleteFolderCommandEventArgs>(DeleteFolderEvents_Post);
            //DocumentService.MoveFolderEvents.GetRestrictions += new EventHandler<MoveFolderCommandEventArgs>(MoveFolderEvent_GetRestrictions);
            //DocumentService.MoveFolderEvents.Pre += new EventHandler<MoveFolderCommandEventArgs>(MoveFolderEvent_Pre);
            //DocumentService.MoveFolderEvents.Post += new EventHandler<MoveFolderCommandEventArgs>(MoveFolderEvent_Post);

            //DocumentServiceExtensions.UpdateFolderLifecycleStateEvents.GetRestrictions += new EventHandler<UpdateFolderLifeCycleStateCommandEventArgs>(UpdateFolderLifecycleStateEvents_GetRestrictions);
            //DocumentServiceExtensions.UpdateFolderLifecycleStateEvents.Pre += new EventHandler<UpdateFolderLifeCycleStateCommandEventArgs>(UpdateFolderLifecycleStateEvents_Pre);
            //DocumentServiceExtensions.UpdateFolderLifecycleStateEvents.Post += new EventHandler<UpdateFolderLifeCycleStateCommandEventArgs>(UpdateFolderLifecycleStateEvents_Post);

            // Item Events
            //ItemService.AddItemEvents.GetRestrictions += new EventHandler<AddItemCommandEventArgs>(AddItemEvents_GetRestrictions);
            //ItemService.AddItemEvents.Pre += new EventHandler<AddItemCommandEventArgs>(AddItemEvents_Post);
            //ItemService.AddItemEvents.Post += new EventHandler<AddItemCommandEventArgs>(AddItemEvents_Post);
            //ItemService.CommitItemEvents.GetRestrictions += new EventHandler<CommitItemCommandEventArgs>(CommitItemEvents_GetRestrictions);
            //ItemService.CommitItemEvents.Pre += new EventHandler<CommitItemCommandEventArgs>(CommitItemEvents_Pre);
            //ItemService.CommitItemEvents.Post += new EventHandler<CommitItemCommandEventArgs>(CommitItemEvents_Post);
            //ItemService.ItemRollbackLifeCycleStatesEvents.GetRestrictions += new EventHandler<ItemRollbackLifeCycleStateCommandEventArgs>(ItemRollbackLifeCycleStatesEvents_GetRestrictions);
            //ItemService.ItemRollbackLifeCycleStatesEvents.Pre += new EventHandler<ItemRollbackLifeCycleStateCommandEventArgs>(ItemRollbackLifeCycleStatesEvents_Pre);
            //ItemService.ItemRollbackLifeCycleStatesEvents.Post += new EventHandler<ItemRollbackLifeCycleStateCommandEventArgs>(ItemRollbackLifeCycleStatesEvents_Pos);
            //ItemService.DeleteItemEvents.GetRestrictions += new EventHandler<DeleteItemCommandEventArgs>(DeleteItemEvents_GetRestrictions);
            //ItemService.DeleteItemEvents.Pre += new EventHandler<DeleteItemCommandEventArgs>(DeleteItemEvents_Pre);
            //ItemService.DeleteItemEvents.Post += new EventHandler<DeleteItemCommandEventArgs>(DeleteItemEvents_Post);
            //ItemService.EditItemEvents.GetRestrictions += new EventHandler<EditItemCommandEventArgs>(EditItemEvents_GetRestrictions);
            //ItemService.EditItemEvents.Pre += new EventHandler<EditItemCommandEventArgs>(EditItemEvents_Pre);
            //ItemService.EditItemEvents.Post += new EventHandler<EditItemCommandEventArgs>(EditItemEvents_Post);
            //ItemService.PromoteItemEvents.GetRestrictions += new EventHandler<PromoteItemCommandEventArgs>(PromoteItemEvents_GetRestrictions);
            //ItemService.PromoteItemEvents.Pre += new EventHandler<PromoteItemCommandEventArgs>(PromoteItemEvents_Pre);
            //ItemService.PromoteItemEvents.Post += new EventHandler<PromoteItemCommandEventArgs>(PromoteItemEvents_Post);
            //ItemService.UpdateItemLifecycleStateEvents.GetRestrictions += new EventHandler<UpdateItemLifeCycleStateCommandEventArgs>(UpdateItemLifecycleStateEvents_GetRestrictions);
            //ItemService.UpdateItemLifecycleStateEvents.Pre += new EventHandler<UpdateItemLifeCycleStateCommandEventArgs>(UpdateItemLifecycleStateEvents_Pre);
            //ItemService.UpdateItemLifecycleStateEvents.Post += new EventHandler<UpdateItemLifeCycleStateCommandEventArgs>(UpdateItemLifecycleStateEvents_Post);

            // Change Order Events
            //ChangeOrderService.AddChangeOrderEvents.GetRestrictions += new EventHandler<AddChangeOrderCommandEventArgs>(AddChangeOrderEvents_GetRestrictions);
            //ChangeOrderService.AddChangeOrderEvents.Pre += new EventHandler<AddChangeOrderCommandEventArgs>(AddChangeOrderEvents_Pre);
            //ChangeOrderService.AddChangeOrderEvents.Post += new EventHandler<AddChangeOrderCommandEventArgs>(AddChangeOrderEvents_Post);
            //ChangeOrderService.CommitChangeOrderEvents.GetRestrictions += new EventHandler<CommitChangeOrderCommandEventArgs>(CommitChangeOrderEvents_GetRestrictions);
            //ChangeOrderService.CommitChangeOrderEvents.Pre += new EventHandler<CommitChangeOrderCommandEventArgs>(CommitChangeOrderEvents_Pre);
            //ChangeOrderService.CommitChangeOrderEvents.Post += new EventHandler<CommitChangeOrderCommandEventArgs>(CommitChangeOrderEvents_Post);
            //ChangeOrderService.DeleteChangeOrderEvents.GetRestrictions += new EventHandler<DeleteChangeOrderCommandEventArgs>(DeleteChangeOrderEvents_GetRestrictions);
            //ChangeOrderService.DeleteChangeOrderEvents.Pre += new EventHandler<DeleteChangeOrderCommandEventArgs>(DeleteChangeOrderEvents_Pre);
            //ChangeOrderService.DeleteChangeOrderEvents.Post += new EventHandler<DeleteChangeOrderCommandEventArgs>(DeleteChangeOrderEvents_Post);
            //ChangeOrderService.EditChangeOrderEvents.GetRestrictions += new EventHandler<EditChangeOrderCommandEventArgs>(EditChangeOrderEvents_GetRestrictions);
            //ChangeOrderService.EditChangeOrderEvents.Pre += new EventHandler<EditChangeOrderCommandEventArgs>(EditChangeOrderEvents_Pre);
            //ChangeOrderService.EditChangeOrderEvents.Post += new EventHandler<EditChangeOrderCommandEventArgs>(EditChangeOrderEvents_Post);
            //ChangeOrderService.UpdateChangeOrderLifecycleStateEvents.GetRestrictions += new EventHandler<UpdateChangeOrderLifeCycleStateCommandEventArgs>(UpdateChangeOrderLifecycleStateEvents_GetRestrictions);
            //ChangeOrderService.UpdateChangeOrderLifecycleStateEvents.Pre += new EventHandler<UpdateChangeOrderLifeCycleStateCommandEventArgs>(UpdateChangeOrderLifecycleStateEvents_Pre);
            //ChangeOrderService.UpdateChangeOrderLifecycleStateEvents.Post += new EventHandler<UpdateChangeOrderLifeCycleStateCommandEventArgs>(UpdateChangeOrderLifecycleStateEvents_Post);

            // Custom Entity Events
            //CustomEntityService.UpdateCustomEntityLifecycleStateEvents.GetRestrictions += new EventHandler<UpdateCustomEntityLifeCycleStateCommandEventArgs>(UpdateCustomEntityLifecycleStateEvents_GetRestrictions);
            //CustomEntityService.UpdateCustomEntityLifecycleStateEvents.Pre += new EventHandler<UpdateCustomEntityLifeCycleStateCommandEventArgs>(UpdateCustomEntityLifecycleStateEvents_Pre);
            //CustomEntityService.UpdateCustomEntityLifecycleStateEvents.Post += new EventHandler<UpdateCustomEntityLifeCycleStateCommandEventArgs>(UpdateCustomEntityLifecycleStateEvents_Post);
            #endregion register events
        }

        private void AddFolderEvents_Post(object sender, AddFolderCommandEventArgs e)
        {
            //Entire code encapsulated by try catch just in case
            try
            {
                //Verify if everything went well and a folder was created
                if (!(e.ReturnValue is Autodesk.Connectivity.WebServices.Folder mFolder))
                    return;

                //Ensure it only runs on the folder created in Industrial and also not on subfolders
                if (mFolder.FullName != String.Format("$/Industrial/{0}", mFolder.Name))
                    return;

                //Ask if they want to create subfolders
                if (MessageBox.Show("Do you want to add standard subfolders to the new folder?", "Populate new folder",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                    return;

                //Find project number from folder name by iterating through it until there is no more numeric characters
                ProjectNumber = "";
                for (int i = 1; i <= mFolder.Name.Length; i++)
                {
                    int resNum;
                    if (int.TryParse(mFolder.Name.Substring(0, i), out resNum))
                    {
                        ProjectNumber = mFolder.Name.Substring(0, i);
                    }
                    else
                    {
                        break;
                    }
                }

                //Prompt with form what folders should be added
                FolderSelection mForm = new FolderSelection();
                mForm.SetDefaultNames(ProjectNumber);
                mForm.ShowDialog();

                //Exit sub if there are no folders to add
                if (mForm.SelectedFolders == null) { return; }

                //Add selected folders
                Autodesk.Connectivity.WebServices.Folder mContFolder;

                //Get the DocumentServiceExtensions object regardless of using it from Inventor or Vault
                Autodesk.Connectivity.WebServices.DocumentServiceExtensions mDocServExt;

                if (sender is Autodesk.Connectivity.WebServices.DocumentServiceExtensions)
                {
                    mDocServExt = (Autodesk.Connectivity.WebServices.DocumentServiceExtensions)sender;
                }
                else if (sender is Autodesk.Connectivity.WebServices.DocumentService mDocServ)
                {
                    mDocServExt = mDocServ.WebServiceManager.DocumentServiceExtensions;
                }
                else
                {
                    MessageBox.Show("No documentservice object could be found, subfolders will not be created!", "Error creating subfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Add folders
                foreach (FolderSelection.FolderName FLD in mForm.SelectedFolders)
                {
                    //Add main folder, exit if folder name is empty string
                    if (FLD.Name == "") { continue; }

                    //Add folder if it does not exist
                    if (mDocServExt.WebServiceManager.DocumentService.FindFoldersByPaths(new string[] { string.Format("{0}/{1}",mFolder.FullName,FLD.Name) })[0].FullName == null)
                    {
                        mContFolder = mDocServExt.WebServiceManager.DocumentService.AddFolder(FLD.Name, mFolder.Id, false);
                    }
                    else
                    {
                        continue;
                    }

                    //Add Subfolders if applicable, exit if subfolder name is empty string
                    if (FLD.ActiveChildren != null)
                    {
                        foreach (string SFLD in FLD.ActiveChildren)
                        {
                            //Add folder, exit if folder is empty string
                            if (SFLD == "") { continue; }

                            //Add folder is it does not exist
                            if (mDocServExt.WebServiceManager.DocumentService.FindFoldersByPaths(new string[] { string.Format("{0}/{1}", mContFolder.FullName, SFLD) })[0].FullName == null)
                            {
                                mDocServExt.WebServiceManager.DocumentService.AddFolder(SFLD, mContFolder.Id, false);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occurred during subfolder creation" + Environment.NewLine + ex.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion IWebServiceExtension Members
    }
}
