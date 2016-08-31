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
    
    /// <summary>1 off Pop User Email Table(P#54)</summary>
    // Last change before Migration: 08/05/2003 15:42:37
    class No1OffPopUserEmailTable : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Users</summary>
        readonly Models.Users Users = new Models.Users { ReadOnly = true };
        
        /// <summary>User Email Addresses</summary>
        readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
        #endregion
        
        
        /// <summary>1 off Pop User Email Table(P#54)</summary>
        public No1OffPopUserEmailTable()
        {
            Title = "1 off Pop User Email Table";
            ConfirmExecution = true;
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Users;
            Relations.Add(UserEmailAddresses, RelationType.Insert, 
            		UserEmailAddresses.MagicUser.BindEqualTo(Users.UserID).And(
            		UserEmailAddresses.AddressSeq.BindEqualTo(1)), 
            	UserEmailAddresses.SortBySA_User_Email_Addresses_X1);
            
            OrderBy = Users.SortBySA_USER_X1;
            
            #region Columns
            
            Columns.Add(Users.UserID);
            
            Columns.Add(UserEmailAddresses.MagicUser);
            Columns.Add(UserEmailAddresses.AddressSeq);
            Columns.Add(UserEmailAddresses.EmailAddress).BindValue(() => u.Trim(u.Lower(Users.UserID)) + "@mackaysstores.co.uk");
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>1 off Pop User Email Table</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnUserEdit;
            TransactionScope = TransactionScopes.RowLocking;
            AllowUserAbort = true;
            KeepViewVisibleAfterExit = true;
        }
        
        
    }
}
