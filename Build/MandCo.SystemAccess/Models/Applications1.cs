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
    
    /// <summary>Applications(E#10)</summary>
    public class Applications1 : OracleEntity 
    {
        
        #region Columns
        
        /// <summary>Application</summary>
        public readonly TextColumn Application1 = new TextColumn("APPLICATION", "30", "Application");
        
        /// <summary>Application ID</summary>
        public readonly TextColumn ApplicationID = new TextColumn("APPLICATION_ID", "2", "Application ID");
        
        /// <summary>Application Descript</summary>
        public readonly TextColumn ApplicationDescript = new TextColumn("APPLICATION_DESCRIPT", "50", "Application Descript");
        
        /// <summary>DotNet Path</summary>
        public readonly TextColumn DotNetPath = new TextColumn("DotNet_Path", "100", "DotNet Path")
        {
        	AllowNull = true
        };
        #endregion
        
        #region Indexes
        
        /// <summary>SA_UP_APP_X1</summary>
        public readonly Index SortBySA_UP_APP_X1 = new Index
        {
        	Caption = "SA_UP_APP_X1",
        	Name = "SA_UP_APP_X1",
        	AutoCreate = true,
        	Unique = true
        };
        
        /// <summary>SA_UP_APP_X2</summary>
        public readonly Index SortBySA_UP_APP_X2 = new Index
        {
        	Caption = "SA_UP_APP_X2",
        	Name = "SA_UP_APP_X2",
        	AutoCreate = true,
        	Unique = true
        };
        #endregion
        
        
        /// <summary>Applications(E#10)</summary>
        public Applications1():base("mackays.SA_UP_App", "Applications", DataSources.SA)
        {
            UseRowIdAsPrimaryKey();
            InitializeIndexes();
        }
        void InitializeIndexes()
        {
            SortBySA_UP_APP_X1.Add(Application1);
            
            SortBySA_UP_APP_X2.Add(ApplicationID);
            
        }
        
        
    }
}
