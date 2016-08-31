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
namespace MandCo.Theme.Colors
{
    
    /// <summary>Map of Colors used to resolve value by index</summary>
    public class Map
    {
        
        
        /// <summary>Map of Colors used to resolve value by index</summary>
        static Map()
        {
            _map.Add(1, new WindowSDefault());
            _map.Add(2, new ControlSDefault());
            _map.Add(3, new DefaultFreeText());
            _map.Add(4, new DefaultHelpWindow());
            _map.Add(5, new Default3DEffect());
            _map.Add(6, new DefaultPrintFormColor());
            _map.Add(7, new DefaultHyperlink());
            _map.Add(8, new Reserved());
            _map.Add(9, new Reserved1());
            _map.Add(10, new Reserved2());
            _map.Add(11, new Reserved3());
            _map.Add(12, new Reserved4());
            _map.Add(13, new Reserved5());
            _map.Add(14, new Reserved6());
            _map.Add(15, new Reserved7());
            _map.Add(16, new Reserved8());
            _map.Add(17, new Reserved9());
            _map.Add(18, new Window());
            _map.Add(19, new EditField());
            _map.Add(20, new No3DEffect());
            _map.Add(21, new DialogWindows());
            _map.Add(22, new DialogFields());
            _map.Add(23, new DialogTitles());
            _map.Add(24, new ListWindows());
            _map.Add(25, new ListFields());
            _map.Add(26, new ListTitles());
            _map.Add(27, new PopupWindows());
            _map.Add(28, new PopupWindowFields());
            _map.Add(29, new PopupWindowTitles());
            _map.Add(30, new DescriptionText());
            _map.Add(31, new GroupText());
            _map.Add(32, new TitleInFocus());
            _map.Add(33, new TitleOutOfFocus());
            _map.Add(34, new No3DEffect1());
            _map.Add(35, new ProgramTree());
            _map.Add(36, new UnparkedItems());
            _map.Add(37, new BreakPoint());
            _map.Add(38, new HotSpot());
            _map.Add(39, new HyperlinkPushbuttonText());
            _map.Add(40, new HyperlinkPushbuttonVisited());
            _map.Add(41, new HyperlinkPushBWalkthrough());
            _map.Add(42, new CommentedEntry());
            _map.Add(43, new ComponentObject());
            _map.Add(44, new InheritedProperty());
            _map.Add(45, new BrokenProperty());
            _map.Add(46, new AsDataProperty());
            _map.Add(47, new MarkingColumnControls());
            _map.Add(48, new ComponentBuilderWarning());
            _map.Add(49, new ApplicationWorkspace());
            _map.Add(50, new Windows3DTableTitle());
            _map.Add(51, new MenuBar());
            _map.Add(52, new Toolbar());
            _map.Add(53, new StatusBar());
            _map.Add(54, new Reserved10());
            _map.Add(55, new Reserved11());
            _map.Add(56, new Reserved12());
            _map.Add(57, new Reserved13());
            _map.Add(58, new Reserved14());
            _map.Add(59, new Reserved15());
            _map.Add(60, new RemarkOperation());
            _map.Add(61, new SelectOperation());
            _map.Add(62, new VerifyOperation());
            _map.Add(63, new LinkEndLinkOperation());
            _map.Add(64, new BlockEndBlockOperation());
            _map.Add(65, new CallOperation());
            _map.Add(66, new EvaluateOperation());
            _map.Add(67, new UpdateOperation());
            _map.Add(68, new InputOperation());
            _map.Add(69, new FlowOutput());
            _map.Add(70, new BrowseOperation());
            _map.Add(71, new ExitOSOperation());
            _map.Add(72, new RaiseEventOperation());
            _map.Add(73, new HandlerLevel());
            _map.Add(74, new Reserved16());
            _map.Add(75, new Reserved17());
            _map.Add(76, new Reserved18());
            _map.Add(77, new Reserved19());
            _map.Add(78, new Reserved20());
            _map.Add(79, new Reserved21());
            _map.Add(80, new Reserved22());
            _map.Add(81, new Reserved23());
            _map.Add(82, new Reserved24());
            _map.Add(83, new Reserved25());
            _map.Add(84, new Reserved26());
            _map.Add(85, new Reserved27());
            _map.Add(86, new Reserved28());
            _map.Add(87, new Reserved29());
            _map.Add(88, new Reserved30());
            _map.Add(89, new Reserved31());
            _map.Add(90, new Reserved32());
            _map.Add(91, new Reserved33());
            _map.Add(92, new Reserved34());
            _map.Add(93, new Reserved35());
            _map.Add(94, new Reserved36());
            _map.Add(95, new Reserved37());
            _map.Add(96, new Reserved38());
            _map.Add(97, new Reserved39());
            _map.Add(98, new Reserved40());
            _map.Add(99, new Reserved41());
            _map.Add(100, new Reserved42());
            _map.Add(101, new MackaysUserDefined());
            _map.Add(102, new MackaysUserDefined1());
            _map.Add(103, new AlternatingTableRow());
        }
        
        /// <summary>Used to find Colors by index</summary>
        public static ColorScheme Find(Number index)
        {
            if(index==null||!_map.ContainsKey(index))
            {
                return new ColorScheme(SystemColors.ControlText, SystemColors.Control);
            }
            return _map[index];
        }
        
        static System.Collections.Generic.Dictionary<Number,ColorScheme> _map = new System.Collections.Generic.Dictionary<Number,ColorScheme>();
        
    }
}
