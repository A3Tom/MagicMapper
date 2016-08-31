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
    partial class MaintUsersPvEmailAddresses
    {
        System.ComponentModel.IContainer components;
        Theme.Controls.GroupBox grpEmailAddresses;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.Label lblSeq;
        Theme.Controls.Label lblEmailAddress;
        Theme.Controls.TextBox txtUserEmailAddressesAddressSeq;
        Theme.Controls.TextBox txtUserEmailAddressesEmailAddress;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Colors.DefaultHyperlink clrDefaultHyperlink;
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
            this.clrDefaultHyperlink = new MandCo.Theme.Colors.DefaultHyperlink();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtUserEmailAddressesAddressSeq = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtUserEmailAddressesEmailAddress = new MandCo.Theme.Controls.TextBox();
            this.grpEmailAddresses = new MandCo.Theme.Controls.GroupBox();
            this.lblSeq = new MandCo.Theme.Controls.Label();
            this.lblEmailAddress = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(15, 15);
            this.grd.Name = "grd";
            this.grd.RowHeight = 22;
            this.grd.Size = new System.Drawing.Size(360, 281);
            this.grd.Style = Firefly.Box.UI.ControlStyle.Raised;
            this.grd.UseVisualStyles = true;
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUserEmailAddressesAddressSeq);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 34;
            // 
            // txtUserEmailAddressesAddressSeq
            // 
            this.txtUserEmailAddressesAddressSeq.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtUserEmailAddressesAddressSeq.AllowFocus = false;
            this.txtUserEmailAddressesAddressSeq.Location = new System.Drawing.Point(6, 1);
            this.txtUserEmailAddressesAddressSeq.Name = "txtUserEmailAddressesAddressSeq";
            this.txtUserEmailAddressesAddressSeq.Size = new System.Drawing.Size(15, 17);
            this.txtUserEmailAddressesAddressSeq.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserEmailAddressesAddressSeq.TabIndex = 1;
            this.txtUserEmailAddressesAddressSeq.BindAllowFocus += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.txtUserEmailAddressesAddressSeq_BindAllowFocus);
            this.txtUserEmailAddressesAddressSeq.Data = this._controller.UserEmailAddresses.AddressSeq;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtUserEmailAddressesEmailAddress);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 311;
            // 
            // txtUserEmailAddressesEmailAddress
            // 
            this.txtUserEmailAddressesEmailAddress.Location = new System.Drawing.Point(9, 1);
            this.txtUserEmailAddressesEmailAddress.Name = "txtUserEmailAddressesEmailAddress";
            this.txtUserEmailAddressesEmailAddress.Size = new System.Drawing.Size(288, 17);
            this.txtUserEmailAddressesEmailAddress.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserEmailAddressesEmailAddress.TabIndex = 2;
            this.txtUserEmailAddressesEmailAddress.Data = this._controller.UserEmailAddresses.EmailAddress;
            // 
            // grpEmailAddresses
            // 
            this.grpEmailAddresses.ColorScheme = this.clrDefaultHyperlink;
            this.grpEmailAddresses.Location = new System.Drawing.Point(7, 0);
            this.grpEmailAddresses.Name = "grpEmailAddresses";
            this.grpEmailAddresses.Size = new System.Drawing.Size(378, 287);
            this.grpEmailAddresses.Style = Firefly.Box.UI.ControlStyle.Sunken;
            this.grpEmailAddresses.Text = "Email; Addresses";
            // 
            // lblSeq
            // 
            this.lblSeq.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblSeq.Location = new System.Drawing.Point(23, 18);
            this.lblSeq.Name = "lblSeq";
            this.lblSeq.Rtf = "Seq";
            this.lblSeq.Size = new System.Drawing.Size(22, 13);
            this.lblSeq.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblSeq.Text = "Seq";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblEmailAddress.Location = new System.Drawing.Point(60, 18);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Rtf = "Email Address";
            this.lblEmailAddress.Size = new System.Drawing.Size(71, 13);
            this.lblEmailAddress.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // MaintUsersPvEmailAddresses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(386, 302);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblSeq);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.grpEmailAddresses);
            this.HorizontalExpressionFactor = 100D;
            this.HorizontalScale = 37.7952755905512D;
            this.Location = new System.Drawing.Point(229, 64);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintUsersPvEmailAddresses";
            this.SystemMenu = false;
            this.Text = "Email Addresses";
            this.TitleBar = false;
            this.VerticalExpressionFactor = 100D;
            this.VerticalScale = 37.7952755905512D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
