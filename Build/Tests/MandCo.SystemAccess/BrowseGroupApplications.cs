﻿#region Copyright Firefly Ltd 2014
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
    
    /// <summary>Browse - GroupApplications(P#23)</summary>
    // Last change before Migration: 27/02/2004 17:31:06
    internal class BrowseGroupApplications : UIControllerBase 
    {
        
        #region Models
        
        /// <summary>GroupApplications</summary>
        internal readonly Models.GroupApplications GroupApplications = new Models.GroupApplications { Cached = false, AllowRowLocking = true };
        #endregion
        
        
        /// <summary>Browse - GroupApplications(P#23)</summary>
        public BrowseGroupApplications()
        {
            Title = "Browse - GroupApplications";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = GroupApplications;
            OrderBy = GroupApplications.SortBySA_GROUPAPP_X1;
            
            #region Columns
            
            Columns.Add(GroupApplications.GroupID);
            Columns.Add(GroupApplications.Application1);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Browse - GroupApplications</summary>
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
            Activity = Activities.Browse;
            SwitchToInsertWhenNoRows = true;
            BindAllowDelete(() => Roles.ModifyInBrowse.Allowed);
            BindAllowInsert(() => Roles.ModifyInBrowse.Allowed);
            BindAllowUpdate(() => Roles.ModifyInBrowse.Allowed);
            View = ()=> new Views.BrowseGroupApplicationsView(this);
        }
        
        
    }
}
