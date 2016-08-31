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
    
    /// <summary>DocsList(P#12)</summary>
    // Last change before Migration: 27/02/2004 17:18:28
    internal class DocsList : FlowUIControllerBase 
    {
        
        #region Columns
        
        /// <summary>v:DocsDirectory</summary>
        readonly TextColumn vDocsDirectory = new TextColumn("v:DocsDirectory", "50");
        
        /// <summary>v:ApplicationPrefix</summary>
        readonly TextColumn vApplicationPrefix = new TextColumn("v:ApplicationPrefix", "2");
        
        /// <summary>b:Specifications</summary>
        internal readonly TextColumn bSpecifications = new TextColumn("b:Specifications", "1");
        
        /// <summary>b:RunRequests</summary>
        internal readonly TextColumn bRunRequests = new TextColumn("b:RunRequests", "1");
        #endregion
        
        
        /// <summary>DocsList(P#12)</summary>
        public DocsList()
        {
            Title = "DocsList";
            InitializeDataViewAndUserFlow();
        }
        void InitializeDataViewAndUserFlow()
        {
            #region Columns and User Flow
            
            Columns.Add(vDocsDirectory);
            Columns.Add(vApplicationPrefix).BindValue(() => u.Right("xx", 2));
            Columns.Add(bSpecifications);
            Flow.StartBlock(FlowMode.ExpandAfter);
            #region Block
            {
                Flow.Add(() => vDocsDirectory.SilentSet(@"j:\Dev\Docs\Specs\" + u.Right("xx", 2)));
                Flow.Add(() => Windows.OSCommand("explorer.exe " + u.Trim(vDocsDirectory)), FlowMode.Tab);
            }
            Flow.EndBlock();
            #endregion
            Columns.Add(bRunRequests);
            Flow.StartBlock(FlowMode.ExpandAfter);
            #region Block
            {
                Flow.Add(() => vDocsDirectory.SilentSet(@"j:\Ops\Docs\rrf\" + u.Right("xx", 2)));
                Flow.Add(() => Windows.OSCommand("explorer.exe " + u.Trim(vDocsDirectory)), FlowMode.Tab);
            }
            Flow.EndBlock();
            #endregion
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>DocsList</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            OnDatabaseErrorRetry = false;
            View = ()=> new Views.DocsListDocumentationList(this);
        }
        
        
    }
}
