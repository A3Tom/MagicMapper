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
    partial class BrowseUserGroupsView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblBrowseUserGroups;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblUser;
        Theme.Controls.Label lblGroup;
        Theme.Controls.TextBox txtUserGroupsUserID;
        Theme.Controls.TextBox txtUserGroupsGroupID;
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
            this.txtUserGroupsUserID = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtUserGroupsGroupID = new MandCo.Theme.Controls.TextBox();
            this.lblBrowseUserGroups = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.lblUser = new MandCo.Theme.Controls.Label();
            this.lblGroup = new MandCo.Theme.Controls.Label();
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
            this.grd.Size = new System.Drawing.Size(264, 301);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUserGroupsUserID);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 84;
            // 
            // txtUserGroupsUserID
            // 
            this.txtUserGroupsUserID.ColorScheme = this.clrDefault3DEffect;
            this.txtUserGroupsUserID.Format = "U8";
            this.txtUserGroupsUserID.Location = new System.Drawing.Point(3, 1);
            this.txtUserGroupsUserID.Name = "txtUserGroupsUserID";
            this.txtUserGroupsUserID.Size = new System.Drawing.Size(73, 16);
            this.txtUserGroupsUserID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserGroupsUserID.TabIndex = 1;
            this.txtUserGroupsUserID.Data = this._controller.UserGroups.UserID;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtUserGroupsGroupID);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 165;
            // 
            // txtUserGroupsGroupID
            // 
            this.txtUserGroupsGroupID.ColorScheme = this.clrDefault3DEffect;
            this.txtUserGroupsGroupID.Format = "UX19";
            this.txtUserGroupsGroupID.Location = new System.Drawing.Point(2, 1);
            this.txtUserGroupsGroupID.Name = "txtUserGroupsGroupID";
            this.txtUserGroupsGroupID.Size = new System.Drawing.Size(150, 16);
            this.txtUserGroupsGroupID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserGroupsGroupID.TabIndex = 2;
            this.txtUserGroupsGroupID.Data = this._controller.UserGroups.GroupID;
            // 
            // lblBrowseUserGroups
            // 
            this.lblBrowseUserGroups.ColorScheme = this.clrDefaultFreeText;
            this.lblBrowseUserGroups.FontScheme = this.fntUnused;
            this.lblBrowseUserGroups.Location = new System.Drawing.Point(10, 7);
            this.lblBrowseUserGroups.Name = "lblBrowseUserGroups";
            this.lblBrowseUserGroups.Rtf = "Browse - UserGroups";
            this.lblBrowseUserGroups.Size = new System.Drawing.Size(191, 26);
            this.lblBrowseUserGroups.Text = "Browse - UserGroups";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.FontScheme = this.fntUnused;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(260, 7);
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
            // lblGroup
            // 
            this.lblGroup.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblGroup.ColorScheme = this.clrDefaultHelpWindow;
            this.lblGroup.FontScheme = this.fntTableTitle;
            this.lblGroup.Location = new System.Drawing.Point(93, 55);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Rtf = "Group";
            this.lblGroup.Size = new System.Drawing.Size(33, 13);
            this.lblGroup.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroup.Text = "Group";
            // 
            // BrowseUserGroupsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 364);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblBrowseUserGroups);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "BrowseUserGroupsView";
            this.Text = "Browse - UserGroups";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
