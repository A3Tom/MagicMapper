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
namespace MandCo.SystemAccess.Views
{
    internal partial class DefaultContextMenu : System.Windows.Forms.ContextMenuStrip 
    {
        
        public void InitUserBasedMenus()
        {
            mnu1OffPopUserEmailTable.Visible = SystemAccess.Roles.ModifyInBrowse.Allowed;
        }
        public DefaultContextMenu(System.ComponentModel.IContainer container):base(container)
        {
            InitializeComponent();
            InitUserBasedMenus();
            ENV.MenuManager.Instance.MapMenu("", mnu1OffPopUserEmailTable, ()=>SystemAccess.Roles.ModifyInBrowse.Allowed);
            ENV.MenuManager.Instance.MapMenu("", mnuAccessControlDV2);
            ENV.Languages.TranslateMenu(this);
        }
        protected override void OnOpened(System.EventArgs e)
        {
            ENV.Common.RunOnLogicContext(this, ()=>{});
        }
        void No1OffPopUserEmailTable_Click(object sender, System.EventArgs e)
        {
            ENV.Common.CloseActiveTasksAndRunMenuItem(mnu1OffPopUserEmailTable, () => new SystemAccess.No1OffPopUserEmailTable().Run());
        }
        void AccessControlDV2_Click(object sender, System.EventArgs e)
        {
            ENV.Common.CloseActiveTasksAndRunMenuItem(mnuAccessControlDV2, () => new SystemAccess.AccessControlDV().Run());
        }
        
        
    }
}
