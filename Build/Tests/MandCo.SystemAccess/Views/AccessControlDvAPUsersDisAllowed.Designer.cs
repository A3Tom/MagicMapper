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
    partial class AccessControlDvAPUsersDisAllowed
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.Reserved4 clrReserved;
        Theme.Controls.Label lblUserAccessHasBeenDisabledByComputerOperationsStaff;
        Theme.Controls.TextBox txtExp_1;
        Theme.Controls.Button btnVOK;
        Theme.Fonts.Unused1 fntUnused;
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.clrReserved = new MandCo.Theme.Colors.Reserved4();
            this.fntUnused = new MandCo.Theme.Fonts.Unused1();
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff = new MandCo.Theme.Controls.Label();
            this.txtExp_1 = new MandCo.Theme.Controls.TextBox();
            this.btnVOK = new MandCo.Theme.Controls.Button();
            this.SuspendLayout();
            // 
            // lblUserAccessHasBeenDisabledByComputerOperationsStaff
            // 
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.ColorScheme = this.clrReserved;
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.FontScheme = this.fntUnused;
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Location = new System.Drawing.Point(80, 52);
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Multiline = true;
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Name = "lblUserAccessHasBeenDisabledByComputerOperationsStaff";
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Rtf = "User Access has been disabled by Computer Operations staff";
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Size = new System.Drawing.Size(245, 91);
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblUserAccessHasBeenDisabledByComputerOperationsStaff.Text = "User Access has been disabled by Computer Operations staff";
            // 
            // txtExp_1
            // 
            this.txtExp_1.AcceptsReturn = true;
            this.txtExp_1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.txtExp_1.AllowVerticalScroll = true;
            this.txtExp_1.ColorScheme = this.clrReserved;
            this.txtExp_1.FontScheme = this.fntUnused;
            this.txtExp_1.Format = "80";
            this.txtExp_1.Location = new System.Drawing.Point(60, 169);
            this.txtExp_1.Multiline = true;
            this.txtExp_1.Name = "txtExp_1";
            this.txtExp_1.Size = new System.Drawing.Size(280, 78);
            this.txtExp_1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_1.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_1);
            // 
            // btnVOK
            // 
            this.btnVOK.Format = "&OK";
            this.btnVOK.ImageLocation = "Button";
            this.btnVOK.Location = new System.Drawing.Point(165, 273);
            this.btnVOK.Name = "btnVOK";
            this.btnVOK.Size = new System.Drawing.Size(96, 23);
            this.btnVOK.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVOK_Click);
            this.btnVOK.Data = this._controller.vOK;
            // 
            // AccessControlDvAPUsersDisAllowed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.ColorScheme = this.clrReserved;
            this.Controls.Add(this.btnVOK);
            this.Controls.Add(this.txtExp_1);
            this.Controls.Add(this.lblUserAccessHasBeenDisabledByComputerOperationsStaff);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(203, 93);
            this.Name = "AccessControlDvAPUsersDisAllowed";
            this.Text = "Users DisAllowed";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
