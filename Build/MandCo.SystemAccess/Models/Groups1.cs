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
namespace MandCo.SystemAccess.Models
{
    
    /// <summary>Groups(E#2)</summary>
    public class Groups1 : OracleEntity 
    {
        
        #region Columns
        
        /// <summary>GroupID</summary>
        public readonly TextColumn GroupID = new TextColumn("GROUPID", "20", "GroupID");
        
        /// <summary>Group Description</summary>
        public readonly TextColumn GroupDescription = new TextColumn("GROUP_DESCRIPTION", "30", "Group Description");
        #endregion
        
        #region Indexes
        
        /// <summary>SA_GROUP_X1</summary>
        public readonly Index SortBySA_GROUP_X1 = new Index
        {
        	Caption = "SA_GROUP_X1",
        	Name = "SA_GROUP_X1",
        	AutoCreate = true,
        	Unique = true
        };
        #endregion
        
        
        /// <summary>Groups(E#2)</summary>
        public Groups1():base("mackays.SA_Group", "Groups", DataSources.SA)
        {
            UseRowIdAsPrimaryKey();
            InitializeIndexes();
        }
        void InitializeIndexes()
        {
            SortBySA_GROUP_X1.Add(GroupID);
            
        }
        
        
    }
}
