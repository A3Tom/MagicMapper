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
    partial class DocsListDocumentationList
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblDocumentationList;
        Theme.Controls.Line lin;
        Theme.Controls.GroupBox grpChoose;
        Theme.Controls.Button btnBSpecifications;
        Theme.Controls.Button btnBRunRequests;
        Theme.Fonts.Unused1 fntUnused;
        Theme.Colors.DefaultFreeText clrDefaultFreeText;
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
            this.fntUnused = new MandCo.Theme.Fonts.Unused1();
            this.clrDefaultFreeText = new MandCo.Theme.Colors.DefaultFreeText();
            this.clrDefaultHyperlink = new MandCo.Theme.Colors.DefaultHyperlink();
            this.lblDocumentationList = new MandCo.Theme.Controls.Label();
            this.lin = new MandCo.Theme.Controls.Line();
            this.grpChoose = new MandCo.Theme.Controls.GroupBox();
            this.btnBSpecifications = new MandCo.Theme.Controls.Button();
            this.btnBRunRequests = new MandCo.Theme.Controls.Button();
            this.SuspendLayout();
            // 
            // lblDocumentationList
            // 
            this.lblDocumentationList.ColorScheme = this.clrDefaultFreeText;
            this.lblDocumentationList.FontScheme = this.fntUnused;
            this.lblDocumentationList.Location = new System.Drawing.Point(10, 13);
            this.lblDocumentationList.Name = "lblDocumentationList";
            this.lblDocumentationList.Rtf = "Documentation List";
            this.lblDocumentationList.Size = new System.Drawing.Size(170, 26);
            this.lblDocumentationList.Text = "Documentation List";
            // 
            // lin
            // 
            this.lin.BoundTo = new Firefly.Box.UI.ControlBinding(this.lblDocumentationList);
            this.lin.ColorScheme = this.clrDefaultFreeText;
            this.lin.End = new System.Drawing.Point(395, 46);
            this.lin.Name = "lin";
            this.lin.Start = new System.Drawing.Point(5, 46);
            this.lin.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // grpChoose
            // 
            this.grpChoose.ColorScheme = this.clrDefaultHyperlink;
            this.grpChoose.Location = new System.Drawing.Point(45, 169);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Size = new System.Drawing.Size(265, 91);
            this.grpChoose.Style = Firefly.Box.UI.ControlStyle.Sunken;
            this.grpChoose.Text = "Choose";
            // 
            // btnBSpecifications
            // 
            this.btnBSpecifications.Format = "&Specifications";
            this.btnBSpecifications.ImageLocation = "Button";
            this.btnBSpecifications.Location = new System.Drawing.Point(75, 208);
            this.btnBSpecifications.Name = "btnBSpecifications";
            this.btnBSpecifications.RaiseChangeOnClick = true;
            this.btnBSpecifications.Size = new System.Drawing.Size(96, 23);
            this.btnBSpecifications.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnBSpecifications_Click);
            this.btnBSpecifications.Data = this._controller.bSpecifications;
            // 
            // btnBRunRequests
            // 
            this.btnBRunRequests.Format = "&Run Requests";
            this.btnBRunRequests.ImageLocation = "Button";
            this.btnBRunRequests.Location = new System.Drawing.Point(185, 208);
            this.btnBRunRequests.Name = "btnBRunRequests";
            this.btnBRunRequests.RaiseChangeOnClick = true;
            this.btnBRunRequests.Size = new System.Drawing.Size(96, 23);
            this.btnBRunRequests.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnBRunRequests_Click);
            this.btnBRunRequests.Data = this._controller.bRunRequests;
            // 
            // DocsListDocumentationList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.btnBRunRequests);
            this.Controls.Add(this.btnBSpecifications);
            this.Controls.Add(this.grpChoose);
            this.Controls.Add(this.lin);
            this.Controls.Add(this.lblDocumentationList);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "DocsListDocumentationList";
            this.Text = "Documentation List";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
