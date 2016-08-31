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
    partial class AttachUserToGroupsGroups
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.GroupBox grpGroups;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblGroup;
        Theme.Controls.Label lblGroupDescription;
        Theme.Controls.TextBox txtUserGroupsGroupID;
        Theme.Controls.TextBox txtGroups11GroupDescription;
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
            this.clrDefaultHelpWindow = new MandCo.Theme.Colors.DefaultHelpWindow();
            this.clrDefaultHyperlink = new MandCo.Theme.Colors.DefaultHyperlink();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtUserGroupsGroupID = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtGroups11GroupDescription = new MandCo.Theme.Controls.TextBox();
            this.grpGroups = new MandCo.Theme.Controls.GroupBox();
            this.lblGroup = new MandCo.Theme.Controls.Label();
            this.lblGroupDescription = new MandCo.Theme.Controls.Label();
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
            this.grd.Location = new System.Drawing.Point(10, 26);
            this.grd.Name = "grd";
            this.grd.RowHeight = 20;
            this.grd.Size = new System.Drawing.Size(350, 249);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUserGroupsGroupID);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 102;
            // 
            // txtUserGroupsGroupID
            // 
            this.txtUserGroupsGroupID.Location = new System.Drawing.Point(2, 1);
            this.txtUserGroupsGroupID.Name = "txtUserGroupsGroupID";
            this.txtUserGroupsGroupID.Size = new System.Drawing.Size(95, 13);
            this.txtUserGroupsGroupID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserGroupsGroupID.TabIndex = 1;
            this.txtUserGroupsGroupID.Expand += new System.Action(txtUserGroupsGroupID_Expand);
            this.txtUserGroupsGroupID.Data = this._controller.UserGroups.GroupID;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtGroups11GroupDescription);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 233;
            // 
            // txtGroups11GroupDescription
            // 
            this.txtGroups11GroupDescription.AllowFocus = false;
            this.txtGroups11GroupDescription.Location = new System.Drawing.Point(2, 1);
            this.txtGroups11GroupDescription.Name = "txtGroups11GroupDescription";
            this.txtGroups11GroupDescription.Size = new System.Drawing.Size(220, 13);
            this.txtGroups11GroupDescription.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtGroups11GroupDescription.TabIndex = 2;
            this.txtGroups11GroupDescription.Data = this._controller.Groups11.GroupDescription;
            // 
            // grpGroups
            // 
            this.grpGroups.ColorScheme = this.clrDefaultHyperlink;
            this.grpGroups.Location = new System.Drawing.Point(5, 0);
            this.grpGroups.Name = "grpGroups";
            this.grpGroups.Size = new System.Drawing.Size(365, 286);
            this.grpGroups.Text = "Groups";
            // 
            // lblGroup
            // 
            this.lblGroup.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblGroup.ColorScheme = this.clrDefaultHelpWindow;
            this.lblGroup.Location = new System.Drawing.Point(14, 29);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Rtf = "Group";
            this.lblGroup.Size = new System.Drawing.Size(95, 13);
            this.lblGroup.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroup.Text = "Group";
            // 
            // lblGroupDescription
            // 
            this.lblGroupDescription.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblGroupDescription.ColorScheme = this.clrDefaultHelpWindow;
            this.lblGroupDescription.Location = new System.Drawing.Point(116, 29);
            this.lblGroupDescription.Name = "lblGroupDescription";
            this.lblGroupDescription.Rtf = "Group Description";
            this.lblGroupDescription.Size = new System.Drawing.Size(95, 13);
            this.lblGroupDescription.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroupDescription.Text = "Group Description";
            // 
            // AttachUserToGroupsGroups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = Firefly.Box.UI.ControlBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(386, 312);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblGroupDescription);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.grpGroups);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(138, 75);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachUserToGroupsGroups";
            this.SystemMenu = false;
            this.Text = "Groups";
            this.TitleBar = false;
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
