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
using Firefly.Box.Flow;
namespace MandCo.SystemAccess
{
    
    /// <summary>Lookup - Users(P#16)</summary>
    // Last change before Migration: 27/02/2004 17:26:28
    internal class LookupUsers : UIControllerBase 
    {
        
        #region Models
        
        /// <summary>Users</summary>
        internal readonly Models.Users Users = new Models.Users { Cached = false, ReadOnly = true };
        #endregion
        
        #region Columns
        
        /// <summary>v:User</summary>
        readonly Types.User1 vUser = new Types.User1
        {
        	Caption = "v:User"
        };
        #endregion
        
        
        /// <summary>Lookup - Users(P#16)</summary>
        public LookupUsers()
        {
            Title = "Lookup - Users";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Users;
            OrderBy = Users.SortBySA_USER_X1;
            
            #region Columns
            
            Columns.Add(vUser);
            Columns.Add(Users.UserID);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Lookup - Users</summary>
        /// <param name="pvUser">v:User</param>
        public void Run(TextParameter pvUser)
        {
            BindParameter(vUser, pvUser);
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnUserEdit;
            TransactionScope = TransactionScopes.RowLocking;
            OnDatabaseErrorRetry = false;
            Activity = Activities.Browse;
            SwitchToInsertWhenNoRows = true;
            AllowDelete = false;
            AllowInsert = false;
            AllowUpdate = false;
            AllowSelect = true;
            View = ()=> new Views.LookupUsersView(this);
        }
        protected override void OnSavingRow()
        {
            vUser.Value = Users.UserID;
        }
        
        
    }
}
