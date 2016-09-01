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
    partial class BrowseUserEmailAddressesView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblBrowseUserEmailAddresses;
        Theme.Controls.Line lin;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.GridColumn gcl2;
        Theme.Controls.Label lblUser;
        Theme.Controls.Label lblAddressSeq;
        Theme.Controls.Label lblEmailAddress;
        Controls.Group_txt txtUserEmailAddressesMagicUser;
        Theme.Controls.TextBox txtUserEmailAddressesAddressSeq;
        Theme.Controls.TextBox txtUserEmailAddressesEmailAddress;
        Theme.Colors.Default3DEffect clrDefault3DEffect;
        Theme.Fonts.Unused1 fntUnused;
        Theme.Colors.DefaultFreeText clrDefaultFreeText;
        Theme.Fonts.TableTitle fntTableTitle;
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
            this.clrDefaultHelpWindow = new MandCo.Theme.Colors.DefaultHelpWindow();
            this.clrDefault3DEffect = new MandCo.Theme.Colors.Default3DEffect();
            this.fntUnused = new MandCo.Theme.Fonts.Unused1();
            this.clrDefaultFreeText = new MandCo.Theme.Colors.DefaultFreeText();
            this.fntTableTitle = new MandCo.Theme.Fonts.TableTitle();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtUserEmailAddressesMagicUser = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtUserEmailAddressesAddressSeq = new MandCo.Theme.Controls.TextBox();
            this.gcl2 = new MandCo.Theme.Controls.GridColumn();
            this.txtUserEmailAddressesEmailAddress = new MandCo.Theme.Controls.TextBox();
            this.lblBrowseUserEmailAddresses = new MandCo.Theme.Controls.Label();
            this.lin = new MandCo.Theme.Controls.Line();
            this.lblUser = new MandCo.Theme.Controls.Label();
            this.lblAddressSeq = new MandCo.Theme.Controls.Label();
            this.lblEmailAddress = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.gcl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.Controls.Add(this.gcl2);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 65);
            this.grd.Name = "grd";
            this.grd.RowHeight = 20;
            this.grd.Size = new System.Drawing.Size(735, 361);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUserEmailAddressesMagicUser);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 80;
            // 
            // txtUserEmailAddressesMagicUser
            // 
            this.txtUserEmailAddressesMagicUser.Location = new System.Drawing.Point(3, 1);
            this.txtUserEmailAddressesMagicUser.Name = "txtUserEmailAddressesMagicUser";
            this.txtUserEmailAddressesMagicUser.Size = new System.Drawing.Size(69, 13);
            this.txtUserEmailAddressesMagicUser.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserEmailAddressesMagicUser.TabIndex = 1;
            this.txtUserEmailAddressesMagicUser.Data = this._controller.UserEmailAddresses.MagicUser;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtUserEmailAddressesAddressSeq);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 75;
            // 
            // txtUserEmailAddressesAddressSeq
            // 
            this.txtUserEmailAddressesAddressSeq.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtUserEmailAddressesAddressSeq.Location = new System.Drawing.Point(2, 1);
            this.txtUserEmailAddressesAddressSeq.Name = "txtUserEmailAddressesAddressSeq";
            this.txtUserEmailAddressesAddressSeq.Size = new System.Drawing.Size(19, 13);
            this.txtUserEmailAddressesAddressSeq.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserEmailAddressesAddressSeq.TabIndex = 2;
            this.txtUserEmailAddressesAddressSeq.Data = this._controller.UserEmailAddresses.AddressSeq;
            // 
            // gcl2
            // 
            this.gcl2.Controls.Add(this.txtUserEmailAddressesEmailAddress);
            this.gcl2.Name = "gcl2";
            this.gcl2.UseTextEndEllipsis = true;
            this.gcl2.Width = 565;
            // 
            // txtUserEmailAddressesEmailAddress
            // 
            this.txtUserEmailAddressesEmailAddress.Location = new System.Drawing.Point(2, 1);
            this.txtUserEmailAddressesEmailAddress.Name = "txtUserEmailAddressesEmailAddress";
            this.txtUserEmailAddressesEmailAddress.Size = new System.Drawing.Size(550, 13);
            this.txtUserEmailAddressesEmailAddress.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserEmailAddressesEmailAddress.TabIndex = 3;
            this.txtUserEmailAddressesEmailAddress.Data = this._controller.UserEmailAddresses.EmailAddress;
            // 
            // lblBrowseUserEmailAddresses
            // 
            this.lblBrowseUserEmailAddresses.ColorScheme = this.clrDefaultFreeText;
            this.lblBrowseUserEmailAddresses.FontScheme = this.fntUnused;
            this.lblBrowseUserEmailAddresses.Location = new System.Drawing.Point(10, 13);
            this.lblBrowseUserEmailAddresses.Name = "lblBrowseUserEmailAddresses";
            this.lblBrowseUserEmailAddresses.Rtf = "Browse - User Email Addresses";
            this.lblBrowseUserEmailAddresses.Size = new System.Drawing.Size(276, 26);
            this.lblBrowseUserEmailAddresses.Text = "Browse - User Email Addresses";
            // 
            // lin
            // 
            this.lin.BoundTo = new Firefly.Box.UI.ControlBinding(this.lblBrowseUserEmailAddresses);
            this.lin.ColorScheme = this.clrDefaultFreeText;
            this.lin.End = new System.Drawing.Point(710, 46);
            this.lin.Name = "lin";
            this.lin.Start = new System.Drawing.Point(5, 46);
            this.lin.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblUser
            // 
            this.lblUser.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblUser.ColorScheme = this.clrDefaultHelpWindow;
            this.lblUser.FontScheme = this.fntTableTitle;
            this.lblUser.Location = new System.Drawing.Point(10, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Rtf = "User";
            this.lblUser.Size = new System.Drawing.Size(28, 13);
            this.lblUser.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblUser.Text = "User";
            // 
            // lblAddressSeq
            // 
            this.lblAddressSeq.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblAddressSeq.ColorScheme = this.clrDefaultHelpWindow;
            this.lblAddressSeq.FontScheme = this.fntTableTitle;
            this.lblAddressSeq.Location = new System.Drawing.Point(89, 68);
            this.lblAddressSeq.Name = "lblAddressSeq";
            this.lblAddressSeq.Rtf = "Address Seq";
            this.lblAddressSeq.Size = new System.Drawing.Size(65, 13);
            this.lblAddressSeq.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblAddressSeq.Text = "Address Seq";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.BoundTo = new Firefly.Box.UI.ControlBinding(gcl2);
            this.lblEmailAddress.ColorScheme = this.clrDefaultHelpWindow;
            this.lblEmailAddress.FontScheme = this.fntTableTitle;
            this.lblEmailAddress.Location = new System.Drawing.Point(164, 68);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Rtf = "Email Address";
            this.lblEmailAddress.Size = new System.Drawing.Size(71, 13);
            this.lblEmailAddress.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // BrowseUserEmailAddressesView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 447);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblAddressSeq);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.lin);
            this.Controls.Add(this.lblBrowseUserEmailAddresses);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "BrowseUserEmailAddressesView";
            this.Text = "Browse - User Email Addresses";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.gcl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
