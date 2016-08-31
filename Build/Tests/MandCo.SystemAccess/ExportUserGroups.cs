#region Copyright Firefly Ltd 2014
/* *********************** DISCLAIMER **************************************
 * This software and documentation constitute an unpublished work and contain 
 * valuable trade secrets and proprietary information belonging to Firefly Ltd. 
 * None of the foregoing material may be copied, duplicated or disclosed without 
 * the express written permission of Firefly Ltd. 
 * FIREFLY LTD EXPRESSLY DISCLAIMS ANY AND ALL WARRANTIES CONCERNING THIS SOFTWARE 
 * AND DOCUMENTATION, INCLUDING ANY WARRANTIES OF MERCHANTABILITY AND/OR FITNESS 
 * FOR ANY PARTICULAR PURPOSE, AND WARRANTIES OF PERFORMANCE, AND ANY WARRANTY 
 * THAT MIGHT OTHERWISE ARISE FROM COURSE OF DEALING OR USAGE OF TRADE. NO WARRANTY 
 * IS EITHER EXPRESS OR IMPLIED WITH RESPECT TO THE USE OF THE SOFTWARE OR 
 * DOCUMENTATION. 
 * Under no circumstances shall Firefly Ltd be liable for incidental, special, 
 * indirect, direct or consequential damages or loss of profits, interruption of 
 * business, or related expenses which may arise from use of software or documentation, 
 * including but not limited to those resulting from defects in software and/or 
 * documentation, or loss or inaccuracy of data of any kind. 
 */
#endregion
using Firefly.Box;
using ENV.Data;
using ENV;
namespace MandCo.SystemAccess
{
    
    /// <summary>Export - UserGroups(P#31)</summary>
    // Last change before Migration: 27/02/2004 17:37:57
    class ExportUserGroups : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>UserGroups</summary>
        readonly Models.UserGroups UserGroups = new Models.UserGroups { ReadOnly = true };
        #endregion
        
        #region Streams
        
        /// <summary>Export - UserGroups</summary>
        ENV.IO.FileWriter _ioExportUserGroups;
        #endregion
        
        #region Layouts
        
        /// <summary>Export - UserGroups</summary>
        MandCo.Theme.IO.TextSection _viewExportUserGroups;
        #endregion
        
        
        /// <summary>Export - UserGroups(P#31)</summary>
        public ExportUserGroups()
        {
            Title = "Export - UserGroups";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Export - UserGroups
            
            _viewExportUserGroups = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 29
            			};
            var txtUserGroupsGroupID = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 20,
            				Data = UserGroups.GroupID
            			};
            var txtUserGroupsUserID = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 21,
            				Width = 8,
            				Data = UserGroups.UserID
            			};
            _viewExportUserGroups.Controls.Add(txtUserGroupsUserID);
            _viewExportUserGroups.Controls.Add(txtUserGroupsGroupID);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = UserGroups;
            OrderBy = UserGroups.SortBySA_USERGROUP_X1;
            
            #region Columns
            
            Columns.Add(UserGroups.GroupID);
            Columns.Add(UserGroups.UserID);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Export - UserGroups</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Browse;
            AllowUserAbort = true;
            
            _ioExportUserGroups = new ENV.IO.FileWriter(@"%magic%\sa\SA_UserGroup.TXT")
            			{
            				Name = "Export - UserGroups"
            			};
            _ioExportUserGroups.Open();
            Streams.Add(_ioExportUserGroups);
        }
        protected override void OnLeaveRow()
        {
            _viewExportUserGroups.WriteTo(_ioExportUserGroups);
        }
        
        
    }
}
