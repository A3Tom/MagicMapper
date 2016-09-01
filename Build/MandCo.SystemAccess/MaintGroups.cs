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
    
    /// <summary>Maint - Groups(P#6)</summary>
    // Last change before Migration: 27/02/2004 17:14:17
    internal class MaintGroups : UIControllerBase 
    {
        
        #region Models
        
        /// <summary>Groups</summary>
        internal readonly Models.Groups1 Groups1 = new Models.Groups1 { Cached = false, AllowRowLocking = true };
        #endregion
        
        
        /// <summary>Maint - Groups(P#6)</summary>
        public MaintGroups()
        {
            Title = "Maint - Groups";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Groups1;
            OrderBy = Groups1.SortBySA_GROUP_X1;
            
            #region Columns
            
            Columns.Add(Groups1.GroupID);
            Columns.Add(Groups1.GroupDescription);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Maint - Groups</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnUserEdit;
            TransactionScope = TransactionScopes.RowLocking;
            OnDatabaseErrorRetry = false;
            SwitchToInsertWhenNoRows = true;
            BindAllowDelete(() => Roles.AccessControl3.Allowed);
            BindAllowInsert(() => Roles.AccessControl3.Allowed);
            BindAllowUpdate(() => Roles.AccessControl3.Allowed);
            GoToToNextRowAfterLastControl = true;
            View = ()=> new Views.MaintGroupsGroups(this);
        }
        
        #region Expressions
        internal Bool Exp_2()
        {
            return Activity == Activities.Insert;
        }
        #endregion
        
        
    }
}
