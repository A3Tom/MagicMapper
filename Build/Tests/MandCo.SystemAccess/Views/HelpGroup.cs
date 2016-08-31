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
using System.Drawing;
namespace MandCo.SystemAccess.Views
{
    
    /// <summary>Group</summary>
    [System.ComponentModel.TypeDescriptionProvider(typeof(Firefly.Box.UI.Advanced.ValueInheritanceTypeDescriptionProvider))]
    class HelpGroup : ENV.UI.CustomHelp 
    {
        
        
        /// <summary>Group</summary>
        public HelpGroup()
        {
            Caption = "Group";
            ColorScheme = new MandCo.Theme.Colors.DefaultPrintFormColor();
            FontScheme = new MandCo.Theme.Fonts.HelpString();
            Location = new Point(20,0);
            Size = new Size(50,26);
            Text = 
@"Group Code for a Group of Users. The Group
 Code is related to a number of Applicatio
ns, and determines which Applications appe
ar on the User's initial screen.
";
        }
        
        
    }
}
