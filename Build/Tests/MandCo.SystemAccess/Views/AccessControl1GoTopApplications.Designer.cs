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
    partial class AccessControl1GoTopApplications
    {
        System.ComponentModel.IContainer components;
        Theme.Controls.Label lblVUpCounter;
        Controls.Group_txt txtVUpCounter;
        Theme.Controls.TextBox txtExp_1;
        Theme.Controls.TextBox txtExp_2;
        Theme.Controls.TextBox txtExp_3;
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
            this.lblVUpCounter = new MandCo.Theme.Controls.Label();
            this.txtVUpCounter = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.txtExp_1 = new MandCo.Theme.Controls.TextBox();
            this.txtExp_2 = new MandCo.Theme.Controls.TextBox();
            this.txtExp_3 = new MandCo.Theme.Controls.TextBox();
            this.SuspendLayout();
            // 
            // lblVUpCounter
            // 
            this.lblVUpCounter.FontScheme = this.fntTableField;
            this.lblVUpCounter.Location = new System.Drawing.Point(20, 13);
            this.lblVUpCounter.Name = "lblVUpCounter";
            this.lblVUpCounter.Rtf = "v:UpCounter";
            this.lblVUpCounter.Size = new System.Drawing.Size(60, 13);
            this.lblVUpCounter.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblVUpCounter.Text = "v:UpCounter";
            // 
            // txtVUpCounter
            // 
            this.txtVUpCounter.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtVUpCounter.Location = new System.Drawing.Point(85, 13);
            this.txtVUpCounter.Name = "txtVUpCounter";
            this.txtVUpCounter.Size = new System.Drawing.Size(20, 15);
            this.txtVUpCounter.Tag = "v:UpCounter";
            this.txtVUpCounter.Data = this._controller.vUpCounter;
            // 
            // txtExp_1
            // 
            this.txtExp_1.Format = "5";
            this.txtExp_1.Location = new System.Drawing.Point(20, 39);
            this.txtExp_1.Name = "txtExp_1";
            this.txtExp_1.Size = new System.Drawing.Size(33, 16);
            this.txtExp_1.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_1);
            // 
            // txtExp_2
            // 
            this.txtExp_2.Format = "5";
            this.txtExp_2.Location = new System.Drawing.Point(95, 39);
            this.txtExp_2.Name = "txtExp_2";
            this.txtExp_2.Size = new System.Drawing.Size(33, 16);
            this.txtExp_2.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_2);
            // 
            // txtExp_3
            // 
            this.txtExp_3.Format = "4";
            this.txtExp_3.Location = new System.Drawing.Point(190, 39);
            this.txtExp_3.Name = "txtExp_3";
            this.txtExp_3.Size = new System.Drawing.Size(33, 16);
            this.txtExp_3.Data = Firefly.Box.UI.Advanced.ControlData.FromNumber(_controller.Exp_3);
            // 
            // AccessControl1GoTopApplications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 75);
            this.Controls.Add(this.txtExp_3);
            this.Controls.Add(this.txtExp_2);
            this.Controls.Add(this.txtExp_1);
            this.Controls.Add(this.txtVUpCounter);
            this.Controls.Add(this.lblVUpCounter);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(651, 595);
            this.Name = "AccessControl1GoTopApplications";
            this.Text = "GoTopApplications";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
