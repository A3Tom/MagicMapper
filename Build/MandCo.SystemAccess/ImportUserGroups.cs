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
    
    /// <summary>Import - UserGroups(P#39)</summary>
    // Last change before Migration: 27/02/2004 17:38:28
    class ImportUserGroups : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>UserGroups</summary>
        readonly Models.UserGroups UserGroups = new Models.UserGroups { AllowRowLocking = true };
        #endregion
        
        #region Streams
        
        /// <summary>Import - UserGroups</summary>
        ENV.IO.FileReader _ioImportUserGroups;
        #endregion
        
        #region Layouts
        
        /// <summary>Import - UserGroups</summary>
        MandCo.Theme.IO.TextSection _viewImportUserGroups;
        #endregion
        
        
        /// <summary>Import - UserGroups(P#39)</summary>
        public ImportUserGroups()
        {
            Title = "Import - UserGroups";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Import - UserGroups
            
            _viewImportUserGroups = new MandCo.Theme.IO.TextSection(this)
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
            _viewImportUserGroups.Controls.Add(txtUserGroupsUserID);
            _viewImportUserGroups.Controls.Add(txtUserGroupsGroupID);
            
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
        
        /// <summary>Import - UserGroups</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            Exit(ExitTiming.BeforeRow, () => _ioImportUserGroups.EndOfFile);
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Insert;
            AllowUserAbort = true;
            
            _ioImportUserGroups = new ENV.IO.FileReader(@"%magic%\sa\SA_UserGroup.TXT")
            			{
            				Name = "Import - UserGroups"
            			};
            Streams.Add(_ioImportUserGroups);
        }
        protected override void OnLeaveRow()
        {
            _viewImportUserGroups.ReadFrom(_ioImportUserGroups);
        }
        
        
    }
}
