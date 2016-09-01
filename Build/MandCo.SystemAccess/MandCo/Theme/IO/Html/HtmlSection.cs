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
namespace MandCo.Theme.IO.Html
{
    public class HtmlSection : ENV.IO.Html.HtmlSection 
    {
        
        
        /// <summary>HtmlSection</summary>
        public HtmlSection()
        {
            InitializeComponent();
        }
        void InitializeComponent()
        {
            ColorScheme = new MandCo.Theme.Colors.WindowSDefault();
            DefaultFontScheme = new MandCo.Theme.Fonts.HTMLDefault();
            H1FontScheme = new MandCo.Theme.Fonts.Header1();
            H1FontScheme = new MandCo.Theme.Fonts.Header2();
            H1FontScheme = new MandCo.Theme.Fonts.Header3();
            H1FontScheme = new MandCo.Theme.Fonts.Header4();
            H1FontScheme = new MandCo.Theme.Fonts.Header5();
            H1FontScheme = new MandCo.Theme.Fonts.Header6();
            BoldFontScheme = new MandCo.Theme.Fonts.HTMLDefaultBold();
            H1BoldFontScheme = new MandCo.Theme.Fonts.Header1Bold();
            H2BoldFontScheme = new MandCo.Theme.Fonts.Header2Bold();
            H3BoldFontScheme = new MandCo.Theme.Fonts.Header3Bold();
            H4BoldFontScheme = new MandCo.Theme.Fonts.Header4Bold();
            H5BoldFontScheme = new MandCo.Theme.Fonts.Header5Bold();
            H6BoldFontScheme = new MandCo.Theme.Fonts.Header6Bold();
            ItalicFontScheme = new MandCo.Theme.Fonts.HTMLDefaultItalic();
            H1ItalicFontScheme = new MandCo.Theme.Fonts.Header1Italic();
            H2ItalicFontScheme = new MandCo.Theme.Fonts.Header2Italic();
            H3ItalicFontScheme = new MandCo.Theme.Fonts.Header3Italic();
            H4ItalicFontScheme = new MandCo.Theme.Fonts.Header4Italic();
            H5ItalicFontScheme = new MandCo.Theme.Fonts.Header5Italic();
            H6ItalicFontScheme = new MandCo.Theme.Fonts.Header6Italic();
            BoldItalicFontScheme = new MandCo.Theme.Fonts.HTMLDefaultBoldItalic();
            H1BoldItalicFontScheme = new MandCo.Theme.Fonts.Header1BoldItalic();
            H2BoldItalicFontScheme = new MandCo.Theme.Fonts.Header2BoldItalic();
            H3BoldItalicFontScheme = new MandCo.Theme.Fonts.Header3BoldItalic();
            H4BoldItalicFontScheme = new MandCo.Theme.Fonts.Header4BoldItalic();
            H5BoldItalicFontScheme = new MandCo.Theme.Fonts.Header5BoldItalic();
            H6BoldItalicFontScheme = new MandCo.Theme.Fonts.Header6BoldItalic();
        }
        public HtmlSection(ENV.BusinessProcessBase controller):base(controller)
        {
            InitializeComponent();
        }
        public HtmlSection(ENV.AbstractUIController controller):base(controller)
        {
            InitializeComponent();
        }
        public HtmlSection(ENV.ApplicationControllerBase controller):base(controller)
        {
            InitializeComponent();
        }
        
        
    }
}
