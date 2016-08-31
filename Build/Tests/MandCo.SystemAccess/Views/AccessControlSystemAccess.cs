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
using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
namespace MandCo.SystemAccess.Views
{
    
    /// <summary>AccessScreen(P#2.1)</summary>
    partial class AccessControlSystemAccess : MandCo.Theme.Controls.Form 
    {
        AccessControl.AccessScreen _controller;
        
        
        /// <summary>AccessScreen(P#2.1)</summary>
        internal AccessControlSystemAccess(AccessControl.AccessScreen controller)
        {
            _controller = controller;
            InitializeComponent();
        }
        void btnVAllowUserAccess_Click(object sender, ButtonClickEventArgs e)
        {
            e.Raise(_controller.AllowAccess);
        }
        void btnVDisAllowUserAccess_Click(object sender, ButtonClickEventArgs e)
        {
            e.Raise(_controller.DoNotAllowAccess);
        }
        void btnVSelect_Click(object sender, ButtonClickEventArgs e)
        {
            e.Raise(Command.Select);
        }
        void btnVExit_Click(object sender, ButtonClickEventArgs e)
        {
            e.Raise(Command.ExitApplication);
        }
        void Exp_14_BindVisible(object sender, BooleanBindingEventArgs e)
        {
            e.Value = _controller.Exp_14();
        }
        void txtVUserAccessMessage_BindColorScheme(object sender, ColorSchemeBindingEventArgs e)
        {
            e.Value = MandCo.Theme.Colors.Map.Find(_controller.Exp_3());
        }
        
        
    }
}
