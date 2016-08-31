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
using Firefly.Box.UI;
using Firefly.Box;
namespace MandCo.Theme.Fonts
{
    
    /// <summary>Map of Fonts used to resolve value by index</summary>
    public class Map
    {
        
        
        /// <summary>Map of Fonts used to resolve value by index</summary>
        static Map()
        {
            _map.Add(1, new TableField());
            _map.Add(2, new TableTitle());
            _map.Add(3, new TaskEditorText());
            _map.Add(4, new Unused());
            _map.Add(5, new Unused1());
            _map.Add(6, new HelpString());
            _map.Add(7, new Unused2());
            _map.Add(8, new Unused3());
            _map.Add(9, new PushButton());
            _map.Add(10, new RadioButton());
            _map.Add(11, new Reserved());
            _map.Add(12, new Reserved1());
            _map.Add(13, new Reserved2());
            _map.Add(14, new Reserved3());
            _map.Add(15, new Reserved4());
            _map.Add(16, new Reserved5());
            _map.Add(17, new Reserved6());
            _map.Add(18, new Reserved7());
            _map.Add(19, new Reserved8());
            _map.Add(20, new Reserved9());
            _map.Add(21, new TabText());
            _map.Add(22, new Tooltips());
            _map.Add(23, new TableFields());
            _map.Add(24, new TableTitle1());
            _map.Add(25, new DialogFields());
            _map.Add(26, new DialogText());
            _map.Add(27, new PushButtonText());
            _map.Add(28, new StatusLineText());
            _map.Add(29, new ConfirmMessagesFont());
            _map.Add(30, new ToolkitWindowsFont());
            _map.Add(31, new SmallFont());
            _map.Add(32, new LargeFont());
            _map.Add(33, new FixedSizeFont());
            _map.Add(34, new InheritedProperty());
            _map.Add(35, new BrokenProperty());
            _map.Add(36, new AsDataProperty());
            _map.Add(37, new VariablePalette());
            _map.Add(38, new Reserved10());
            _map.Add(39, new Reserved11());
            _map.Add(40, new Reserved12());
            _map.Add(41, new Reserved13());
            _map.Add(42, new Reserved14());
            _map.Add(43, new Reserved15());
            _map.Add(44, new Reserved16());
            _map.Add(45, new Reserved17());
            _map.Add(46, new Reserved18());
            _map.Add(47, new Reserved19());
            _map.Add(48, new Reserved20());
            _map.Add(49, new Reserved21());
            _map.Add(50, new HTMLDefault());
            _map.Add(51, new Header1());
            _map.Add(52, new Header2());
            _map.Add(53, new Header3());
            _map.Add(54, new Header4());
            _map.Add(55, new Header5());
            _map.Add(56, new Header6());
            _map.Add(57, new HTMLDefaultBold());
            _map.Add(58, new Header1Bold());
            _map.Add(59, new Header2Bold());
            _map.Add(60, new Header3Bold());
            _map.Add(61, new Header4Bold());
            _map.Add(62, new Header5Bold());
            _map.Add(63, new Header6Bold());
            _map.Add(64, new HTMLDefaultItalic());
            _map.Add(65, new Header1Italic());
            _map.Add(66, new Header2Italic());
            _map.Add(67, new Header3Italic());
            _map.Add(68, new Header4Italic());
            _map.Add(69, new Header5Italic());
            _map.Add(70, new Header6Italic());
            _map.Add(71, new HTMLDefaultBoldItalic());
            _map.Add(72, new Header1BoldItalic());
            _map.Add(73, new Header2BoldItalic());
            _map.Add(74, new Header3BoldItalic());
            _map.Add(75, new Header4BoldItalic());
            _map.Add(76, new Header5BoldItalic());
            _map.Add(77, new Header6BoldItalic());
            _map.Add(78, new Reserved22());
            _map.Add(79, new Reserved23());
            _map.Add(80, new Reserved24());
            _map.Add(81, new WizardLargeTitle());
            _map.Add(82, new WizardSmallTitle());
            _map.Add(83, new WizardText());
            _map.Add(84, new Reserved25());
            _map.Add(85, new Reserved26());
            _map.Add(86, new Reserved27());
            _map.Add(87, new Reserved28());
            _map.Add(88, new Reserved29());
            _map.Add(89, new Reserved30());
            _map.Add(90, new Reserved31());
            _map.Add(91, new Reserved32());
            _map.Add(92, new Reserved33());
            _map.Add(93, new Reserved34());
            _map.Add(94, new Reserved35());
            _map.Add(95, new Reserved36());
            _map.Add(96, new Reserved37());
            _map.Add(97, new Reserved38());
            _map.Add(98, new Reserved39());
            _map.Add(99, new Reserved40());
            _map.Add(100, new Reserved41());
            _map.Add(101, new MackaysUserDefined());
            _map.Add(102, new MackaysUserDefined1());
            _map.Add(103, new MackaysUserDefined2());
            _map.Add(104, new MackaysUserDefined3());
            _map.Add(105, new MackaysUserDefined4());
            _map.Add(106, new MackaysUserDefined5());
            _map.Add(107, new MackaysUserDefined6());
            _map.Add(108, new MackaysUserDefined7());
            _map.Add(109, new MackaysUserDefined8());
            _map.Add(110, new MackaysUserDefined9());
            _map.Add(111, new MackaysUserDefined10());
            _map.Add(112, new MackaysUserDefined11());
            _map.Add(113, new MackaysUserDefined12());
            _map.Add(114, new MackaysUserDefined13());
            _map.Add(115, new MackaysUserDefined14());
            _map.Add(116, new MackaysUserDefined15());
            _map.Add(117, new MackaysUserDefined16());
            _map.Add(118, new MackaysUserDefined17());
            _map.Add(119, new MackaysUserDefined18());
            _map.Add(120, new MackaysUserDefined19());
            _map.Add(121, new MackaysUserDefined20());
            _map.Add(122, new MackaysUserDefined21());
            _map.Add(123, new MackaysUserDefined22());
            _map.Add(124, new MackaysUserDefined23());
            _map.Add(125, new MackaysUserDefined24());
            _map.Add(126, new MackaysUserDefined25());
            _map.Add(127, new MackaysUserDefined26());
            _map.Add(128, new MackaysUserDefined27());
            _map.Add(129, new MackaysUserDefined28());
            _map.Add(130, new MackaysUserDefined29());
            _map.Add(131, new MackaysUserDefined30());
            _map.Add(132, new MackaysUserDefined31());
            _map.Add(133, new MackaysUserDefined32());
            _map.Add(134, new MackaysUserDefined33());
            _map.Add(135, new MackaysUserDefined34());
            _map.Add(136, new MackaysUserDefined35());
            _map.Add(137, new MackaysUserDefined36());
            _map.Add(138, new MackaysUserDefined37());
            _map.Add(139, new MackaysUserDefined38());
            _map.Add(140, new MackaysUserDefined39());
            _map.Add(141, new DefaultImportVisualFont());
            _map.Add(142, new FontRotation90Deg());
            _map.Add(143, new FontRotation135Deg());
            _map.Add(144, new FontRotation180Deg());
            _map.Add(145, new FontRotation225Deg());
            _map.Add(146, new FontRotation270Deg());
            _map.Add(147, new DefaultImportMonosizeFont());
            _map.Add(148, new DefaultImportVisualFontB());
            _map.Add(149, new FontRotation90DegB());
            _map.Add(150, new FontRotation135DegB());
            _map.Add(151, new FontRotation180DegB());
            _map.Add(152, new FontRotation225DegB());
            _map.Add(153, new FontRotation270DegB());
            _map.Add(154, new DefaultImportMonosizeFontB());
            _map.Add(155, new BarCode39());
            _map.Add(156, new Arial7());
            _map.Add(157, new Arial7Bold());
            _map.Add(158, new BarCode391());
            _map.Add(159, new BarCode3990Deg());
            _map.Add(160, new BarCode392());
            _map.Add(161, new BarCode3990Deg1());
            _map.Add(162, new BarCode39Extended());
        }
        
        /// <summary>Used to find Fonts by index</summary>
        public static FontScheme Find(Number index)
        {
            if(index==null||!_map.ContainsKey(index))
            {
                return null;
            }
            return _map[index];
        }
        
        static System.Collections.Generic.Dictionary<Number,FontScheme> _map = new System.Collections.Generic.Dictionary<Number,FontScheme>();
        
    }
}
