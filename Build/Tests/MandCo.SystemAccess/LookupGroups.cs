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
    
    /// <summary>Lookup - Groups(P#15)</summary>
    // Last change before Migration: 27/02/2004 17:25:31
    internal class LookupGroups : UIControllerBase 
    {
        
        #region Models
        
        /// <summary>Groups</summary>
        internal readonly Models.Groups1 Groups1 = new Models.Groups1 { Cached = false, ReadOnly = true };
        #endregion
        
        #region Columns
        
        /// <summary>v:Group</summary>
        readonly Types.Group1 vGroup = new Types.Group1
        {
        	Caption = "v:Group"
        };
        #endregion
        
        
        /// <summary>Lookup - Groups(P#15)</summary>
        public LookupGroups()
        {
            Title = "Lookup - Groups";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Groups1;
            OrderBy = Groups1.SortBySA_GROUP_X1;
            
            #region Columns
            
            Columns.Add(vGroup);
            Columns.Add(Groups1.GroupID);
            Columns.Add(Groups1.GroupDescription);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Lookup - Groups</summary>
        /// <param name="pvGroup">v:Group</param>
        public void Run(TextParameter pvGroup)
        {
            BindParameter(vGroup, pvGroup);
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
            View = ()=> new Views.LookupGroupsView(this);
        }
        protected override void OnSavingRow()
        {
            vGroup.Value = Groups1.GroupID;
        }
        
        
    }
}
