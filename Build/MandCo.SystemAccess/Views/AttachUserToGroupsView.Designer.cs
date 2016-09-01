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
    partial class AttachUserToGroupsView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblAttachUserToGroups;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.Label lblUser;
        Theme.Controls.TextBox txtUsersUserID;
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
            this.lblAttachUserToGroups = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.lblUser = new MandCo.Theme.Controls.Label();
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 52);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(110, 301);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUsersUserID);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 95;
            // 
            // txtUsersUserID
            // 
            this.txtUsersUserID.ColorScheme = this.clrDefault3DEffect;
            this.txtUsersUserID.Format = "U8";
            this.txtUsersUserID.Location = new System.Drawing.Point(3, 1);
            this.txtUsersUserID.Name = "txtUsersUserID";
            this.txtUsersUserID.Size = new System.Drawing.Size(79, 16);
            this.txtUsersUserID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUsersUserID.Data = this._controller.Users.UserID;
            // 
            // lblAttachUserToGroups
            // 
            this.lblAttachUserToGroups.ColorScheme = this.clrDefaultFreeText;
            this.lblAttachUserToGroups.FontScheme = this.fntUnused;
            this.lblAttachUserToGroups.Location = new System.Drawing.Point(10, 7);
            this.lblAttachUserToGroups.Name = "lblAttachUserToGroups";
            this.lblAttachUserToGroups.Rtf = "Attach User to Groups";
            this.lblAttachUserToGroups.Size = new System.Drawing.Size(194, 26);
            this.lblAttachUserToGroups.Text = "Attach User to Groups";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.FontScheme = this.fntUnused;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(525, 7);
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
            // AttachUserToGroupsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 364);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblAttachUserToGroups);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "AttachUserToGroupsView";
            this.Text = "Attach User to Groups";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
