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
    partial class AccessControl1CreateAccessList
    {
        System.ComponentModel.IContainer components;
        Theme.Controls.Label lblGroupID;
        Theme.Controls.TextBox txtGroupApplicationsGroupID;
        Theme.Controls.Label lblApplication;
        Theme.Controls.TextBox txtGroupApplicationsApplication1;
        Theme.Controls.Label lblApplication1;
        Controls.Group_txt txtUserAccessListApplication1;
        Theme.Fonts.TableField fntTableField;
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
            this.fntTableField = new MandCo.Theme.Fonts.TableField();
            this.lblGroupID = new MandCo.Theme.Controls.Label();
            this.txtGroupApplicationsGroupID = new MandCo.Theme.Controls.TextBox();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            this.txtGroupApplicationsApplication1 = new MandCo.Theme.Controls.TextBox();
            this.lblApplication1 = new MandCo.Theme.Controls.Label();
            this.txtUserAccessListApplication1 = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.SuspendLayout();
            // 
            // lblGroupID
            // 
            this.lblGroupID.FontScheme = this.fntTableField;
            this.lblGroupID.Location = new System.Drawing.Point(30, 26);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Rtf = "GroupID";
            this.lblGroupID.Size = new System.Drawing.Size(40, 13);
            this.lblGroupID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroupID.Text = "GroupID";
            // 
            // txtGroupApplicationsGroupID
            // 
            this.txtGroupApplicationsGroupID.Location = new System.Drawing.Point(75, 26);
            this.txtGroupApplicationsGroupID.Name = "txtGroupApplicationsGroupID";
            this.txtGroupApplicationsGroupID.Size = new System.Drawing.Size(144, 16);
            this.txtGroupApplicationsGroupID.Tag = "GroupID";
            this.txtGroupApplicationsGroupID.Data = this._controller.GroupApplications.GroupID;
            // 
            // lblApplication
            // 
            this.lblApplication.FontScheme = this.fntTableField;
            this.lblApplication.Location = new System.Drawing.Point(30, 52);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(53, 13);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // txtGroupApplicationsApplication1
            // 
            this.txtGroupApplicationsApplication1.Location = new System.Drawing.Point(88, 52);
            this.txtGroupApplicationsApplication1.Name = "txtGroupApplicationsApplication1";
            this.txtGroupApplicationsApplication1.Size = new System.Drawing.Size(213, 16);
            this.txtGroupApplicationsApplication1.Tag = "Application";
            this.txtGroupApplicationsApplication1.Data = this._controller.GroupApplications.Application1;
            // 
            // lblApplication1
            // 
            this.lblApplication1.FontScheme = this.fntTableField;
            this.lblApplication1.Location = new System.Drawing.Point(30, 91);
            this.lblApplication1.Name = "lblApplication1";
            this.lblApplication1.Rtf = "Application";
            this.lblApplication1.Size = new System.Drawing.Size(53, 13);
            this.lblApplication1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication1.Text = "Application";
            // 
            // txtUserAccessListApplication1
            // 
            this.txtUserAccessListApplication1.Location = new System.Drawing.Point(88, 91);
            this.txtUserAccessListApplication1.Name = "txtUserAccessListApplication1";
            this.txtUserAccessListApplication1.Size = new System.Drawing.Size(212, 15);
            this.txtUserAccessListApplication1.Tag = "Application_0001";
            this.txtUserAccessListApplication1.Data = this._controller.UserAccessList.Application1;
            // 
            // AccessControl1CreateAccessList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 140);
            this.Controls.Add(this.txtUserAccessListApplication1);
            this.Controls.Add(this.lblApplication1);
            this.Controls.Add(this.txtGroupApplicationsApplication1);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.txtGroupApplicationsGroupID);
            this.Controls.Add(this.lblGroupID);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(783, 0);
            this.Name = "AccessControl1CreateAccessList";
            this.Text = "Create Access List";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
