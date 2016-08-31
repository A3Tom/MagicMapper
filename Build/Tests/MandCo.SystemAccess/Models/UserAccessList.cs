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
    
    /// <summary>UserAccessList(E#6)</summary>
    public class UserAccessList : Entity 
    {
        
        #region Columns
        
        /// <summary>Application</summary>
        [PrimaryKey]
        public readonly Types.Application1 Application1 = new Types.Application1
        {
        	Name = "Application"
        };
        #endregion
        
        #region Indexes
        
        /// <summary>UserAccess_X1</summary>
        public readonly Index SortByUserAccess_X1 = new Index
        {
        	Caption = "UserAccess_X1",
        	AutoCreate = true,
        	Unique = true
        };
        #endregion
        
        
        /// <summary>UserAccessList(E#6)</summary>
        public UserAccessList():base("xxFIL006.dat", "UserAccessList", DataSources.Memory)
        {
            InitializeIndexes();
        }
        void InitializeIndexes()
        {
            SortByUserAccess_X1.Add(Application1);
            
        }
        
        
    }
}
