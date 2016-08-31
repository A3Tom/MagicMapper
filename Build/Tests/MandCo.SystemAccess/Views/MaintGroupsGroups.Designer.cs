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
    partial class MaintGroupsGroups
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblMaintenanceGroup;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblGroup;
        Theme.Controls.Label lblGroupDescription;
        Theme.Controls.TextBox txtGroups1GroupID;
        Theme.Controls.TextBox txtGroups1GroupDescription;
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
            this.txtGroups1GroupID = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtGroups1GroupDescription = new MandCo.Theme.Controls.TextBox();
            this.lblMaintenanceGroup = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
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
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 52);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(411, 301);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtGroups1GroupID);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 161;
            // 
            // txtGroups1GroupID
            // 
            this.txtGroups1GroupID.ColorScheme = this.clrDefault3DEffect;
            this.txtGroups1GroupID.Format = "UX19";
            this.txtGroups1GroupID.Location = new System.Drawing.Point(3, 1);
            this.txtGroups1GroupID.Name = "txtGroups1GroupID";
            this.txtGroups1GroupID.ReadOnly = true;
            this.txtGroups1GroupID.Size = new System.Drawing.Size(150, 16);
            this.txtGroups1GroupID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtGroups1GroupID.TabIndex = 1;
            this.txtGroups1GroupID.BindReadOnly += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.txtGroups1GroupID_BindReadOnly);
            this.txtGroups1GroupID.Data = this._controller.Groups1.GroupID;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtGroups1GroupDescription);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 235;
            // 
            // txtGroups1GroupDescription
            // 
            this.txtGroups1GroupDescription.ColorScheme = this.clrDefault3DEffect;
            this.txtGroups1GroupDescription.Format = "UX29";
            this.txtGroups1GroupDescription.Location = new System.Drawing.Point(2, 1);
            this.txtGroups1GroupDescription.Name = "txtGroups1GroupDescription";
            this.txtGroups1GroupDescription.Size = new System.Drawing.Size(220, 16);
            this.txtGroups1GroupDescription.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtGroups1GroupDescription.TabIndex = 2;
            this.txtGroups1GroupDescription.Data = this._controller.Groups1.GroupDescription;
            // 
            // lblMaintenanceGroup
            // 
            this.lblMaintenanceGroup.ColorScheme = this.clrDefaultFreeText;
            this.lblMaintenanceGroup.FontScheme = this.fntUnused;
            this.lblMaintenanceGroup.Location = new System.Drawing.Point(10, 7);
            this.lblMaintenanceGroup.Name = "lblMaintenanceGroup";
            this.lblMaintenanceGroup.Rtf = "Maintenance - Group";
            this.lblMaintenanceGroup.Size = new System.Drawing.Size(405, 26);
            this.lblMaintenanceGroup.Text = "Maintenance - Group";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.FontScheme = this.fntUnused;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(410, 7);
            this.shp.Square = true;
            this.shp.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblGroup
            // 
            this.lblGroup.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblGroup.ColorScheme = this.clrDefaultHelpWindow;
            this.lblGroup.FontScheme = this.fntTableTitle;
            this.lblGroup.Location = new System.Drawing.Point(10, 55);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Rtf = "Group";
            this.lblGroup.Size = new System.Drawing.Size(34, 13);
            this.lblGroup.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroup.Text = "Group";
            // 
            // lblGroupDescription
            // 
            this.lblGroupDescription.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblGroupDescription.ColorScheme = this.clrDefaultHelpWindow;
            this.lblGroupDescription.FontScheme = this.fntTableTitle;
            this.lblGroupDescription.Location = new System.Drawing.Point(170, 55);
            this.lblGroupDescription.Name = "lblGroupDescription";
            this.lblGroupDescription.Rtf = "Group Description";
            this.lblGroupDescription.Size = new System.Drawing.Size(90, 13);
            this.lblGroupDescription.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroupDescription.Text = "Group Description";
            // 
            // MaintGroupsGroups
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 359);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblGroupDescription);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblMaintenanceGroup);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "MaintGroupsGroups";
            this.Text = "Groups";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
