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
    partial class AccessControl1KillActiveUsers
    {
        System.ComponentModel.IContainer components;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.Label lblListRecord;
        Theme.Controls.TextBox txtVListRecord;
        Theme.Colors.Default3DEffect clrDefault3DEffect;
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
            this.clrDefault3DEffect = new MandCo.Theme.Colors.Default3DEffect();
            this.fntTableTitle = new MandCo.Theme.Fonts.TableTitle();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtVListRecord = new MandCo.Theme.Controls.TextBox();
            this.lblListRecord = new MandCo.Theme.Controls.Label();
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
            this.grd.Location = new System.Drawing.Point(5, 13);
            this.grd.Name = "grd";
            this.grd.RowHeight = 20;
            this.grd.Size = new System.Drawing.Size(381, 296);
            this.grd.Style = Firefly.Box.UI.ControlStyle.Raised;
            this.grd.UseVisualStyles = true;
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtVListRecord);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 366;
            // 
            // txtVListRecord
            // 
            this.txtVListRecord.Location = new System.Drawing.Point(3, 1);
            this.txtVListRecord.Name = "txtVListRecord";
            this.txtVListRecord.Size = new System.Drawing.Size(355, 13);
            this.txtVListRecord.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtVListRecord.Data = this._controller.vListRecord;
            // 
            // lblListRecord
            // 
            this.lblListRecord.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblListRecord.FontScheme = this.fntTableTitle;
            this.lblListRecord.Location = new System.Drawing.Point(10, 16);
            this.lblListRecord.Name = "lblListRecord";
            this.lblListRecord.Rtf = "ListRecord";
            this.lblListRecord.Size = new System.Drawing.Size(56, 13);
            this.lblListRecord.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblListRecord.Text = "ListRecord";
            // 
            // AccessControl1KillActiveUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.Controls.Add(this.lblListRecord);
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(655, 0);
            this.Name = "AccessControl1KillActiveUsers";
            this.Text = "KillActiveUsers";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
