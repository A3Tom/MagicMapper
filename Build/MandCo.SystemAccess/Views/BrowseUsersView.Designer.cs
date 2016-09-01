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
    partial class BrowseUsersView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblBrowseUsers;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblUser;
        Theme.Controls.Label lblUserName;
        Theme.Controls.TextBox txtUsersUserID;
        Theme.Controls.TextBox txtUsersUserName;
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
            this.txtUsersUserID = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtUsersUserName = new MandCo.Theme.Controls.TextBox();
            this.lblBrowseUsers = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.lblUser = new MandCo.Theme.Controls.Label();
            this.lblUserName = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 52);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(194, 301);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUsersUserID);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 84;
            // 
            // txtUsersUserID
            // 
            this.txtUsersUserID.ColorScheme = this.clrDefault3DEffect;
            this.txtUsersUserID.Format = "U8";
            this.txtUsersUserID.Location = new System.Drawing.Point(3, 1);
            this.txtUsersUserID.Name = "txtUsersUserID";
            this.txtUsersUserID.Size = new System.Drawing.Size(73, 16);
            this.txtUsersUserID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUsersUserID.TabIndex = 1;
            this.txtUsersUserID.Data = this._controller.Users.UserID;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtUsersUserName);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 95;
            // 
            // txtUsersUserName
            // 
            this.txtUsersUserName.ColorScheme = this.clrDefault3DEffect;
            this.txtUsersUserName.Format = "UX9";
            this.txtUsersUserName.Location = new System.Drawing.Point(2, 1);
            this.txtUsersUserName.Name = "txtUsersUserName";
            this.txtUsersUserName.Size = new System.Drawing.Size(80, 16);
            this.txtUsersUserName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUsersUserName.TabIndex = 2;
            this.txtUsersUserName.Data = this._controller.Users.UserName;
            // 
            // lblBrowseUsers
            // 
            this.lblBrowseUsers.ColorScheme = this.clrDefaultFreeText;
            this.lblBrowseUsers.FontScheme = this.fntUnused;
            this.lblBrowseUsers.Location = new System.Drawing.Point(10, 7);
            this.lblBrowseUsers.Name = "lblBrowseUsers";
            this.lblBrowseUsers.Rtf = "Browse - Users";
            this.lblBrowseUsers.Size = new System.Drawing.Size(150, 26);
            this.lblBrowseUsers.Text = "Browse - Users";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.FontScheme = this.fntUnused;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(195, 7);
            this.shp.Square = true;
            this.shp.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblUser
            // 
            this.lblUser.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblUser.ColorScheme = this.clrDefaultHelpWindow;
            this.lblUser.FontScheme = this.fntTableTitle;
            this.lblUser.Location = new System.Drawing.Point(10, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Rtf = "User";
            this.lblUser.Size = new System.Drawing.Size(28, 13);
            this.lblUser.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblUser.Text = "User";
            // 
            // lblUserName
            // 
            this.lblUserName.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblUserName.ColorScheme = this.clrDefaultHelpWindow;
            this.lblUserName.FontScheme = this.fntTableTitle;
            this.lblUserName.Location = new System.Drawing.Point(93, 55);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Rtf = "UserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblUserName.Text = "UserName";
            // 
            // BrowseUsersView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 362);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblBrowseUsers);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "BrowseUsersView";
            this.Text = "Browse - Users";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
