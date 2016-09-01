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
    
    /// <summary>Import - Users(P#36)</summary>
    // Last change before Migration: 27/02/2004 17:38:15
    class ImportUsers : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Users</summary>
        readonly Models.Users Users = new Models.Users { AllowRowLocking = true };
        #endregion
        
        #region Streams
        
        /// <summary>Import - Users</summary>
        ENV.IO.FileReader _ioImportUsers;
        #endregion
        
        #region Layouts
        
        /// <summary>Import - Users</summary>
        MandCo.Theme.IO.TextSection _viewImportUsers;
        #endregion
        
        
        /// <summary>Import - Users(P#36)</summary>
        public ImportUsers()
        {
            Title = "Import - Users";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Import - Users
            
            _viewImportUsers = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 19
            			};
            var txtUsersUserID = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 8,
            				Data = Users.UserID
            			};
            var txtUsersUserName = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 9,
            				Width = 10,
            				Data = Users.UserName
            			};
            _viewImportUsers.Controls.Add(txtUsersUserName);
            _viewImportUsers.Controls.Add(txtUsersUserID);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = Users;
            OrderBy = Users.SortBySA_USER_X1;
            
            #region Columns
            
            Columns.Add(Users.UserID);
            Columns.Add(Users.UserName);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Import - Users</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            Exit(ExitTiming.BeforeRow, () => _ioImportUsers.EndOfFile);
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Insert;
            AllowUserAbort = true;
            
            _ioImportUsers = new ENV.IO.FileReader(@"%magic%\sa\SA_User.TXT")
            			{
            				Name = "Import - Users"
            			};
            Streams.Add(_ioImportUsers);
        }
        protected override void OnLeaveRow()
        {
            _viewImportUsers.ReadFrom(_ioImportUsers);
        }
        
        
    }
}
