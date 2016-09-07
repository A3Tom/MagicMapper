using Firefly.Box;
using ENV.Data;
using ENV;
using Firefly.Box.Flow;
using Firefly.Box.Data.DataProvider;
using Firefly.Box.Advanced;
using Firefly.Box.Data.Advanced;
namespace MandCo.Mos.ExtraMOSPrograms
{
    
    /// <summary>Maint - Mod Col&Size(po2071)(P#487)</summary>
    // Last change before Migration: 21/05/2013 09:44:12
    public class MaintModColSizePo2071Core : MaintModColSizePo2071 
    {
        
        #region Parameters
        
        /// <summary>P:Product Number</summary>
        internal readonly Types.ProductNumber PProductNumber = new Types.ProductNumber
        {
        	Caption = "P:Product Number",
        	IsParameter = true
        };
        
        /// <summary>P:Style Code</summary>
        internal readonly Types.StyleCode PStyleCode = new Types.StyleCode
        {
        	Caption = "P:Style Code",
        	IsParameter = true
        };
        
        /// <summary>P:Order Number</summary>
        readonly Types.OrderNumber POrderNumber = new Types.OrderNumber
        {
        	Caption = "P:Order Number",
        	IsParameter = true
        };
        
        /// <summary>P:Colour or Size</summary>
        readonly TextColumn PColourOrSize = new TextColumn("P:Colour or Size", "1")
        {
        	IsParameter = true
        };
        
        /// <summary>P:Max Allowed</summary>
        readonly NumberColumn PMaxAllowed = new NumberColumn("P:Max Allowed", "2")
        {
        	IsParameter = true
        };
        
        /// <summary>P:Colour or Size Changed</summary>
        readonly BoolColumn PColourOrSizeChanged = new BoolColumn("P:Colour or Size Changed")
        {
        	IsParameter = true
        };
        #endregion
        
        #region Columns
        
        /// <summary>v:season</summary>
        internal readonly TextColumn vSeason = new TextColumn("v:season", "3");
        
        /// <summary>v:brand</summary>
        internal readonly TextColumn vBrand = new TextColumn("v:brand", "30");
        
        /// <summary>v:dept desc</summary>
        internal readonly TextColumn vDeptDesc = new TextColumn("v:dept desc", "UX29A");
        
        /// <summary>v:sub dept desc</summary>
        internal readonly TextColumn vSubDeptDesc = new TextColumn("v:sub dept desc", "UX29A");
        
        /// <summary>v:section desc</summary>
        internal readonly TextColumn vSectionDesc = new TextColumn("v:section desc", "UX29A");
        
        /// <summary>v:range desc</summary>
        internal readonly TextColumn vRangeDesc = new TextColumn("v:range desc", "UX29A");
        
        /// <summary>v:sub range desc</summary>
        internal readonly TextColumn vSubRangeDesc = new TextColumn("v:sub range desc", "UX29A");
        
        /// <summary>v:Prod description</summary>
        internal readonly TextColumn vProdDescription = new TextColumn("v:Prod description", "UX24A");
        
        /// <summary>v:dss dept code</summary>
        readonly Types.DSSDepartmentCode vDssDeptCode = new Types.DSSDepartmentCode
        {
        	Caption = "v:dss dept code"
        };
        
        /// <summary>v:dss sub dept code</summary>
        readonly Types.DSSSubDepartmentCode vDssSubDeptCode = new Types.DSSSubDepartmentCode
        {
        	Caption = "v:dss sub dept code"
        };
        
        /// <summary>v:size range from lookup</summary>
        readonly Types.SizeRange vSizeRangeFromLookup = new Types.SizeRange
        {
        	Caption = "v:size range from lookup"
        };
        
        /// <summary>v:Keep Colour Changes</summary>
        readonly BoolColumn vKeepColourChanges = new BoolColumn("v:Keep Colour Changes");
        
        /// <summary>v:Keep Size Changes</summary>
        readonly BoolColumn vKeepSizeChanges = new BoolColumn("v:Keep Size Changes");
        
        /// <summary>v:Proper Exit</summary>
        readonly BoolColumn vProperExit = new BoolColumn("v:Proper Exit");
        
        /// <summary>v:disable save button</summary>
        readonly BoolColumn vDisableSaveButton = new BoolColumn("v:disable save button");
        #endregion
        
        
        /// <summary>Maint - Mod Col&Size(po2071)(P#487)</summary>
        public MaintModColSizePo2071Core()
        {
            Title = "Maint - Mod Col&Size(po2071)";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            #region Columns
            
            Columns.Add(PProductNumber);
            Columns.Add(PStyleCode);
            Columns.Add(POrderNumber);
            Columns.Add(PColourOrSize);
            Columns.Add(PMaxAllowed);
            Columns.Add(PColourOrSizeChanged);
            
            Columns.Add(vSeason);
            Columns.Add(vBrand);
            Columns.Add(vDeptDesc);
            Columns.Add(vSubDeptDesc);
            Columns.Add(vSectionDesc);
            Columns.Add(vRangeDesc);
            Columns.Add(vSubRangeDesc);
            Columns.Add(vProdDescription);
            
            
            Columns.Add(vDssDeptCode);
            Columns.Add(vDssSubDeptCode);
            Columns.Add(vSizeRangeFromLookup);
            
            Columns.Add(vKeepColourChanges);
            Columns.Add(vKeepSizeChanges);
            Columns.Add(vProperExit);
            
            Columns.Add(vDisableSaveButton);
            #endregion
        }
        
        /// <summary>Maint - Mod Col&Size(po2071)</summary>
        #region Parameters Original Names
        /// <param name="pPProductNumber">P:Product Number</param>
        /// <param name="pPStyleCode">P:Style Code</param>
        /// <param name="pPOrderNumber">P:Order Number</param>
        /// <param name="pPColourOrSize">P:Colour or Size</param>
        /// <param name="pPMaxAllowed">P:Max Allowed</param>
        /// <param name="pPColourOrSizeChanged">P:Colour or Size Changed</param>
        #endregion
        public override void Run(NumberParameter pPProductNumber, TextParameter pPStyleCode, NumberParameter pPOrderNumber, TextParameter pPColourOrSize, NumberParameter pPMaxAllowed, BoolParameter pPColourOrSizeChanged)
        {
            #region Bind Parameters
            
            BindParameter(PProductNumber, pPProductNumber);
            BindParameter(PStyleCode, pPStyleCode);
            BindParameter(POrderNumber, pPOrderNumber);
            BindParameter(PColourOrSize, pPColourOrSize);
            BindParameter(PMaxAllowed, pPMaxAllowed);
            BindParameter(PColourOrSizeChanged, pPColourOrSizeChanged);
            #endregion
            Execute();
        }
        protected override void OnLoad()
        {
            Exit(ExitTiming.AfterRow);
            TransactionScope = TransactionScopes.Row;
            AllowUserAbort = true;
        }
        protected override void OnLeaveRow()
        {
            if(PColourOrSize == "C")
            {
                Cached<ClearColourWorkfile>().Run();
                Cached<ReadProdColSizeForColour>().Run();
                Cached<GetHeaderDetails>().Run();
                new DisplayColourDetails(this).Run();
                if(vKeepColourChanges)
                {
                    new FindColourChanges(this).Run();
                }
            }
            
            if(PColourOrSize == "S")
            {
                Cached<StorePrices>().Run();
                Cached<ClearSizeWorkfile>().Run();
                Cached<ReadProdColSizeForSize>().Run();
                Cached<GetHeaderDetails>().Run();
                new DisplaySizeDetails(this).Run();
                if(vKeepSizeChanges)
                {
                    new FindSizeChanges(this).Run();
                }
            }
        }
        
        
        
        /// <summary>Display Colour Details(P#487.1)</summary>
        // Last change before Migration: 19/11/2012 16:14:04
        internal class DisplayColourDetails : Mos.UIControllerBase 
        {
            
            #region Models
            
            /// <summary>Modify Colour Workfile</summary>
            internal readonly Models.ModifyColourWorkfile ModifyColourWorkfile = new Models.ModifyColourWorkfile { AllowRowLocking = true };
            
            /// <summary>Colour</summary>
            internal readonly Models.Colour Colour = new Models.Colour { ReadOnly = true };
            
            /// <summary>Colour</summary>
            readonly Models.Colour Colour1 = new Models.Colour { ReadOnly = true };
            #endregion
            
            #region Columns
            
            /// <summary>v:char return</summary>
            readonly TextColumn vCharReturn = new TextColumn("v:char return", "4");
            #endregion
            
            #region CustomCommands
            
            /// <summary>Exit & Cancel</summary>
            internal readonly CustomCommand ExitCancel = new CustomCommand()
            {
            	Name = "Exit & Cancel"
            };
            
            /// <summary>Exit & Save</summary>
            internal readonly CustomCommand ExitSave = new CustomCommand()
            {
            	Name = "Exit & Save"
            };
            
            /// <summary>View Original Details</summary>
            readonly CustomCommand ViewOriginalDetails = new CustomCommand()
            {
            	Name = "View Original Details"
            };
            #endregion
            
            internal MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Display Colour Details(P#487.1)</summary>
            public DisplayColourDetails(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Display Colour Details";
                InitializeDataView();
                #region Event Handlers
                
                Handlers.AddDatabaseErrorHandler(DatabaseErrorType.AllErrors).Invokes += AllErrorsHandler;
                
                Handlers.Add(ExitCancel).Invokes += ExitCancelHandler;
                
                Handlers.Add(ExitSave).Invokes += ExitSaveHandler;
                
                MonitorValueChanged(ModifyColourWorkfile.ColourCode, ModifyColourWorkfileColourCode_ValueChanged);
                #endregion
            }
            void InitializeDataView()
            {
                From = ModifyColourWorkfile;
                Relations.Add(Colour, 
                		Colour.ColourCode.IsEqualTo(ModifyColourWorkfile.ColourCode), 
                	Colour.SortByREF_Colour_X1);
                
                Relations.Add(Colour1, 
                		Colour1.ColourCode.IsEqualTo(ModifyColourWorkfile.OriginalColour), 
                	Colour1.SortByREF_Colour_X1);
                
                OrderBy = ModifyColourWorkfile.SortByMOS_MOD_COL_SIZE_WRK_X1;
                
                #region Columns
                
                Columns.Add(ModifyColourWorkfile.ProductNumber);
                Columns.Add(ModifyColourWorkfile.ColourCode);
                Columns.Add(ModifyColourWorkfile.ColourChanged);
                Columns.Add(ModifyColourWorkfile.OriginalColour);
                
                // current colour
                Columns.Add(Colour.ColourCode);
                Columns.Add(Colour.ColourDescription);
                
                // original colour
                Columns.Add(Colour1.ColourCode);
                Columns.Add(Colour1.ColourDescription);
                
                Columns.Add(vCharReturn).BindValue(() => u.ASCIIChr(13));
                #endregion
            }
            
            /// <summary>Display Colour Details</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                RowLocking = LockingStrategy.OnUserEdit;
                TransactionScope = TransactionScopes.Row;
                SwitchToInsertWhenNoRows = true;
                AllowDelete = false;
                AllowInsert = false;
                View = ()=> new Views.MaintModColSizePo2071ModifyColours(this);
            }
            
            #region Handlers
            void AllErrorsHandler(DatabaseErrorEventArgs e)
            {
                Common.ShowDatabaseErrorMessage = true;
                Message.ShowWarning("Error Detected");
                e.Handled = true;
            }
            void ExitCancelHandler(HandlerInvokeEventArgs e)
            {
                _parent.vKeepColourChanges.Value = false;
                _parent.vProperExit.Value = true;
                _parent.PColourOrSizeChanged.Value = false;
                Raise(Command.Exit);
                e.Handled = true;
            }
            void ExitSaveHandler(HandlerInvokeEventArgs e)
            {
                _parent.vKeepColourChanges.Value = true;
                _parent.vProperExit.Value = true;
                _parent.PColourOrSizeChanged.Value = true;
                Raise(Command.Exit);
                e.Handled = true;
            }
            #endregion
            
            #region Column Change Handlers
            void ModifyColourWorkfileColourCode_ValueChanged(ValueChangedEventArgs<Number> e)
            {
                LockCurrentRowIfItWasChanged();
                ModifyColourWorkfile.ColourChanged.SilentSet(true);
                if(ModifyColourWorkfile.ColourCode != ModifyColourWorkfile.OriginalColour)
                {
                    Cached<ChangeAllColours>().Run();
                }
                if(ModifyColourWorkfile.ColourCode == ModifyColourWorkfile.OriginalColour)
                {
                    Cached<ChangeBackToOriginal>().Run();
                }
                Raise(Command.RefreshDisplayedData);
            }
            #endregion
            
            #region Expressions
            internal Bool Exp_11()
            {
                return u.Not(_parent.vDisableSaveButton);
            }
            #endregion
            
            
            
            /// <summary>Change All Colours(P#487.1.1)</summary>
            // Last change before Migration: 16/11/2012 16:25:43
            class ChangeAllColours : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Modify Colour Workfile</summary>
                readonly Models.ModifyColourWorkfile ModifyColourWorkfile = new Models.ModifyColourWorkfile { AllowRowLocking = true };
                #endregion
                
                DisplayColourDetails _parent;
                
                
                /// <summary>Change All Colours(P#487.1.1)</summary>
                public ChangeAllColours(DisplayColourDetails parent)
                {
                    _parent = parent;
                    Title = "Change All Colours";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ModifyColourWorkfile;
                    Where.Add(ModifyColourWorkfile.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ModifyColourWorkfile.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour));
                    OrderBy = ModifyColourWorkfile.SortByMOS_MOD_COL_SIZE_WRK_X1;
                    
                    #region Columns
                    
                    Columns.Add(ModifyColourWorkfile.ProductNumber);
                    Columns.Add(ModifyColourWorkfile.ColourCode);
                    Columns.Add(ModifyColourWorkfile.ColourChanged);
                    Columns.Add(ModifyColourWorkfile.OriginalColour);
                    #endregion
                }
                
                /// <summary>Change All Colours</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    ModifyColourWorkfile.ColourCode.Value = _parent.ModifyColourWorkfile.ColourCode;
                    ModifyColourWorkfile.ColourChanged.Value = true;
                }
                
                
            }
            
            /// <summary>Change back to original(P#487.1.2)</summary>
            // Last change before Migration: 16/11/2012 16:25:47
            class ChangeBackToOriginal : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Modify Colour Workfile</summary>
                readonly Models.ModifyColourWorkfile ModifyColourWorkfile = new Models.ModifyColourWorkfile { AllowRowLocking = true };
                #endregion
                
                DisplayColourDetails _parent;
                
                
                /// <summary>Change back to original(P#487.1.2)</summary>
                public ChangeBackToOriginal(DisplayColourDetails parent)
                {
                    _parent = parent;
                    Title = "Change back to original";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ModifyColourWorkfile;
                    Where.Add(ModifyColourWorkfile.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ModifyColourWorkfile.OriginalColour.IsEqualTo(_parent.ModifyColourWorkfile.ColourCode));
                    OrderBy = ModifyColourWorkfile.SortByMOS_MOD_COL_SIZE_WRK_X1;
                    
                    #region Columns
                    
                    Columns.Add(ModifyColourWorkfile.ProductNumber);
                    Columns.Add(ModifyColourWorkfile.ColourCode);
                    Columns.Add(ModifyColourWorkfile.ColourChanged);
                    Columns.Add(ModifyColourWorkfile.OriginalColour);
                    #endregion
                }
                
                /// <summary>Change back to original</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    ModifyColourWorkfile.ColourCode.Value = ModifyColourWorkfile.OriginalColour;
                    ModifyColourWorkfile.ColourChanged.Value = false;
                }
                
                
            }
        }
        
        /// <summary>Read ProdColSize for Colour(P#487.2)</summary>
        // Last change before Migration: 16/11/2012 16:26:01
        class ReadProdColSizeForColour : Mos.BusinessProcessBase 
        {
            
            #region Models
            DynamicSQLEntity sqlEntity;
            #endregion
            
            #region Columns
            
            /// <summary>PRODUCT_NUMBER</summary>
            readonly NumberColumn PRODUCT_NUMBER = new NumberColumn("PRODUCT_NUMBER", "N8")
            {
            	AllowNull = true
            };
            
            /// <summary>COLOUR_CODE</summary>
            readonly NumberColumn COLOUR_CODE = new NumberColumn("COLOUR_CODE", "N4")
            {
            	AllowNull = true
            };
            #endregion
            
            MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Read ProdColSize for Colour(P#487.2)</summary>
            public ReadProdColSizeForColour(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Read ProdColSize for Colour";
                InitializeDataView();
                var COLOUR_CODEGroup = Groups.Add(COLOUR_CODE);
                COLOUR_CODEGroup.Leave += COLOUR_CODEGroup_Leave;
            }
            void InitializeDataView()
            {
                sqlEntity = new DynamicSQLEntity(Models.DataSources.Ref1, 
@"select distinct t.product_number, t.colour_code
from ref_prdcolsz t
where t.product_number = :1");
                sqlEntity.AddParameter(_parent.PProductNumber); //:1;
                sqlEntity.Columns.Add(PRODUCT_NUMBER, COLOUR_CODE);
                From = sqlEntity;
                
                #region Columns
                
                Columns.Add(PRODUCT_NUMBER);
                Columns.Add(COLOUR_CODE);
                #endregion
            }
            
            /// <summary>Read ProdColSize for Colour</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                TransactionScope = TransactionScopes.Task;
                Activity = Activities.Browse;
                AllowDelete = false;
                AllowUserAbort = true;
            }
            void COLOUR_CODEGroup_Leave()
            {
                Cached<WriteToWorkfile>().Run();
            }
            
            
            
            /// <summary>Write to workfile(P#487.2.1)</summary>
            // Last change before Migration: 16/11/2012 16:26:00
            class WriteToWorkfile : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Modify Colour Workfile</summary>
                readonly Models.ModifyColourWorkfile ModifyColourWorkfile = new Models.ModifyColourWorkfile { AllowRowLocking = true };
                #endregion
                
                ReadProdColSizeForColour _parent;
                
                
                /// <summary>Write to workfile(P#487.2.1)</summary>
                public WriteToWorkfile(ReadProdColSizeForColour parent)
                {
                    _parent = parent;
                    Title = "Write to workfile";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(ModifyColourWorkfile, RelationType.Insert, 
                    	ModifyColourWorkfile.SortByMOS_MOD_COL_SIZE_WRK_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(ModifyColourWorkfile.ProductNumber).BindValue(_parent.PRODUCT_NUMBER);
                    Columns.Add(ModifyColourWorkfile.ColourCode).BindValue(_parent.COLOUR_CODE);
                    Columns.Add(ModifyColourWorkfile.ColourChanged).BindValue(() => false);
                    Columns.Add(ModifyColourWorkfile.OriginalColour).BindValue(_parent.COLOUR_CODE);
                    #endregion
                }
                
                /// <summary>Write to workfile</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                
                
            }
        }
        
        /// <summary>Clear Colour Workfile(P#487.3)</summary>
        // Last change before Migration: 16/11/2012 16:26:03
        class ClearColourWorkfile : Mos.BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>Modify Colour Workfile</summary>
            readonly Models.ModifyColourWorkfile ModifyColourWorkfile = new Models.ModifyColourWorkfile { AllowRowLocking = true };
            #endregion
            
            
            /// <summary>Clear Colour Workfile(P#487.3)</summary>
            public ClearColourWorkfile()
            {
                Title = "Clear Colour Workfile";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                From = ModifyColourWorkfile;
                OrderBy = ModifyColourWorkfile.SortByMOS_MOD_COL_SIZE_WRK_X1;
                
                #region Columns
                
                Columns.Add(ModifyColourWorkfile.ProductNumber);
                Columns.Add(ModifyColourWorkfile.ColourCode);
                Columns.Add(ModifyColourWorkfile.ColourChanged);
                Columns.Add(ModifyColourWorkfile.OriginalColour);
                #endregion
            }
            
            /// <summary>Clear Colour Workfile</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                Activity = Activities.Delete;
                AllowUserAbort = true;
            }
            
            
        }
        
        /// <summary>Get Header Details(P#487.4)</summary>
        // Last change before Migration: 16/11/2012 16:26:07
        class GetHeaderDetails : Mos.BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>Product</summary>
            readonly Models.Product Product = new Models.Product { ReadOnly = true };
            
            /// <summary>Style Specification</summary>
            readonly Models.StyleSpecification StyleSpecification = new Models.StyleSpecification { ReadOnly = true };
            
            /// <summary>DSS Departments</summary>
            readonly Models.DSSDepartments DSSDepartments = new Models.DSSDepartments { ReadOnly = true };
            
            /// <summary>DSS Sub Departments</summary>
            readonly Models.DSSSubDepartments DSSSubDepartments = new Models.DSSSubDepartments { ReadOnly = true };
            
            /// <summary>DSS Sections</summary>
            readonly Models.DSSSections DSSSections = new Models.DSSSections { ReadOnly = true };
            
            /// <summary>DSS Ranges</summary>
            readonly Models.DSSRanges DSSRanges = new Models.DSSRanges { ReadOnly = true };
            
            /// <summary>DSS Sub Ranges</summary>
            readonly Models.DSSSubRanges DSSSubRanges = new Models.DSSSubRanges { ReadOnly = true };
            #endregion
            
            MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Get Header Details(P#487.4)</summary>
            public GetHeaderDetails(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Get Header Details";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                Relations.Add(Product, 
                		Product.ProductNumber.IsEqualTo(_parent.PProductNumber), 
                	Product.SortByREF_Product_X1);
                
                Relations.Add(StyleSpecification, 
                		StyleSpecification.STYLE_CODE.IsEqualTo(_parent.PStyleCode), 
                	StyleSpecification.SortBySHP_STYLE_SPECIFICATION_X1);
                
                Relations.Add(DSSDepartments, 
                		DSSDepartments.DSS_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_DEPARTMENT_CODE), 
                	DSSDepartments.SortByREF_DEPARTMENTS_X1);
                
                Relations.Add(DSSSubDepartments, 
                		DSSSubDepartments.DSS_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_DEPARTMENT_CODE).And(
                		DSSSubDepartments.DSS_SUB_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_SUB_DEPT_CODE)), 
                	DSSSubDepartments.SortByREF_SUB_DEPARTMENTS_X1);
                
                Relations.Add(DSSSections, 
                		DSSSections.DSS_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_DEPARTMENT_CODE).And(
                		DSSSections.DSS_SUB_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_SUB_DEPT_CODE)).And(
                		DSSSections.DSS_SECTION_CODE.IsEqualTo(StyleSpecification.DSS_SECTION_CODE)), 
                	DSSSections.SortByREF_SECTIONS_X1);
                
                Relations.Add(DSSRanges, 
                		DSSRanges.DSS_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_DEPARTMENT_CODE).And(
                		DSSRanges.DSS_SUB_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_SUB_DEPT_CODE)).And(
                		DSSRanges.DSS_SECTION_CODE.IsEqualTo(StyleSpecification.DSS_SECTION_CODE)).And(
                		DSSRanges.DSS_RANGE_CODE.IsEqualTo(StyleSpecification.DSS_RANGE_CODE)), 
                	DSSRanges.SortByREF_RANGES_X1);
                
                Relations.Add(DSSSubRanges, 
                		DSSSubRanges.DSS_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_DEPARTMENT_CODE).And(
                		DSSSubRanges.DSS_SUB_DEPARTMENT_CODE.IsEqualTo(StyleSpecification.DSS_SUB_DEPT_CODE)).And(
                		DSSSubRanges.DSS_SECTION_CODE.IsEqualTo(StyleSpecification.DSS_SECTION_CODE)).And(
                		DSSSubRanges.DSS_RANGE_CODE.IsEqualTo(StyleSpecification.DSS_RANGE_CODE)).And(
                		DSSSubRanges.DSS_SUB_RANGE_CODE.IsEqualTo(StyleSpecification.DSS_SUB_RANGE_CODE)), 
                	DSSSubRanges.SortByREF_SUB_RANGES_X1);
                
                
                #region Columns
                
                Columns.Add(Product.ProductNumber);
                Columns.Add(Product.ProductDescription);
                Columns.Add(Product.Season1);
                Columns.Add(Product.DSSDepartmentCode);
                Columns.Add(Product.DSSSubDepartmentCode);
                
                Columns.Add(StyleSpecification.STYLE_CODE);
                Columns.Add(StyleSpecification.BRAND_NAME);
                Columns.Add(StyleSpecification.DSS_DEPARTMENT_CODE);
                Columns.Add(StyleSpecification.DSS_SUB_DEPT_CODE);
                Columns.Add(StyleSpecification.DSS_SECTION_CODE);
                Columns.Add(StyleSpecification.DSS_RANGE_CODE);
                Columns.Add(StyleSpecification.DSS_SUB_RANGE_CODE);
                
                Columns.Add(DSSDepartments.DSS_DEPARTMENT_CODE);
                Columns.Add(DSSDepartments.DESCRIPTION);
                
                Columns.Add(DSSSubDepartments.DSS_DEPARTMENT_CODE);
                Columns.Add(DSSSubDepartments.DSS_SUB_DEPARTMENT_CODE);
                Columns.Add(DSSSubDepartments.DESCRIPTION);
                
                Columns.Add(DSSSections.DSS_DEPARTMENT_CODE);
                Columns.Add(DSSSections.DSS_SUB_DEPARTMENT_CODE);
                Columns.Add(DSSSections.DSS_SECTION_CODE);
                Columns.Add(DSSSections.DESCRIPTION);
                
                Columns.Add(DSSRanges.DSS_DEPARTMENT_CODE);
                Columns.Add(DSSRanges.DSS_SUB_DEPARTMENT_CODE);
                Columns.Add(DSSRanges.DSS_SECTION_CODE);
                Columns.Add(DSSRanges.DSS_RANGE_CODE);
                Columns.Add(DSSRanges.DESCRIPTION);
                
                Columns.Add(DSSSubRanges.DSS_DEPARTMENT_CODE);
                Columns.Add(DSSSubRanges.DSS_SUB_DEPARTMENT_CODE);
                Columns.Add(DSSSubRanges.DSS_SECTION_CODE);
                Columns.Add(DSSSubRanges.DSS_RANGE_CODE);
                Columns.Add(DSSSubRanges.DSS_SUB_RANGE_CODE);
                Columns.Add(DSSSubRanges.DESCRIPTION);
                #endregion
            }
            
            /// <summary>Get Header Details</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                Exit(ExitTiming.AfterRow);
                RowLocking = LockingStrategy.OnRowLoading;
                TransactionScope = TransactionScopes.Task;
                AllowUserAbort = true;
            }
            protected override void OnLeaveRow()
            {
                _parent.vProdDescription.Value = Product.ProductDescription;
                _parent.vSeason.Value = Product.Season1;
                _parent.vBrand.Value = u.Mid(StyleSpecification.BRAND_NAME, 1, 1) + u.Lower(u.Mid(StyleSpecification.BRAND_NAME, 2, 30));
                _parent.vDeptDesc.Value = DSSDepartments.DESCRIPTION;
                _parent.vSubDeptDesc.Value = DSSSubDepartments.DESCRIPTION;
                _parent.vSectionDesc.Value = DSSSections.DESCRIPTION;
                _parent.vRangeDesc.Value = DSSRanges.DESCRIPTION;
                _parent.vSubRangeDesc.Value = DSSSubRanges.DESCRIPTION;
                
                _parent.vDssDeptCode.Value = Product.DSSDepartmentCode;
                _parent.vDssSubDeptCode.Value = Product.DSSSubDepartmentCode;
            }
            
            
        }
        
        /// <summary>Clear Size Workfile(P#487.5)</summary>
        // Last change before Migration: 16/11/2012 16:26:12
        class ClearSizeWorkfile : Mos.BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>Modify Size Workfile</summary>
            readonly Models.ModifySizeWorkfile ModifySizeWorkfile = new Models.ModifySizeWorkfile { AllowRowLocking = true };
            #endregion
            
            
            /// <summary>Clear Size Workfile(P#487.5)</summary>
            public ClearSizeWorkfile()
            {
                Title = "Clear Size Workfile";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                From = ModifySizeWorkfile;
                OrderBy = ModifySizeWorkfile.SortByMOS_MOS_SIZE_WORK_X1;
                
                #region Columns
                
                Columns.Add(ModifySizeWorkfile.ProductNumber);
                Columns.Add(ModifySizeWorkfile.SizeCode);
                Columns.Add(ModifySizeWorkfile.SizeChanged);
                Columns.Add(ModifySizeWorkfile.OriginalSize);
                #endregion
            }
            
            /// <summary>Clear Size Workfile</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                Activity = Activities.Delete;
                AllowUserAbort = true;
            }
            
            
        }
        
        /// <summary>Read ProdColSize for Size(P#487.6)</summary>
        // Last change before Migration: 16/11/2012 16:26:18
        class ReadProdColSizeForSize : Mos.BusinessProcessBase 
        {
            
            #region Models
            DynamicSQLEntity sqlEntity;
            #endregion
            
            #region Columns
            
            /// <summary>PRODUCT_NUMBER</summary>
            readonly NumberColumn PRODUCT_NUMBER = new NumberColumn("PRODUCT_NUMBER", "N8")
            {
            	AllowNull = true
            };
            
            /// <summary>SIZE_CODE</summary>
            readonly NumberColumn SIZE_CODE = new NumberColumn("SIZE_CODE", "N4")
            {
            	AllowNull = true
            };
            #endregion
            
            MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Read ProdColSize for Size(P#487.6)</summary>
            public ReadProdColSizeForSize(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Read ProdColSize for Size";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                sqlEntity = new DynamicSQLEntity(Models.DataSources.Ref1, "select distinct t.product_number, t.size_code from ref_prdcolsz t WHERE t.product_number = :1");
                sqlEntity.AddParameter(_parent.PProductNumber); //:1;
                sqlEntity.Columns.Add(PRODUCT_NUMBER, SIZE_CODE);
                From = sqlEntity;
                
                #region Columns
                
                Columns.Add(PRODUCT_NUMBER);
                Columns.Add(SIZE_CODE);
                #endregion
            }
            
            /// <summary>Read ProdColSize for Size</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                TransactionScope = TransactionScopes.Task;
                Activity = Activities.Browse;
                AllowDelete = false;
                AllowUserAbort = true;
            }
            protected override void OnLeaveRow()
            {
                Cached<WriteToWorkfile>().Run();
            }
            
            
            
            /// <summary>Write to workfile(P#487.6.1)</summary>
            // Last change before Migration: 16/11/2012 16:26:23
            class WriteToWorkfile : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Modify Size Workfile</summary>
                readonly Models.ModifySizeWorkfile ModifySizeWorkfile = new Models.ModifySizeWorkfile { AllowRowLocking = true };
                #endregion
                
                ReadProdColSizeForSize _parent;
                
                
                /// <summary>Write to workfile(P#487.6.1)</summary>
                public WriteToWorkfile(ReadProdColSizeForSize parent)
                {
                    _parent = parent;
                    Title = "Write to workfile";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(ModifySizeWorkfile, RelationType.Insert, 
                    	ModifySizeWorkfile.SortByMOS_MOS_SIZE_WORK_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(ModifySizeWorkfile.ProductNumber).BindValue(_parent._parent.PProductNumber);
                    Columns.Add(ModifySizeWorkfile.SizeCode).BindValue(_parent.SIZE_CODE);
                    Columns.Add(ModifySizeWorkfile.SizeChanged).BindValue(() => false);
                    Columns.Add(ModifySizeWorkfile.OriginalSize).BindValue(_parent.SIZE_CODE);
                    #endregion
                }
                
                /// <summary>Write to workfile</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                
                
            }
        }
        
        /// <summary>Display Size Details(P#487.7)</summary>
        // Last change before Migration: 20/11/2012 10:46:46
        internal class DisplaySizeDetails : Mos.UIControllerBase 
        {
            
            #region Models
            
            /// <summary>Modify Size Workfile</summary>
            internal readonly Models.ModifySizeWorkfile ModifySizeWorkfile = new Models.ModifySizeWorkfile { AllowRowLocking = true };
            
            /// <summary>Size</summary>
            internal readonly Models.Size1 Size1 = new Models.Size1 { ReadOnly = true };
            
            /// <summary>Size</summary>
            readonly Models.Size1 Size11 = new Models.Size1 { ReadOnly = true };
            #endregion
            
            #region Columns
            
            /// <summary>v:char return</summary>
            readonly TextColumn vCharReturn = new TextColumn("v:char return", "4");
            
            /// <summary>v:next relative position</summary>
            readonly NumberColumn vNextRelativePosition = new NumberColumn("v:next relative position", "2");
            
            /// <summary>CHG_REASON</summary>
            readonly NumberColumn CHG_REASON = new NumberColumn("CHG_REASON", "2");
            #endregion
            
            #region CustomCommands
            
            /// <summary>Exit & Cancel</summary>
            internal readonly CustomCommand ExitCancel = new CustomCommand()
            {
            	Name = "Exit & Cancel"
            };
            
            /// <summary>Exit & Save</summary>
            internal readonly CustomCommand ExitSave = new CustomCommand()
            {
            	Name = "Exit & Save"
            };
            
            /// <summary>View Original Details</summary>
            readonly CustomCommand ViewOriginalDetails = new CustomCommand()
            {
            	Name = "View Original Details"
            };
            #endregion
            
            internal MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Display Size Details(P#487.7)</summary>
            public DisplaySizeDetails(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Display Size Details";
                InitializeDataView();
                #region Event Handlers
                
                Handlers.Add(ExitCancel).Invokes += ExitCancelHandler;
                
                Handlers.Add(ExitSave).Invokes += ExitSaveHandler;
                
                Handlers.Add(Command.Expand, "Size Code", HandlerScope.CurrentTaskOnly).Invokes += Expand_SizeCodeHandler;
                
                MonitorValueChanged(ModifySizeWorkfile.SizeCode, ModifySizeWorkfileSizeCode_ValueChanged, CHG_REASON);
                #endregion
            }
            void InitializeDataView()
            {
                From = ModifySizeWorkfile;
                Relations.Add(Size1, 
                		Size1.SizeCode.IsEqualTo(ModifySizeWorkfile.SizeCode), 
                	Size1.SortByREF_Size_X1);
                
                Relations.Add(Size11, 
                		Size11.SizeCode.IsEqualTo(ModifySizeWorkfile.OriginalSize), 
                	Size11.SortByREF_Size_X1);
                
                OrderBy = ModifySizeWorkfile.SortByMOS_MOS_SIZE_WORK_X1;
                
                #region Columns
                
                Columns.Add(ModifySizeWorkfile.ProductNumber);
                Columns.Add(ModifySizeWorkfile.SizeCode);
                Columns.Add(ModifySizeWorkfile.SizeChanged);
                Columns.Add(ModifySizeWorkfile.OriginalSize);
                
                // current size
                Columns.Add(Size1.SizeCode);
                Columns.Add(Size1.SizeDescription);
                
                // original size
                Columns.Add(Size11.SizeCode);
                Columns.Add(Size11.SizeDescription);
                
                Columns.Add(vCharReturn).BindValue(() => u.ASCIIChr(13));
                Columns.Add(vNextRelativePosition);
                #endregion
            }
            
            /// <summary>Display Size Details</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                RowLocking = LockingStrategy.OnUserEdit;
                TransactionScope = TransactionScopes.Row;
                SwitchToInsertWhenNoRows = true;
                AllowDelete = false;
                AllowInsert = false;
                View = ()=> new Views.MaintModColSizePo2071MaintainProdColSize(this);
            }
            
            #region Handlers
            void ExitCancelHandler(HandlerInvokeEventArgs e)
            {
                _parent.vKeepSizeChanges.Value = false;
                _parent.vProperExit.Value = true;
                _parent.PColourOrSizeChanged.Value = false;
                Cached<delFromProductSizesOthers>().Run();
                Cached<delFromProdColSizeOthers>().Run();
                Raise(Command.Exit);
                e.Handled = true;
            }
            void ExitSaveHandler(HandlerInvokeEventArgs e)
            {
                _parent.vKeepSizeChanges.Value = true;
                _parent.vProperExit.Value = true;
                _parent.PColourOrSizeChanged.Value = true;
                Cached<deleteFromProductSizes9999>().Run();
                Cached<deleteFromProdColSize9999>().Run();
                if(false)
                {
                    Cached<deleteFromOrdlotszcost9999>().Run();
                }
                Cached<CalcRelPosition>().Run();
                Raise(Command.Exit);
                e.Handled = true;
            }
            void Expand_SizeCodeHandler(HandlerInvokeEventArgs e)
            {
                Lookups.LookupSizeRangesPo1032.Create().Run(
                				_parent.vDssDeptCode, 
                				_parent.vDssSubDeptCode, 
                				_parent.vSizeRangeFromLookup);
                Cached<TruncateMultiSelectSizes>().Run();
                SubPrograms.SubSelectSizeCodePo1605.Create().Run(
                				_parent.PProductNumber, 
                				0, 
                				Time.Now, 
                				_parent.PMaxAllowed);
                e.Handled = true;
            }
            #endregion
            
            #region Column Change Handlers
            void ModifySizeWorkfileSizeCode_ValueChanged(ValueChangedEventArgs<Number> e)
            {
                if(CHG_REASON == 0)
                {
                    LockCurrentRowIfItWasChanged();
                    ModifySizeWorkfile.SizeChanged.SilentSet(true);
                    if(ModifySizeWorkfile.SizeCode != ModifySizeWorkfile.OriginalSize)
                    {
                        Cached<ChangeAllSizes>().Run();
                    }
                    if(ModifySizeWorkfile.SizeCode == ModifySizeWorkfile.OriginalSize)
                    {
                        Cached<ChangeBackToOriginal>().Run();
                    }
                }
            }
            #endregion
            
            #region Expressions
            internal Bool Exp_9()
            {
                return u.Not(_parent.vDisableSaveButton);
            }
            #endregion
            
            
            
            /// <summary>Truncate Multi Select Sizes(P#487.7.1)</summary>
            // Last change before Migration: 20/11/2012 10:46:58
            class TruncateMultiSelectSizes : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Multi Select Sizes</summary>
                readonly Models.MultiSelectSizes MultiSelectSizes = new Models.MultiSelectSizes { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>Truncate Multi Select Sizes(P#487.7.1)</summary>
                public TruncateMultiSelectSizes(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "Truncate Multi Select Sizes";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = MultiSelectSizes;
                    Where.Add(MultiSelectSizes.UserID.IsEqualTo(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name)));
                    OrderBy = MultiSelectSizes.SortBySHP_Multi_Select_Sizes_X1;
                    
                    #region Columns
                    
                    Columns.Add(MultiSelectSizes.UserID);
                    #endregion
                }
                
                /// <summary>Truncate Multi Select Sizes</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    TransactionScope = TransactionScopes.RowLocking;
                    Activity = Activities.Delete;
                }
                protected override void OnEnd()
                {
                    Cached<PopulateMultiSelectSizes>().Run();
                }
                
                
                
                /// <summary>Populate Multi Select Sizes(P#487.7.1.1)</summary>
                // Last change before Migration: 08/08/2012 09:47:45
                class PopulateMultiSelectSizes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Sizes by Size Range</summary>
                    readonly Models.SizesBySizeRange SizesBySizeRange = new Models.SizesBySizeRange { ReadOnly = true };
                    
                    /// <summary>Size</summary>
                    readonly Models.Size1 Size1 = new Models.Size1 { ReadOnly = true };
                    
                    /// <summary>Product Sizes</summary>
                    readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { ReadOnly = true };
                    #endregion
                    
                    #region Columns
                    
                    /// <summary>v:Product Size Exists</summary>
                    readonly BoolColumn vProductSizeExists = new BoolColumn("v:Product Size Exists");
                    #endregion
                    
                    TruncateMultiSelectSizes _parent;
                    
                    
                    /// <summary>Populate Multi Select Sizes(P#487.7.1.1)</summary>
                    public PopulateMultiSelectSizes(TruncateMultiSelectSizes parent)
                    {
                        _parent = parent;
                        Title = "Populate Multi Select Sizes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = SizesBySizeRange;
                        Relations.Add(Size1, 
                        		Size1.SizeCode.IsEqualTo(SizesBySizeRange.SizeCode), 
                        	Size1.SortByREF_Size_X1);
                        
                        Relations.Add(ProductSizes, 
                        		ProductSizes.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber).And(
                        		ProductSizes.SizeCode.IsEqualTo(SizesBySizeRange.SizeCode)), 
                        	ProductSizes.SortBySHP_Product_Sizes_X1);
                        
                        Where.Add(SizesBySizeRange.DSSDepartmentCode.IsEqualTo(_parent._parent._parent.vDssDeptCode));
                        Where.Add(SizesBySizeRange.DSSSubDepartmentCode.IsEqualTo(_parent._parent._parent.vDssSubDeptCode));
                        Where.Add(SizesBySizeRange.SizeRange1.IsEqualTo(_parent._parent._parent.vSizeRangeFromLookup));
                        OrderBy = SizesBySizeRange.SortBySHP_Sizes_by_Size_Range_X1;
                        
                        #region Columns
                        
                        Columns.Add(SizesBySizeRange.DSSDepartmentCode);
                        Columns.Add(SizesBySizeRange.DSSSubDepartmentCode);
                        Columns.Add(SizesBySizeRange.SizeRange1);
                        Columns.Add(SizesBySizeRange.SizeCode);
                        Columns.Add(Size1.SizeCode);
                        Columns.Add(Size1.SizeDescription);
                        Columns.Add(Size1.Status);
                        Columns.Add(Size1.FullDescription);
                        Columns.Add(vProductSizeExists);
                        Relations[ProductSizes].NotifyRowWasFoundTo(vProductSizeExists);
                        Columns.Add(ProductSizes.ProductNumber);
                        Columns.Add(ProductSizes.SizeCode);
                        Columns.Add(SizesBySizeRange.VatCode);
                        #endregion
                    }
                    
                    /// <summary>Populate Multi Select Sizes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                    }
                    protected override void OnLeaveRow()
                    {
                        // if not already exists on product size and size not suspended
                        if(u.Not(vProductSizeExists) && Size1.Status != 9)
                        {
                            Cached<WriteToTemp>().Run();
                        }
                    }
                    
                    
                    
                    /// <summary>Write to Temp(P#487.7.1.1.1)</summary>
                    // Last change before Migration: 08/08/2012 09:50:37
                    class WriteToTemp : Mos.BusinessProcessBase 
                    {
                        
                        #region Models
                        
                        /// <summary>Multi Select Sizes</summary>
                        readonly Models.MultiSelectSizes MultiSelectSizes = new Models.MultiSelectSizes { AllowRowLocking = true };
                        #endregion
                        
                        PopulateMultiSelectSizes _parent;
                        
                        
                        /// <summary>Write to Temp(P#487.7.1.1.1)</summary>
                        public WriteToTemp(PopulateMultiSelectSizes parent)
                        {
                            _parent = parent;
                            Title = "Write to Temp";
                            InitializeDataView();
                        }
                        void InitializeDataView()
                        {
                            Relations.Add(MultiSelectSizes, RelationType.InsertIfNotFound, 
                            		MultiSelectSizes.UserID.BindEqualTo(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name)).And(
                            		MultiSelectSizes.SizeCode.BindEqualTo(_parent.SizesBySizeRange.SizeCode)), 
                            	MultiSelectSizes.SortBySHP_Multi_Select_Sizes_X1);
                            
                            
                            #region Columns
                            
                            Columns.Add(MultiSelectSizes.UserID);
                            Columns.Add(MultiSelectSizes.SizeCode);
                            Columns.Add(MultiSelectSizes.VATCode).BindValue(_parent.SizesBySizeRange.VatCode);
                            Columns.Add(MultiSelectSizes.SizeDescription).BindValue(_parent.Size1.SizeDescription);
                            Columns.Add(MultiSelectSizes.SelectFlag).BindValue(() => "N");
                            Columns.Add(MultiSelectSizes.FullDescription).BindValue(_parent.Size1.FullDescription);
                            #endregion
                        }
                        
                        /// <summary>Write to Temp</summary>
                        internal void Run()
                        {
                            Execute();
                        }
                        protected override void OnLoad()
                        {
                            Exit(ExitTiming.AfterRow);
                            RowLocking = LockingStrategy.OnRowLoading;
                            TransactionScope = TransactionScopes.Task;
                        }
                        
                        
                    }
                }
            }
            
            /// <summary>delete from product sizes-9999(P#487.7.2)</summary>
            // Last change before Migration: 20/11/2012 10:46:45
            class deleteFromProductSizes9999 : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Sizes</summary>
                readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>delete from product sizes-9999(P#487.7.2)</summary>
                public deleteFromProductSizes9999(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "delete from product sizes-9999";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductSizes;
                    Where.Add(ProductSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ProductSizes.SizeCode.IsEqualTo(9999));
                    OrderBy = ProductSizes.SortBySHP_Product_Sizes_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductSizes.ProductNumber);
                    Columns.Add(ProductSizes.SizeCode);
                    #endregion
                }
                
                /// <summary>delete from product sizes-9999</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    Activity = Activities.Delete;
                    AllowUserAbort = true;
                }
                
                
            }
            
            /// <summary>delete from prod col size-9999(P#487.7.3)</summary>
            // Last change before Migration: 20/11/2012 10:46:42
            class deleteFromProdColSize9999 : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Colour Size</summary>
                readonly Models.ProductColourSize ProductColourSize = new Models.ProductColourSize { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>delete from prod col size-9999(P#487.7.3)</summary>
                public deleteFromProdColSize9999(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "delete from prod col size-9999";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductColourSize;
                    Where.Add(ProductColourSize.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ProductColourSize.SizeCode.IsEqualTo(9999));
                    OrderBy = ProductColourSize.SortByREF_PrdColSz_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductColourSize.ProductNumber);
                    Columns.Add(ProductColourSize.SizeCode);
                    #endregion
                }
                
                /// <summary>delete from prod col size-9999</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    Activity = Activities.Delete;
                    AllowUserAbort = true;
                }
                
                
            }
            
            /// <summary>Calc Rel Position(P#487.7.4)</summary>
            // Last change before Migration: 20/11/2012 10:46:38
            class CalcRelPosition : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Sizes</summary>
                readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { AllowRowLocking = true };
                #endregion
                
                #region Columns
                
                /// <summary>v:Rel Pos record exists</summary>
                readonly BoolColumn vRelPosRecordExists = new BoolColumn("v:Rel Pos record exists");
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>Calc Rel Position(P#487.7.4)</summary>
                public CalcRelPosition(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "Calc Rel Position";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(ProductSizes, 
                    		ProductSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber), 
                    	ProductSizes.SortBySHP_Product_Sizes_X2);
                    Relations[ProductSizes].OrderBy.Reversed = true;
                    
                    
                    #region Columns
                    
                    Columns.Add(vRelPosRecordExists);
                    Relations[ProductSizes].NotifyRowWasFoundTo(vRelPosRecordExists);
                    Columns.Add(ProductSizes.ProductNumber);
                    Columns.Add(ProductSizes.SizeRelativePosition);
                    #endregion
                }
                
                /// <summary>Calc Rel Position</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                }
                protected override void OnStart()
                {
                    _parent.vNextRelativePosition.Value = 0;
                }
                protected override void OnLeaveRow()
                {
                    _parent.vNextRelativePosition.Value = u.If(u.Not(vRelPosRecordExists), 0, ProductSizes.SizeRelativePosition + 1);
                }
                
                
            }
            
            /// <summary>del from product sizes -others(P#487.7.5)</summary>
            // Last change before Migration: 20/11/2012 10:46:33
            class delFromProductSizesOthers : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Sizes</summary>
                readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>del from product sizes -others(P#487.7.5)</summary>
                public delFromProductSizesOthers(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "del from product sizes -others";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductSizes;
                    Where.Add(ProductSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ProductSizes.SizeCode.IsLessOrEqualTo(9998));
                    OrderBy = ProductSizes.SortBySHP_Product_Sizes_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductSizes.ProductNumber);
                    Columns.Add(ProductSizes.SizeCode);
                    #endregion
                }
                
                /// <summary>del from product sizes -others</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    Activity = Activities.Delete;
                    AllowUserAbort = true;
                }
                
                
            }
            
            /// <summary>del from prod col size -others(P#487.7.6)</summary>
            // Last change before Migration: 20/11/2012 10:46:30
            class delFromProdColSizeOthers : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Colour Size</summary>
                readonly Models.ProductColourSize ProductColourSize = new Models.ProductColourSize { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>del from prod col size -others(P#487.7.6)</summary>
                public delFromProdColSizeOthers(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "del from prod col size -others";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductColourSize;
                    Where.Add(ProductColourSize.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ProductColourSize.SizeCode.IsLessOrEqualTo(9998));
                    OrderBy = ProductColourSize.SortByREF_PrdColSz_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductColourSize.ProductNumber);
                    Columns.Add(ProductColourSize.SizeCode);
                    #endregion
                }
                
                /// <summary>del from prod col size -others</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    Activity = Activities.Delete;
                    AllowUserAbort = true;
                }
                
                
            }
            
            /// <summary>Change All sizes(P#487.7.7)</summary>
            // Last change before Migration: 20/11/2012 10:46:26
            class ChangeAllSizes : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Modify Size Workfile</summary>
                readonly Models.ModifySizeWorkfile ModifySizeWorkfile = new Models.ModifySizeWorkfile { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>Change All sizes(P#487.7.7)</summary>
                public ChangeAllSizes(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "Change All sizes";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ModifySizeWorkfile;
                    Where.Add(ModifySizeWorkfile.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ModifySizeWorkfile.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize));
                    OrderBy = ModifySizeWorkfile.SortByMOS_MOS_SIZE_WORK_X1;
                    
                    #region Columns
                    
                    Columns.Add(ModifySizeWorkfile.ProductNumber);
                    Columns.Add(ModifySizeWorkfile.SizeCode);
                    Columns.Add(ModifySizeWorkfile.SizeChanged);
                    Columns.Add(ModifySizeWorkfile.OriginalSize);
                    #endregion
                }
                
                /// <summary>Change All sizes</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    ModifySizeWorkfile.SizeCode.Value = _parent.ModifySizeWorkfile.SizeCode;
                    ModifySizeWorkfile.SizeChanged.Value = true;
                }
                
                
            }
            
            /// <summary>Change back to original(P#487.7.8)</summary>
            // Last change before Migration: 20/11/2012 10:46:22
            class ChangeBackToOriginal : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Modify Size Workfile</summary>
                readonly Models.ModifySizeWorkfile ModifySizeWorkfile = new Models.ModifySizeWorkfile { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>Change back to original(P#487.7.8)</summary>
                public ChangeBackToOriginal(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "Change back to original";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ModifySizeWorkfile;
                    Where.Add(ModifySizeWorkfile.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ModifySizeWorkfile.OriginalSize.IsEqualTo(_parent.ModifySizeWorkfile.SizeCode));
                    OrderBy = ModifySizeWorkfile.SortByMOS_MOS_SIZE_WORK_X1;
                    
                    #region Columns
                    
                    Columns.Add(ModifySizeWorkfile.ProductNumber);
                    Columns.Add(ModifySizeWorkfile.SizeCode);
                    Columns.Add(ModifySizeWorkfile.SizeChanged);
                    Columns.Add(ModifySizeWorkfile.OriginalSize);
                    #endregion
                }
                
                /// <summary>Change back to original</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    ModifySizeWorkfile.SizeCode.Value = ModifySizeWorkfile.OriginalSize;
                    ModifySizeWorkfile.SizeChanged.Value = false;
                }
                
                
            }
            
            /// <summary>delete from ordlotszcost -9999(P#487.7.9)</summary>
            // Last change before Migration: 20/11/2012 10:46:18
            class deleteFromOrdlotszcost9999 : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Order Lot Size Cost</summary>
                readonly Models.OrderLotSizeCost OrderLotSizeCost = new Models.OrderLotSizeCost { AllowRowLocking = true };
                #endregion
                
                DisplaySizeDetails _parent;
                
                
                /// <summary>delete from ordlotszcost -9999(P#487.7.9)</summary>
                public deleteFromOrdlotszcost9999(DisplaySizeDetails parent)
                {
                    _parent = parent;
                    Title = "delete from ordlotszcost -9999";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = OrderLotSizeCost;
                    Where.Add(OrderLotSizeCost.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(OrderLotSizeCost.SizeCode.IsEqualTo(9999));
                    OrderBy = OrderLotSizeCost.SortBySHP_Order_Lot_Size_Cost_X1;
                    
                    #region Columns
                    
                    Columns.Add(OrderLotSizeCost.ProductNumber);
                    Columns.Add(OrderLotSizeCost.SizeCode);
                    #endregion
                }
                
                /// <summary>delete from ordlotszcost -9999</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    Activity = Activities.Delete;
                    AllowUserAbort = true;
                }
                
                
            }
        }
        
        /// <summary>Find Size Changes(P#487.8)</summary>
        // Last change before Migration: 23/04/2013 16:10:52
        internal class FindSizeChanges : Mos.BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>Modify Size Workfile</summary>
            readonly Models.ModifySizeWorkfile ModifySizeWorkfile = new Models.ModifySizeWorkfile { ReadOnly = true };
            
            /// <summary>Line List Order</summary>
            readonly Models.LineListOrder LineListOrder = new Models.LineListOrder { ReadOnly = true };
            
            /// <summary>Product Sizes</summary>
            readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { ReadOnly = true };
            
            /// <summary>Franchise Size Amendments</summary>
            readonly Models.FranchiseSizeAmendments FranchiseSizeAmendments = new Models.FranchiseSizeAmendments { ReadOnly = true };
            #endregion
            
            #region Columns
            
            /// <summary>RC:On Order Lot Size Cost</summary>
            readonly BoolColumn RCOnOrderLotSizeCost = new BoolColumn("RC:On Order Lot Size Cost");
            
            /// <summary>RC:On Order Lot Item</summary>
            readonly BoolColumn RCOnOrderLotItem = new BoolColumn("RC:On Order Lot Item");
            
            /// <summary>RC:On SS Item Price</summary>
            readonly BoolColumn RCOnSSItemPrice = new BoolColumn("RC:On SS Item Price");
            
            /// <summary>RC:On Substitutes</summary>
            readonly BoolColumn RCOnSubstitutes = new BoolColumn("RC:On Substitutes");
            
            /// <summary>RC:On Pack Allocs</summary>
            readonly BoolColumn RCOnPackAllocs = new BoolColumn("RC:On Pack Allocs");
            
            /// <summary>RC:On Web Selected Sizes</summary>
            readonly BoolColumn RCOnWebSelectedSizes = new BoolColumn("RC:On Web Selected Sizes");
            
            /// <summary>RC:On Web Item Order</summary>
            readonly BoolColumn RCOnWebItemOrder = new BoolColumn("RC:On Web Item Order");
            
            /// <summary>RC:On Web Product Status</summary>
            readonly BoolColumn RCOnWebProductStatus = new BoolColumn("RC:On Web Product Status");
            
            /// <summary>RC:On Product Cost</summary>
            readonly BoolColumn RCOnProductCost = new BoolColumn("RC:On Product Cost");
            
            /// <summary>RC:On Packs Makeup</summary>
            readonly BoolColumn RCOnPacksMakeup = new BoolColumn("RC:On Packs Makeup");
            
            /// <summary>RC:On Franch Pack Makeup</summary>
            readonly BoolColumn RCOnFranchPackMakeup = new BoolColumn("RC:On Franch Pack Makeup");
            
            /// <summary>RC:On Models Detail</summary>
            readonly BoolColumn RCOnModelsDetail = new BoolColumn("RC:On Models Detail");
            
            /// <summary>RC:On Ref TCodes</summary>
            readonly BoolColumn RCOnRefTCodes = new BoolColumn("RC:On Ref TCodes");
            
            /// <summary>RC:On Ref Tilprc</summary>
            readonly BoolColumn RCOnRefTilprc = new BoolColumn("RC:On Ref Tilprc");
            
            /// <summary>RC:On po2060 Item Extract</summary>
            readonly BoolColumn RCOnPo2060ItemExtract = new BoolColumn("RC:On po2060 Item Extract");
            
            /// <summary>RC:product on a line list</summary>
            readonly BoolColumn RCProductOnALineList = new BoolColumn("RC:product on a line list");
            
            /// <summary>RC:audit record found</summary>
            readonly BoolColumn RCAuditRecordFound = new BoolColumn("RC:audit record found");
            #endregion
            
            MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Find Size Changes(P#487.8)</summary>
            public FindSizeChanges(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Find Size Changes";
                InitializeDataView();
                var ModifySizeWorkfileSizeCodeGroup = Groups.Add(ModifySizeWorkfile.SizeCode);
                ModifySizeWorkfileSizeCodeGroup.Leave += ModifySizeWorkfileSizeCodeGroup_Leave;
            }
            void InitializeDataView()
            {
                From = ModifySizeWorkfile;
                Relations.Add(LineListOrder, 
                		LineListOrder.MackaysOrderNumber.IsEqualTo(_parent.POrderNumber).And(
                		LineListOrder.ProductNumber.IsEqualTo(_parent.PProductNumber)), 
                	LineListOrder.SortByMOS_FRA_LINE_LIST_ORDER_X1);
                
                Relations.Add(ProductSizes, 
                		ProductSizes.ProductNumber.IsEqualTo(_parent.PProductNumber).And(
                		ProductSizes.SizeCode.IsEqualTo(ModifySizeWorkfile.OriginalSize)), 
                	ProductSizes.SortBySHP_Product_Sizes_X1);
                
                Relations.Add(FranchiseSizeAmendments, 
                		FranchiseSizeAmendments.LineListNumber.IsEqualTo(LineListOrder.LineListNumber).And(
                		FranchiseSizeAmendments.ProductNumber.IsEqualTo(_parent.PProductNumber)).And(
                		FranchiseSizeAmendments.SizeRelativePosition.IsEqualTo(ProductSizes.SizeRelativePosition)), 
                	FranchiseSizeAmendments.SortByMOS_FRA_SIZE_AMEND_X1);
                Relations[FranchiseSizeAmendments].OrderBy.Reversed = true;
                
                Where.Add(ModifySizeWorkfile.ProductNumber.IsEqualTo(_parent.PProductNumber));
                OrderBy = ModifySizeWorkfile.SortByMOS_MOS_SIZE_WORK_X1;
                
                #region Columns
                
                Columns.Add(ModifySizeWorkfile.ProductNumber);
                Columns.Add(ModifySizeWorkfile.SizeCode);
                Columns.Add(ModifySizeWorkfile.SizeChanged);
                Columns.Add(ModifySizeWorkfile.OriginalSize);
                
                Columns.Add(RCOnOrderLotSizeCost);
                Columns.Add(RCOnOrderLotItem);
                Columns.Add(RCOnSSItemPrice);
                Columns.Add(RCOnSubstitutes);
                Columns.Add(RCOnPackAllocs);
                Columns.Add(RCOnWebSelectedSizes);
                Columns.Add(RCOnWebItemOrder);
                Columns.Add(RCOnWebProductStatus);
                Columns.Add(RCOnProductCost);
                Columns.Add(RCOnPacksMakeup);
                Columns.Add(RCOnFranchPackMakeup);
                Columns.Add(RCOnModelsDetail);
                Columns.Add(RCOnRefTCodes);
                Columns.Add(RCOnRefTilprc);
                Columns.Add(RCOnPo2060ItemExtract);
                
                Columns.Add(RCProductOnALineList);
                Relations[LineListOrder].NotifyRowWasFoundTo(RCProductOnALineList);
                Columns.Add(LineListOrder.MackaysOrderNumber);
                Columns.Add(LineListOrder.LotNumber);
                Columns.Add(LineListOrder.LineListNumber);
                Columns.Add(LineListOrder.ProductNumber);
                
                Columns.Add(ProductSizes.ProductNumber);
                Columns.Add(ProductSizes.SizeCode);
                Columns.Add(ProductSizes.SizeRelativePosition);
                
                Columns.Add(RCAuditRecordFound);
                Relations[FranchiseSizeAmendments].NotifyRowWasFoundTo(RCAuditRecordFound);
                Columns.Add(FranchiseSizeAmendments.LineListNumber);
                Columns.Add(FranchiseSizeAmendments.ProductNumber);
                Columns.Add(FranchiseSizeAmendments.SizeRelativePosition);
                Columns.Add(FranchiseSizeAmendments.AuditVersion);
                #endregion
            }
            
            /// <summary>Find Size Changes</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                RowLocking = LockingStrategy.OnRowLoading;
                TransactionScope = TransactionScopes.Task;
                AllowUserAbort = true;
                if(NewViewRequired)
                {
                    View = ()=> new Views.MaintModColSizePo2071PleaseWait(this);
                }
            }
            void ModifySizeWorkfileSizeCodeGroup_Leave()
            {
                if(RCProductOnALineList)
                {
                    Cached<WriteFranchSizeAmendments>().Run();
                }
                Cached<SingleSizePrice>().Run();
                Cached<ReadProductSize>().Run();
                if(u.Delay(5))
                {
                    Cached<CheckTablesViaMagic>().Run();
                }
            }
            
            
            
            /// <summary>Check tables via magic(P#487.8.1)</summary>
            // Last change before Migration: 23/04/2013 16:10:52
            class CheckTablesViaMagic : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Order Lot Size Cost</summary>
                readonly Models.OrderLotSizeCost OrderLotSizeCost = new Models.OrderLotSizeCost { ReadOnly = true };
                
                /// <summary>Order Lot Item</summary>
                readonly Models.OrderLotItem OrderLotItem = new Models.OrderLotItem { ReadOnly = true };
                
                /// <summary>Intake Item Week</summary>
                readonly Models.IntakeItemWeek IntakeItemWeek = new Models.IntakeItemWeek { ReadOnly = true };
                
                /// <summary>Price File</summary>
                readonly Models.PriceFile PriceFile = new Models.PriceFile { ReadOnly = true };
                
                /// <summary>Substitutes</summary>
                readonly Models.Substitutes Substitutes = new Models.Substitutes { ReadOnly = true };
                
                /// <summary>ALC_Pack_Allocs</summary>
                readonly Models.ALC_Pack_Allocs ALC_Pack_Allocs = new Models.ALC_Pack_Allocs { ReadOnly = true };
                
                /// <summary>Web Selected Sizes</summary>
                readonly Models.WebSelectedSizes WebSelectedSizes = new Models.WebSelectedSizes { ReadOnly = true };
                
                /// <summary>Web Item Order</summary>
                readonly Models.WebItemOrder WebItemOrder = new Models.WebItemOrder { ReadOnly = true };
                
                /// <summary>Web Test Selected Sizes</summary>
                readonly Models.WebTestSelectedSizes WebTestSelectedSizes = new Models.WebTestSelectedSizes { ReadOnly = true };
                
                /// <summary>Web Product Status</summary>
                readonly Models.WebProductStatus WebProductStatus = new Models.WebProductStatus { ReadOnly = true };
                
                /// <summary>REF_PRODCOST</summary>
                readonly Models.REF_PRODCOST REF_PRODCOST = new Models.REF_PRODCOST { ReadOnly = true };
                
                /// <summary>Packs Make Up</summary>
                readonly Models.PacksMakeUp PacksMakeUp = new Models.PacksMakeUp { ReadOnly = true };
                
                /// <summary>Franchisee Pack Makeup</summary>
                readonly Models.FranchiseePackMakeup FranchiseePackMakeup = new Models.FranchiseePackMakeup { Cached = false, ReadOnly = true };
                
                /// <summary>Models Detail</summary>
                readonly Models.ModelsDetail ModelsDetail = new Models.ModelsDetail { ReadOnly = true };
                
                /// <summary>Tcodes</summary>
                readonly Models.Tcodes Tcodes = new Models.Tcodes { ReadOnly = true };
                
                /// <summary>Till Price</summary>
                readonly Models.TillPrice TillPrice = new Models.TillPrice { ReadOnly = true };
                
                /// <summary>MOS_po2060_Item_Extract</summary>
                readonly Models.MOS_po2060_Item_Extract MOS_po2060_Item_Extract = new Models.MOS_po2060_Item_Extract { ReadOnly = true };
                #endregion
                
                FindSizeChanges _parent;
                
                
                /// <summary>Check tables via magic(P#487.8.1)</summary>
                public CheckTablesViaMagic(FindSizeChanges parent)
                {
                    _parent = parent;
                    Title = "Check tables via magic";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(OrderLotSizeCost, 
                    		OrderLotSizeCost.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		OrderLotSizeCost.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	OrderLotSizeCost.SortBySHP_Order_Lot_Size_Cost_X1);
                    
                    Relations.Add(OrderLotItem, 
                    		OrderLotItem.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		OrderLotItem.SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	OrderLotItem.SortByMOS_ORDER_LOT_ITEM_X2);
                    
                    Relations.Add(IntakeItemWeek, 
                    		IntakeItemWeek.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		IntakeItemWeek.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	IntakeItemWeek.SortByMOS_Intake_Item_Week_X1);
                    
                    Relations.Add(PriceFile, 
                    		PriceFile.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		PriceFile.SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	PriceFile.SortBySS_ITEM_PRICE_X1);
                    
                    Relations.Add(Substitutes, 
                    		Substitutes.PRIMARY_PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		Substitutes.PRIMARY_SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	Substitutes.SortByALC_SUBSTITUTE_ITEMS_X1);
                    
                    Relations.Add(ALC_Pack_Allocs, 
                    		ALC_Pack_Allocs.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ALC_Pack_Allocs.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	ALC_Pack_Allocs.SortByALC_Pack_Allocs_X1);
                    Relations[ALC_Pack_Allocs].BindEnabled(()=> false);
                    
                    Relations.Add(WebSelectedSizes, 
                    		WebSelectedSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebSelectedSizes.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	WebSelectedSizes.SortByMOS_Web_Selected_Sizes_X1);
                    
                    Relations.Add(WebItemOrder, 
                    		WebItemOrder.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebItemOrder.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	WebItemOrder.SortByMOS_Web_Item_Order_X1);
                    
                    Relations.Add(WebTestSelectedSizes, 
                    		WebTestSelectedSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebTestSelectedSizes.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	WebTestSelectedSizes.SortByMOS_WebTst_Selected_Sizes_X1);
                    
                    Relations.Add(WebProductStatus, 
                    		WebProductStatus.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebProductStatus.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	WebProductStatus.SortByMOS_Web_Prod_Status_X1);
                    
                    Relations.Add(REF_PRODCOST, 
                    		REF_PRODCOST.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		REF_PRODCOST.SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	REF_PRODCOST.SortByREF_PRODCOST_X1);
                    
                    Relations.Add(PacksMakeUp, 
                    		PacksMakeUp.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		PacksMakeUp.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	PacksMakeUp.SortByWAR_Pack_MakeUp_X1);
                    
                    Relations.Add(FranchiseePackMakeup, 
                    		FranchiseePackMakeup.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		FranchiseePackMakeup.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	FranchiseePackMakeup.SortByMOS_FRA_PACK_MAKEUP_X1);
                    
                    Relations.Add(ModelsDetail, 
                    		ModelsDetail.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ModelsDetail.SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	ModelsDetail.SortByPRC_MODELS_DETAIL_X1);
                    
                    Relations.Add(Tcodes, 
                    		Tcodes.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		Tcodes.SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	Tcodes.SortByREF_TCODES_X2);
                    
                    Relations.Add(TillPrice, 
                    		TillPrice.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		TillPrice.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	TillPrice.SortByREF_TilPrc_X2);
                    
                    Relations.Add(MOS_po2060_Item_Extract, 
                    		MOS_po2060_Item_Extract.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_po2060_Item_Extract.SIZE_CODE.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize)), 
                    	MOS_po2060_Item_Extract.SortByMOS_PO2060_ITEM_EXTRACT_X1);
                    
                    
                    #region Columns
                    
                    Relations[OrderLotSizeCost].NotifyRowWasFoundTo(_parent.RCOnOrderLotSizeCost);
                    Columns.Add(OrderLotSizeCost.OrderNumber);
                    Columns.Add(OrderLotSizeCost.LotNumber);
                    Columns.Add(OrderLotSizeCost.ProductNumber);
                    Columns.Add(OrderLotSizeCost.SizeCode);
                    
                    Relations[OrderLotItem].NotifyRowWasFoundTo(_parent.RCOnOrderLotItem);
                    Columns.Add(OrderLotItem.PRODUCT_NUMBER);
                    Columns.Add(OrderLotItem.COLOUR_CODE);
                    Columns.Add(OrderLotItem.SIZE_CODE);
                    Columns.Add(OrderLotItem.DUE_WEEK);
                    Columns.Add(OrderLotItem.ORDER_NUMBER);
                    Columns.Add(OrderLotItem.LOT_NUMBER);
                    
                    Columns.Add(IntakeItemWeek.ProductNumber);
                    Columns.Add(IntakeItemWeek.ColourCode);
                    Columns.Add(IntakeItemWeek.SizeCode);
                    Columns.Add(IntakeItemWeek.WRCWeek);
                    Columns.Add(IntakeItemWeek.WRCDate);
                    Columns.Add(IntakeItemWeek.OrderNumber);
                    Columns.Add(IntakeItemWeek.LotNumber);
                    Columns.Add(IntakeItemWeek.WRCNumber);
                    
                    Relations[PriceFile].NotifyRowWasFoundTo(_parent.RCOnSSItemPrice);
                    Columns.Add(PriceFile.PRODUCT_NUMBER);
                    Columns.Add(PriceFile.COLOUR_CODE);
                    Columns.Add(PriceFile.SIZE_CODE);
                    Columns.Add(PriceFile.START_DATETIME);
                    Columns.Add(PriceFile.ZONE);
                    
                    Relations[Substitutes].NotifyRowWasFoundTo(_parent.RCOnSubstitutes);
                    Columns.Add(Substitutes.PRIMARY_PRODUCT_NUMBER);
                    Columns.Add(Substitutes.PRIMARY_COLOUR_CODE);
                    Columns.Add(Substitutes.PRIMARY_SIZE_CODE);
                    Columns.Add(Substitutes.SUBSTITUTED_PRODUCT_NUMBER);
                    Columns.Add(Substitutes.SUBSTITUTED_COLOUR_CODE);
                    Columns.Add(Substitutes.SUBSTITUTED_SIZE_CODE);
                    
                    Relations[ALC_Pack_Allocs].NotifyRowWasFoundTo(_parent.RCOnPackAllocs);
                    Columns.Add(ALC_Pack_Allocs.ProductNumber);
                    Columns.Add(ALC_Pack_Allocs.PackCode);
                    Columns.Add(ALC_Pack_Allocs.SizeCode);
                    
                    Relations[WebSelectedSizes].NotifyRowWasFoundTo(_parent.RCOnWebSelectedSizes);
                    Columns.Add(WebSelectedSizes.ProductNumber);
                    Columns.Add(WebSelectedSizes.ColourCode);
                    Columns.Add(WebSelectedSizes.SizeCode);
                    
                    Relations[WebItemOrder].NotifyRowWasFoundTo(_parent.RCOnWebItemOrder);
                    Columns.Add(WebItemOrder.ProductNumber);
                    Columns.Add(WebItemOrder.ColourCode);
                    Columns.Add(WebItemOrder.SizeCode);
                    
                    Columns.Add(WebTestSelectedSizes.ProductNumber);
                    Columns.Add(WebTestSelectedSizes.ColourCode);
                    Columns.Add(WebTestSelectedSizes.SizeCode);
                    
                    Relations[WebProductStatus].NotifyRowWasFoundTo(_parent.RCOnWebProductStatus);
                    Columns.Add(WebProductStatus.ProductNumber);
                    Columns.Add(WebProductStatus.ColourCode);
                    Columns.Add(WebProductStatus.SizeCode);
                    Columns.Add(WebProductStatus.ProductStatusEvent);
                    Columns.Add(WebProductStatus.EventDateTime);
                    
                    Relations[REF_PRODCOST].NotifyRowWasFoundTo(_parent.RCOnProductCost);
                    Columns.Add(REF_PRODCOST.PRODUCT_NUMBER);
                    Columns.Add(REF_PRODCOST.COLOUR_CODE);
                    Columns.Add(REF_PRODCOST.SIZE_CODE);
                    Columns.Add(REF_PRODCOST.LAST_AMEND_DATE);
                    
                    Relations[PacksMakeUp].NotifyRowWasFoundTo(_parent.RCOnPacksMakeup);
                    Columns.Add(PacksMakeUp.ProductNumber);
                    Columns.Add(PacksMakeUp.PackCode);
                    Columns.Add(PacksMakeUp.ColourCode);
                    Columns.Add(PacksMakeUp.SizeCode);
                    
                    Relations[FranchiseePackMakeup].NotifyRowWasFoundTo(_parent.RCOnFranchPackMakeup);
                    Columns.Add(FranchiseePackMakeup.ProductNumber);
                    Columns.Add(FranchiseePackMakeup.PackCode);
                    Columns.Add(FranchiseePackMakeup.ColourCode);
                    Columns.Add(FranchiseePackMakeup.SizeCode);
                    
                    Relations[ModelsDetail].NotifyRowWasFoundTo(_parent.RCOnModelsDetail);
                    Columns.Add(ModelsDetail.PRICE_MODEL_ID);
                    Columns.Add(ModelsDetail.RANGE_CONCATENATION);
                    Columns.Add(ModelsDetail.PRODUCT_NUMBER);
                    Columns.Add(ModelsDetail.COLOUR_CODE);
                    Columns.Add(ModelsDetail.SIZE_CODE);
                    
                    Relations[Tcodes].NotifyRowWasFoundTo(_parent.RCOnRefTCodes);
                    Columns.Add(Tcodes.PRODUCT_NUMBER);
                    Columns.Add(Tcodes.COLOUR_CODE);
                    Columns.Add(Tcodes.SIZE_CODE);
                    Columns.Add(Tcodes.TILL_CODE);
                    
                    Relations[TillPrice].NotifyRowWasFoundTo(_parent.RCOnRefTilprc);
                    Columns.Add(TillPrice.ProductNumber);
                    Columns.Add(TillPrice.ColourCode);
                    Columns.Add(TillPrice.SizeCode);
                    Columns.Add(TillPrice.TillCode);
                    
                    Relations[MOS_po2060_Item_Extract].NotifyRowWasFoundTo(_parent.RCOnPo2060ItemExtract);
                    Columns.Add(MOS_po2060_Item_Extract.PRODUCT_NUMBER);
                    Columns.Add(MOS_po2060_Item_Extract.COLOUR_CODE);
                    Columns.Add(MOS_po2060_Item_Extract.SIZE_CODE);
                    #endregion
                }
                
                /// <summary>Check tables via magic</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnStart()
                {
                    _parent.RCOnOrderLotSizeCost.Value = false;
                    _parent.RCOnOrderLotItem.Value = false;
                    _parent.RCOnSSItemPrice.Value = false;
                    _parent.RCOnSubstitutes.Value = false;
                    _parent.RCOnPackAllocs.Value = false;
                    _parent.RCOnWebSelectedSizes.Value = false;
                    _parent.RCOnWebItemOrder.Value = false;
                    _parent.RCOnWebProductStatus.Value = false;
                    _parent.RCOnProductCost.Value = false;
                    _parent.RCOnPacksMakeup.Value = false;
                    _parent.RCOnModelsDetail.Value = false;
                    _parent.RCOnRefTCodes.Value = false;
                    _parent.RCOnRefTilprc.Value = false;
                    _parent.RCOnPo2060ItemExtract.Value = false;
                }
                protected override void OnLeaveRow()
                {
                    if(_parent.RCOnOrderLotSizeCost)
                    {
                        Cached<ChangeOrderLotSizeCost>().Run();
                    }
                    if(_parent.RCOnOrderLotItem)
                    {
                        Cached<ChangeOrderLotItem>().Run();
                    }
                    if(_parent.RCOnSSItemPrice)
                    {
                        Cached<ChangeSSItemPrice>().Run();
                    }
                    if(_parent.RCOnSubstitutes)
                    {
                        Cached<ChangeSubstitutes>().Run();
                    }
                    if(_parent.RCOnPackAllocs)
                    {
                        Cached<ChangePackAllocs>().Run();
                    }
                    if(_parent.RCOnWebSelectedSizes)
                    {
                        Cached<ChangeWebSelectedSizes>().Run();
                    }
                    if(_parent.RCOnWebItemOrder)
                    {
                        Cached<ChangeWebItemOrder>().Run();
                    }
                    if(_parent.RCOnWebProductStatus)
                    {
                        Cached<ChangeWebProductStatus>().Run();
                    }
                    if(_parent.RCOnProductCost)
                    {
                        Cached<ChangeProductCost>().Run();
                    }
                    if(_parent.RCOnPacksMakeup)
                    {
                        Cached<ChangePacksMakeup>().Run();
                    }
                    if(_parent.RCOnFranchPackMakeup && _parent.RCProductOnALineList)
                    {
                        Cached<ChangeFranchPacksMakeup>().Run();
                    }
                    if(_parent.RCOnModelsDetail)
                    {
                        Cached<ChangeModelsDetail>().Run();
                    }
                    if(_parent.RCOnRefTCodes)
                    {
                        Cached<ChangeRefTcodes>().Run();
                    }
                    if(_parent.RCOnRefTilprc)
                    {
                        Cached<ChangeRefTillPrice>().Run();
                    }
                    if(_parent.RCOnPo2060ItemExtract)
                    {
                        Cached<ChangePo2060ItemExtract>().Run();
                    }
                }
                
                
                
                /// <summary>Change Order Lot Size Cost(P#487.8.1.1)</summary>
                // Last change before Migration: 19/11/2012 15:01:48
                class ChangeOrderLotSizeCost : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Order Lot Size Cost</summary>
                    readonly Models.OrderLotSizeCost OrderLotSizeCost = new Models.OrderLotSizeCost { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Order Lot Size Cost(P#487.8.1.1)</summary>
                    public ChangeOrderLotSizeCost(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Order Lot Size Cost";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OrderLotSizeCost;
                        Where.Add(OrderLotSizeCost.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(OrderLotSizeCost.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = OrderLotSizeCost.SortBySHP_Order_Lot_Size_Cost_X1;
                        
                        #region Columns
                        
                        Columns.Add(OrderLotSizeCost.ProductNumber);
                        Columns.Add(OrderLotSizeCost.SizeCode);
                        Columns.Add(OrderLotSizeCost.LastUpdateUsrID);
                        Columns.Add(OrderLotSizeCost.LastUpdateDate);
                        Columns.Add(OrderLotSizeCost.LastUpdateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Order Lot Size Cost</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        OrderLotSizeCost.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        OrderLotSizeCost.LastUpdateUsrID.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        OrderLotSizeCost.LastUpdateDate.Value = Date.Now;
                        OrderLotSizeCost.LastUpdateTime.Value = Time.Now;
                    }
                    
                    
                }
                
                /// <summary>Change Order Lot Item(P#487.8.1.2)</summary>
                // Last change before Migration: 19/11/2012 15:01:52
                class ChangeOrderLotItem : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Order Lot Item</summary>
                    readonly Models.OrderLotItem OrderLotItem = new Models.OrderLotItem { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Order Lot Item(P#487.8.1.2)</summary>
                    public ChangeOrderLotItem(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Order Lot Item";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OrderLotItem;
                        Where.Add(OrderLotItem.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(OrderLotItem.SIZE_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = OrderLotItem.SortByMOS_ORDER_LOT_ITEM_X1;
                        
                        #region Columns
                        
                        Columns.Add(OrderLotItem.PRODUCT_NUMBER);
                        Columns.Add(OrderLotItem.SIZE_CODE);
                        Columns.Add(OrderLotItem.LAST_MODIFY_BY);
                        Columns.Add(OrderLotItem.LAST_MODIFY_DATE);
                        Columns.Add(OrderLotItem.LAST_MODIFY_TIME);
                        #endregion
                    }
                    
                    /// <summary>Change Order Lot Item</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        OrderLotItem.SIZE_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        OrderLotItem.LAST_MODIFY_BY.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        OrderLotItem.LAST_MODIFY_DATE.Value = Date.Now;
                        OrderLotItem.LAST_MODIFY_TIME.Value = Time.Now;
                    }
                    
                    
                }
                
                /// <summary>Change SS Item Price(P#487.8.1.3)</summary>
                // Last change before Migration: 23/04/2013 16:10:52
                class ChangeSSItemPrice : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Price File</summary>
                    readonly Models.PriceFile PriceFile = new Models.PriceFile { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change SS Item Price(P#487.8.1.3)</summary>
                    public ChangeSSItemPrice(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change SS Item Price";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = PriceFile;
                        Where.Add(PriceFile.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(PriceFile.SIZE_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = PriceFile.SortBySS_ITEM_PRICE_X1;
                        
                        #region Columns
                        
                        Columns.Add(PriceFile.PRODUCT_NUMBER);
                        Columns.Add(PriceFile.SIZE_CODE);
                        Columns.Add(PriceFile.START_DATETIME);
                        Columns.Add(PriceFile.MODIFY_DATETIME);
                        #endregion
                    }
                    
                    /// <summary>Change SS Item Price</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        PriceFile.SIZE_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        PriceFile.MODIFY_DATETIME.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Substitutes(P#487.8.1.4)</summary>
                // Last change before Migration: 20/11/2012 10:45:59
                class ChangeSubstitutes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Substitutes</summary>
                    readonly Models.Substitutes Substitutes = new Models.Substitutes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Substitutes(P#487.8.1.4)</summary>
                    public ChangeSubstitutes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Substitutes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = Substitutes;
                        Where.Add(Substitutes.PRIMARY_PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(Substitutes.PRIMARY_SIZE_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = Substitutes.SortByALC_SUBSTITUTE_ITEMS_X1;
                        
                        #region Columns
                        
                        Columns.Add(Substitutes.PRIMARY_PRODUCT_NUMBER);
                        Columns.Add(Substitutes.PRIMARY_SIZE_CODE);
                        Columns.Add(Substitutes.AMEND_USER);
                        Columns.Add(Substitutes.AMEND_DATETIME);
                        #endregion
                    }
                    
                    /// <summary>Change Substitutes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        Substitutes.PRIMARY_SIZE_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        Substitutes.AMEND_USER.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        Substitutes.AMEND_DATETIME.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Pack Allocs(P#487.8.1.5)</summary>
                // Last change before Migration: 20/11/2012 10:45:55
                class ChangePackAllocs : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>ALC_Pack_Allocs</summary>
                    readonly Models.ALC_Pack_Allocs ALC_Pack_Allocs = new Models.ALC_Pack_Allocs { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Pack Allocs(P#487.8.1.5)</summary>
                    public ChangePackAllocs(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Pack Allocs";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ALC_Pack_Allocs;
                        Where.Add(ALC_Pack_Allocs.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ALC_Pack_Allocs.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = ALC_Pack_Allocs.SortByALC_Pack_Allocs_X1;
                        
                        #region Columns
                        
                        Columns.Add(ALC_Pack_Allocs.ProductNumber);
                        Columns.Add(ALC_Pack_Allocs.SizeCode);
                        #endregion
                    }
                    
                    /// <summary>Change Pack Allocs</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ALC_Pack_Allocs.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
                
                /// <summary>Change Web Selected Sizes(P#487.8.1.6)</summary>
                // Last change before Migration: 20/11/2012 10:45:51
                class ChangeWebSelectedSizes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Selected Sizes</summary>
                    readonly Models.WebSelectedSizes WebSelectedSizes = new Models.WebSelectedSizes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Selected Sizes(P#487.8.1.6)</summary>
                    public ChangeWebSelectedSizes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Selected Sizes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebSelectedSizes;
                        Where.Add(WebSelectedSizes.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebSelectedSizes.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = WebSelectedSizes.SortByMOS_Web_Selected_Sizes_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebSelectedSizes.ProductNumber);
                        Columns.Add(WebSelectedSizes.SizeCode);
                        Columns.Add(WebSelectedSizes.ModifiedBy);
                        Columns.Add(WebSelectedSizes.ModifiedDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Selected Sizes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebSelectedSizes.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        WebSelectedSizes.ModifiedBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        WebSelectedSizes.ModifiedDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Item Order(P#487.8.1.7)</summary>
                // Last change before Migration: 20/11/2012 10:45:47
                class ChangeWebItemOrder : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Item Order</summary>
                    readonly Models.WebItemOrder WebItemOrder = new Models.WebItemOrder { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Item Order(P#487.8.1.7)</summary>
                    public ChangeWebItemOrder(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Item Order";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebItemOrder;
                        Where.Add(WebItemOrder.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebItemOrder.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = WebItemOrder.SortByMOS_Web_Item_Order_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebItemOrder.ProductNumber);
                        Columns.Add(WebItemOrder.SizeCode);
                        Columns.Add(WebItemOrder.ModifyBy);
                        Columns.Add(WebItemOrder.ModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Item Order</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebItemOrder.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        WebItemOrder.ModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        WebItemOrder.ModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Product Status(P#487.8.1.8)</summary>
                // Last change before Migration: 27/03/2013 11:04:00
                class ChangeWebProductStatus : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Product Status</summary>
                    readonly Models.WebProductStatus WebProductStatus = new Models.WebProductStatus { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Product Status(P#487.8.1.8)</summary>
                    public ChangeWebProductStatus(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Product Status";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebProductStatus;
                        Where.Add(WebProductStatus.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebProductStatus.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = WebProductStatus.SortByMOS_Web_Prod_Status_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebProductStatus.ProductNumber);
                        Columns.Add(WebProductStatus.SizeCode);
                        Columns.Add(WebProductStatus.ProductStatusEvent);
                        Columns.Add(WebProductStatus.EventDateTime);
                        Columns.Add(WebProductStatus.EventUser);
                        #endregion
                    }
                    
                    /// <summary>Change Web Product Status</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebProductStatus.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        if(false)
                        {
                            WebProductStatus.ProductStatusEvent.Value = 99;
                        }
                        if(false)
                        {
                            WebProductStatus.EventDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                        }
                        WebProductStatus.EventUser.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                    }
                    
                    
                }
                
                /// <summary>Change Product Cost(P#487.8.1.9)</summary>
                // Last change before Migration: 20/11/2012 10:45:40
                class ChangeProductCost : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>REF_PRODCOST</summary>
                    readonly Models.REF_PRODCOST REF_PRODCOST = new Models.REF_PRODCOST { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Product Cost(P#487.8.1.9)</summary>
                    public ChangeProductCost(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Product Cost";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = REF_PRODCOST;
                        Where.Add(REF_PRODCOST.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(REF_PRODCOST.SIZE_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = REF_PRODCOST.SortByREF_PRODCOST_X1;
                        
                        #region Columns
                        
                        Columns.Add(REF_PRODCOST.PRODUCT_NUMBER);
                        Columns.Add(REF_PRODCOST.SIZE_CODE);
                        Columns.Add(REF_PRODCOST.LAST_AMEND_DATE);
                        #endregion
                    }
                    
                    /// <summary>Change Product Cost</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        REF_PRODCOST.SIZE_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                        REF_PRODCOST.LAST_AMEND_DATE.Value = Date.Now;
                    }
                    
                    
                }
                
                /// <summary>Change Packs Makeup(P#487.8.1.10)</summary>
                // Last change before Migration: 20/11/2012 10:45:36
                class ChangePacksMakeup : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Packs Make Up</summary>
                    readonly Models.PacksMakeUp PacksMakeUp = new Models.PacksMakeUp { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Packs Makeup(P#487.8.1.10)</summary>
                    public ChangePacksMakeup(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Packs Makeup";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = PacksMakeUp;
                        Where.Add(PacksMakeUp.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(PacksMakeUp.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = PacksMakeUp.SortByWAR_Pack_MakeUp_X1;
                        
                        #region Columns
                        
                        Columns.Add(PacksMakeUp.ProductNumber);
                        Columns.Add(PacksMakeUp.SizeCode);
                        #endregion
                    }
                    
                    /// <summary>Change Packs Makeup</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        PacksMakeUp.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
                
                /// <summary>Change Franch Packs Makeup(P#487.8.1.11)</summary>
                // Last change before Migration: 20/02/2012 14:39:53
                class ChangeFranchPacksMakeup : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Franchisee Pack Makeup</summary>
                    readonly Models.FranchiseePackMakeup FranchiseePackMakeup = new Models.FranchiseePackMakeup { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Franch Packs Makeup(P#487.8.1.11)</summary>
                    public ChangeFranchPacksMakeup(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Franch Packs Makeup";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = FranchiseePackMakeup;
                        Where.Add(FranchiseePackMakeup.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(FranchiseePackMakeup.SizeCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = FranchiseePackMakeup.SortByMOS_FRA_PACK_MAKEUP_X1;
                        
                        #region Columns
                        
                        Columns.Add(FranchiseePackMakeup.ProductNumber);
                        Columns.Add(FranchiseePackMakeup.SizeCode);
                        #endregion
                    }
                    
                    /// <summary>Change Franch Packs Makeup</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        FranchiseePackMakeup.SizeCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
                
                /// <summary>Change Models Detail(P#487.8.1.12)</summary>
                // Last change before Migration: 23/11/2012 10:26:48
                class ChangeModelsDetail : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Models Detail</summary>
                    readonly Models.ModelsDetail ModelsDetail = new Models.ModelsDetail { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Models Detail(P#487.8.1.12)</summary>
                    public ChangeModelsDetail(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Models Detail";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ModelsDetail;
                        Where.Add(ModelsDetail.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ModelsDetail.SIZE_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = ModelsDetail.SortByPRC_MODELS_DETAIL_X1;
                        
                        #region Columns
                        
                        Columns.Add(ModelsDetail.PRODUCT_NUMBER);
                        Columns.Add(ModelsDetail.SIZE_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Models Detail</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ModelsDetail.SIZE_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
                
                /// <summary>Change Ref Tcodes(P#487.8.1.13)</summary>
                // Last change before Migration: 23/11/2012 10:34:40
                class ChangeRefTcodes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Tcodes</summary>
                    readonly Models.Tcodes Tcodes = new Models.Tcodes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Ref Tcodes(P#487.8.1.13)</summary>
                    public ChangeRefTcodes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Ref Tcodes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = Tcodes;
                        Where.Add(Tcodes.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(Tcodes.SIZE_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = Tcodes.SortByREF_TCODES_X2;
                        
                        #region Columns
                        
                        Columns.Add(Tcodes.PRODUCT_NUMBER);
                        Columns.Add(Tcodes.SIZE_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Ref Tcodes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        Tcodes.SIZE_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
                
                /// <summary>Change Ref Till Price(P#487.8.1.14)</summary>
                // Last change before Migration: 23/11/2012 10:34:53
                class ChangeRefTillPrice : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Till Price</summary>
                    readonly Models.TillPrice TillPrice = new Models.TillPrice { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Ref Till Price(P#487.8.1.14)</summary>
                    public ChangeRefTillPrice(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Ref Till Price";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = TillPrice;
                        Where.Add(TillPrice.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(TillPrice.ColourCode.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = TillPrice.SortByREF_TilPrc_X2;
                        
                        #region Columns
                        
                        Columns.Add(TillPrice.ProductNumber);
                        Columns.Add(TillPrice.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change Ref Till Price</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        TillPrice.ColourCode.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
                
                /// <summary>Change po2060 Item Extract(P#487.8.1.15)</summary>
                // Last change before Migration: 23/11/2012 10:35:08
                class ChangePo2060ItemExtract : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_po2060_Item_Extract</summary>
                    readonly Models.MOS_po2060_Item_Extract MOS_po2060_Item_Extract = new Models.MOS_po2060_Item_Extract { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change po2060 Item Extract(P#487.8.1.15)</summary>
                    public ChangePo2060ItemExtract(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change po2060 Item Extract";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_po2060_Item_Extract;
                        Where.Add(MOS_po2060_Item_Extract.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_po2060_Item_Extract.COLOUR_CODE.IsEqualTo(_parent._parent.ModifySizeWorkfile.OriginalSize));
                        OrderBy = MOS_po2060_Item_Extract.SortByMOS_PO2060_ITEM_EXTRACT_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_po2060_Item_Extract.PRODUCT_NUMBER);
                        Columns.Add(MOS_po2060_Item_Extract.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change po2060 Item Extract</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_po2060_Item_Extract.COLOUR_CODE.Value = _parent._parent.ModifySizeWorkfile.SizeCode;
                    }
                    
                    
                }
            }
            
            /// <summary>Read Product Size(P#487.8.2)</summary>
            // Last change before Migration: 20/11/2012 10:45:26
            class ReadProductSize : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Sizes</summary>
                readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { AllowRowLocking = true };
                #endregion
                
                FindSizeChanges _parent;
                
                
                /// <summary>Read Product Size(P#487.8.2)</summary>
                public ReadProductSize(FindSizeChanges parent)
                {
                    _parent = parent;
                    Title = "Read Product Size";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductSizes;
                    Where.Add(ProductSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ProductSizes.SizeCode.IsEqualTo(_parent.ModifySizeWorkfile.OriginalSize));
                    OrderBy = ProductSizes.SortBySHP_Product_Sizes_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductSizes.ProductNumber);
                    Columns.Add(ProductSizes.SizeCode);
                    Columns.Add(ProductSizes.SizeRelativePosition);
                    Columns.Add(ProductSizes.SellingPrice);
                    Columns.Add(ProductSizes.VatCode);
                    Columns.Add(ProductSizes.CreateUser);
                    Columns.Add(ProductSizes.CreateDate);
                    Columns.Add(ProductSizes.CreateTime);
                    Columns.Add(ProductSizes.LastUpdateUsrID);
                    Columns.Add(ProductSizes.LastUpdateDate);
                    Columns.Add(ProductSizes.LastUpdateTime);
                    #endregion
                }
                
                /// <summary>Read Product Size</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    Cached<WriteAuditProductSize>().Run();
                }
                
                
                
                /// <summary>Write Audit Product Size(P#487.8.2.1)</summary>
                // Last change before Migration: 20/11/2012 10:45:25
                class WriteAuditProductSize : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Audit Product Sizes</summary>
                    readonly Models.AuditProductSizes AuditProductSizes = new Models.AuditProductSizes { AllowRowLocking = true };
                    #endregion
                    
                    ReadProductSize _parent;
                    
                    
                    /// <summary>Write Audit Product Size(P#487.8.2.1)</summary>
                    public WriteAuditProductSize(ReadProductSize parent)
                    {
                        _parent = parent;
                        Title = "Write Audit Product Size";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        Relations.Add(AuditProductSizes, RelationType.Insert, 
                        	AuditProductSizes.SortBySHP_AUDIT_PRODUCT_SIZE_X1);
                        
                        
                        #region Columns
                        
                        Columns.Add(AuditProductSizes.PRODUCT_NUMBER).BindValue(_parent._parent._parent.PProductNumber);
                        Columns.Add(AuditProductSizes.CREATE_DATE).BindValue(() => Date.Now);
                        Columns.Add(AuditProductSizes.CREATE_TIME).BindValue(() => Time.Now);
                        Columns.Add(AuditProductSizes.SIZE_RELATIVE_POSITION).BindValue(_parent.ProductSizes.SizeRelativePosition);
                        Columns.Add(AuditProductSizes.SIZE_CODE).BindValue(_parent._parent.ModifySizeWorkfile.SizeCode);
                        Columns.Add(AuditProductSizes.SELLING_PRICE).BindValue(_parent.ProductSizes.SellingPrice);
                        Columns.Add(AuditProductSizes.VAT_CODE).BindValue(_parent.ProductSizes.VatCode);
                        Columns.Add(AuditProductSizes.EXTRACT_STATUS).BindValue(() => 2);
                        Columns.Add(AuditProductSizes.CREATE_USER).BindValue(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name));
                        Columns.Add(AuditProductSizes.LAST_MODIFY_USER).BindValue(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name));
                        Columns.Add(AuditProductSizes.LAST_MODIFY_DATE).BindValue(() => Date.Now);
                        Columns.Add(AuditProductSizes.LAST_MODIFY_TIME).BindValue(() => Time.Now);
                        Columns.Add(AuditProductSizes.AUDIT_ACTION).BindValue(() => 3);
                        #endregion
                    }
                    
                    /// <summary>Write Audit Product Size</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        Exit(ExitTiming.AfterRow);
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    
                    
                }
            }
            
            /// <summary>Single size price(P#487.8.3)</summary>
            // Last change before Migration: 20/11/2012 10:45:14
            class SingleSizePrice : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Sizes</summary>
                readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { AllowRowLocking = true };
                
                /// <summary>Prod Size Price Workfile</summary>
                readonly Models.ProdSizePriceWorkfile ProdSizePriceWorkfile = new Models.ProdSizePriceWorkfile { ReadOnly = true };
                #endregion
                
                #region Columns
                
                /// <summary>v:re-number size rel pos</summary>
                readonly BoolColumn vReNumberSizeRelPos = new BoolColumn("v:re-number size rel pos");
                #endregion
                
                FindSizeChanges _parent;
                
                
                /// <summary>Single size price(P#487.8.3)</summary>
                public SingleSizePrice(FindSizeChanges parent)
                {
                    _parent = parent;
                    Title = "Single size price";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductSizes;
                    Relations.Add(ProdSizePriceWorkfile, 
                    		ProdSizePriceWorkfile.ProductNumber.IsEqualTo(_parent._parent.PProductNumber), 
                    	ProdSizePriceWorkfile.SortByMOS_PROD_SIZE_PRICE_WRK_X1);
                    
                    Where.Add(ProductSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    OrderBy = ProductSizes.SortBySHP_Product_Sizes_X2;
                    
                    #region Columns
                    
                    Columns.Add(ProductSizes.ProductNumber);
                    Columns.Add(ProductSizes.SizeCode);
                    Columns.Add(ProductSizes.SizeRelativePosition);
                    Columns.Add(ProductSizes.SellingPrice);
                    
                    Columns.Add(ProdSizePriceWorkfile.ProductNumber);
                    Columns.Add(ProdSizePriceWorkfile.SellingPrice);
                    
                    Columns.Add(vReNumberSizeRelPos);
                    #endregion
                }
                
                /// <summary>Single size price</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnStart()
                {
                    Cached<Get1stSizeRelPos>().Run();
                }
                protected override void OnLeaveRow()
                {
                    ProductSizes.SellingPrice.Value = ProdSizePriceWorkfile.SellingPrice;
                    
                    if(vReNumberSizeRelPos)
                    {
                        ProductSizes.SizeRelativePosition.Value = Counter - 1;
                    }
                }
                
                
                
                /// <summary>Get 1st size rel pos(P#487.8.3.1)</summary>
                // Last change before Migration: 20/11/2012 10:45:13
                class Get1stSizeRelPos : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    DynamicSQLEntity sqlEntity;
                    #endregion
                    
                    #region Columns
                    
                    /// <summary>COUNT(*)</summary>
                    readonly NumberColumn COUNT = new NumberColumn("COUNT(*)", "2")
                    {
                    	AllowNull = true
                    };
                    #endregion
                    
                    SingleSizePrice _parent;
                    
                    
                    /// <summary>Get 1st size rel pos(P#487.8.3.1)</summary>
                    public Get1stSizeRelPos(SingleSizePrice parent)
                    {
                        _parent = parent;
                        Title = "Get 1st size rel pos";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        sqlEntity = new DynamicSQLEntity(Models.DataSources.SHP, 
@"select count(*)
  from shp_product_sizes t
 where t.product_number = :1
   and t.size_relative_position = 0
");
                        sqlEntity.AddParameter(_parent._parent._parent.PProductNumber); //:1;
                        sqlEntity.Columns.Add(COUNT);
                        From = sqlEntity;
                        
                        #region Columns
                        
                        Columns.Add(COUNT);
                        #endregion
                    }
                    
                    /// <summary>Get 1st size rel pos</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        Exit(ExitTiming.AfterRow);
                        TransactionScope = TransactionScopes.Task;
                        Activity = Activities.Browse;
                        AllowDelete = false;
                        AllowInsert = false;
                        AllowUpdate = false;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        if(u.Equals(COUNT, 0))
                        {
                            _parent.vReNumberSizeRelPos.Value = true;
                        }
                    }
                    
                    
                }
            }
            
            /// <summary>Write Franch Size Amendments(P#487.8.4)</summary>
            // Last change before Migration: 20/11/2012 10:45:16
            class WriteFranchSizeAmendments : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Franchise Size Amendments</summary>
                readonly Models.FranchiseSizeAmendments FranchiseSizeAmendments = new Models.FranchiseSizeAmendments { AllowRowLocking = true };
                #endregion
                
                FindSizeChanges _parent;
                
                
                /// <summary>Write Franch Size Amendments(P#487.8.4)</summary>
                public WriteFranchSizeAmendments(FindSizeChanges parent)
                {
                    _parent = parent;
                    Title = "Write Franch Size Amendments";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(FranchiseSizeAmendments, RelationType.Insert, 
                    	FranchiseSizeAmendments.SortByMOS_FRA_SIZE_AMEND_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(FranchiseSizeAmendments.LineListNumber).BindValue(_parent.LineListOrder.LineListNumber);
                    Columns.Add(FranchiseSizeAmendments.ProductNumber).BindValue(_parent._parent.PProductNumber);
                    Columns.Add(FranchiseSizeAmendments.SizeRelativePosition).BindValue(_parent.ProductSizes.SizeRelativePosition);
                    Columns.Add(FranchiseSizeAmendments.AuditVersion).BindValue(() => u.If(_parent.RCAuditRecordFound, _parent.FranchiseSizeAmendments.AuditVersion + 1, 0));
                    Columns.Add(FranchiseSizeAmendments.SizeCode).BindValue(_parent.ModifySizeWorkfile.SizeCode);
                    Columns.Add(FranchiseSizeAmendments.CreateUser).BindValue(() => u.Trim(u.Upper(ENV.Security.UserManager.CurrentUser.Name)));
                    Columns.Add(FranchiseSizeAmendments.CreateDate).BindValue(() => Date.Now);
                    Columns.Add(FranchiseSizeAmendments.CreateTime).BindValue(() => Time.Now);
                    #endregion
                }
                
                /// <summary>Write Franch Size Amendments</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                
                
            }
        }
        
        /// <summary>Find Colour Changes(P#487.9)</summary>
        // Last change before Migration: 21/05/2013 09:44:12
        internal class FindColourChanges : Mos.BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>Modify Colour Workfile</summary>
            readonly Models.ModifyColourWorkfile ModifyColourWorkfile = new Models.ModifyColourWorkfile { ReadOnly = true };
            
            /// <summary>Line List Order</summary>
            readonly Models.LineListOrder LineListOrder = new Models.LineListOrder { ReadOnly = true };
            
            /// <summary>Product Colours</summary>
            readonly Models.ProductColours ProductColours = new Models.ProductColours { ReadOnly = true };
            
            /// <summary>Franchise Colour Amendments</summary>
            readonly Models.FranchiseColourAmendments FranchiseColourAmendments = new Models.FranchiseColourAmendments { ReadOnly = true };
            
            /// <summary>MOS_FRA_ORDER_PACKS</summary>
            readonly Models.MOS_FRA_ORDER_PACKS MOS_FRA_ORDER_PACKS = new Models.MOS_FRA_ORDER_PACKS { ReadOnly = true };
            
            /// <summary>Colour</summary>
            readonly Models.Colour Colour = new Models.Colour { ReadOnly = true };
            #endregion
            
            #region Columns
            
            /// <summary>RC:On Order Lot Item</summary>
            readonly BoolColumn RCOnOrderLotItem = new BoolColumn("RC:On Order Lot Item");
            
            /// <summary>RC:On SS Item Price</summary>
            readonly BoolColumn RCOnSSItemPrice = new BoolColumn("RC:On SS Item Price");
            
            /// <summary>RC:On Substitutes</summary>
            readonly BoolColumn RCOnSubstitutes = new BoolColumn("RC:On Substitutes");
            
            /// <summary>RC:On Option Grade Sets</summary>
            readonly BoolColumn RCOnOptionGradeSets = new BoolColumn("RC:On Option Grade Sets");
            
            /// <summary>RC:On Pack Allocs</summary>
            readonly BoolColumn RCOnPackAllocs = new BoolColumn("RC:On Pack Allocs");
            
            /// <summary>RC:On Web Selected Colours</summary>
            readonly BoolColumn RCOnWebSelectedColours = new BoolColumn("RC:On Web Selected Colours");
            
            /// <summary>RC:On Web Selected Sizes</summary>
            readonly BoolColumn RCOnWebSelectedSizes = new BoolColumn("RC:On Web Selected Sizes");
            
            /// <summary>RC:On Option Comments</summary>
            readonly BoolColumn RCOnOptionComments = new BoolColumn("RC:On Option Comments");
            
            /// <summary>RC:On Web Pack Shots</summary>
            readonly BoolColumn RCOnWebPackShots = new BoolColumn("RC:On Web Pack Shots");
            
            /// <summary>RC:On Web Option Order</summary>
            readonly BoolColumn RCOnWebOptionOrder = new BoolColumn("RC:On Web Option Order");
            
            /// <summary>RC:On Web Item Order</summary>
            readonly BoolColumn RCOnWebItemOrder = new BoolColumn("RC:On Web Item Order");
            
            /// <summary>RC:On Web Product Status</summary>
            readonly BoolColumn RCOnWebProductStatus = new BoolColumn("RC:On Web Product Status");
            
            /// <summary>RC:On Option Attributes</summary>
            readonly BoolColumn RCOnOptionAttributes = new BoolColumn("RC:On Option Attributes");
            
            /// <summary>RC:On Story Options</summary>
            readonly BoolColumn RCOnStoryOptions = new BoolColumn("RC:On Story Options");
            
            /// <summary>RC:On Product Cost</summary>
            readonly BoolColumn RCOnProductCost = new BoolColumn("RC:On Product Cost");
            
            /// <summary>RC:On Program Option Grade</summary>
            readonly BoolColumn RCOnProgramOptionGrade = new BoolColumn("RC:On Program Option Grade");
            
            /// <summary>RC:On Packs Makeup</summary>
            readonly BoolColumn RCOnPacksMakeup = new BoolColumn("RC:On Packs Makeup");
            
            /// <summary>RC:On Franch  Packs Makeup</summary>
            readonly BoolColumn RCOnFranchPacksMakeup = new BoolColumn("RC:On Franch  Packs Makeup");
            
            /// <summary>RC:On Models Detail</summary>
            readonly BoolColumn RCOnModelsDetail = new BoolColumn("RC:On Models Detail");
            
            /// <summary>RC:On Ref Tcodes</summary>
            readonly BoolColumn RCOnRefTcodes = new BoolColumn("RC:On Ref Tcodes");
            
            /// <summary>RC:On Ref Tilprc</summary>
            readonly BoolColumn RCOnRefTilprc = new BoolColumn("RC:On Ref Tilprc");
            
            /// <summary>RC:On po2060 Item Extract</summary>
            readonly BoolColumn RCOnPo2060ItemExtract = new BoolColumn("RC:On po2060 Item Extract");
            
            /// <summary>RC:On po2060 Option Extract</summary>
            readonly BoolColumn RCOnPo2060OptionExtract = new BoolColumn("RC:On po2060 Option Extract");
            
            /// <summary>RC:On Web Photo Detail</summary>
            readonly BoolColumn RCOnWebPhotoDetail = new BoolColumn("RC:On Web Photo Detail");
            
            /// <summary>RC:On Web Image TBlob</summary>
            readonly BoolColumn RCOnWebImageTBlob = new BoolColumn("RC:On Web Image TBlob");
            
            /// <summary>RC:On Web Image SBlob</summary>
            readonly BoolColumn RCOnWebImageSBlob = new BoolColumn("RC:On Web Image SBlob");
            
            /// <summary>RC:On Web Image MBlob</summary>
            readonly BoolColumn RCOnWebImageMBlob = new BoolColumn("RC:On Web Image MBlob");
            
            /// <summary>RC:On Web Image LBlob</summary>
            readonly BoolColumn RCOnWebImageLBlob = new BoolColumn("RC:On Web Image LBlob");
            
            /// <summary>RC:On Web Image Blob</summary>
            readonly BoolColumn RCOnWebImageBlob = new BoolColumn("RC:On Web Image Blob");
            
            /// <summary>RC:On po2140 Orders</summary>
            readonly BoolColumn RCOnPo2140Orders = new BoolColumn("RC:On po2140 Orders");
            
            /// <summary>RC:On po2140 Orders Packs</summary>
            readonly BoolColumn RCOnPo2140OrdersPacks = new BoolColumn("RC:On po2140 Orders Packs");
            
            /// <summary>RC:On po2140 Packs Makeup</summary>
            readonly BoolColumn RCOnPo2140PacksMakeup = new BoolColumn("RC:On po2140 Packs Makeup");
            
            /// <summary>RC:On SS Line Monitor Extract</summary>
            readonly BoolColumn RCOnSSLineMonitorExtract = new BoolColumn("RC:On SS Line Monitor Extract");
            
            /// <summary>RC:On SS Line Monitor Plan</summary>
            readonly BoolColumn RCOnSSLineMonitorPlan = new BoolColumn("RC:On SS Line Monitor Plan");
            
            /// <summary>RC:On ALC Pack Allocs</summary>
            readonly BoolColumn RCOnALCPackAllocs = new BoolColumn("RC:On ALC Pack Allocs");
            
            /// <summary>RC:product on line list</summary>
            readonly BoolColumn RCProductOnLineList = new BoolColumn("RC:product on line list");
            
            /// <summary>RC:audit record found</summary>
            readonly BoolColumn RCAuditRecordFound = new BoolColumn("RC:audit record found");
            
            /// <summary>RC: order found</summary>
            readonly BoolColumn RCOrderFound = new BoolColumn("RC: order found");
            
            /// <summary>RC:changed to a valid colour</summary>
            readonly BoolColumn RCChangedToAValidColour = new BoolColumn("RC:changed to a valid colour");
            #endregion
            
            MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Find Colour Changes(P#487.9)</summary>
            public FindColourChanges(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Find Colour Changes";
                InitializeDataView();
                var ModifyColourWorkfileColourCodeGroup = Groups.Add(ModifyColourWorkfile.ColourCode);
                ModifyColourWorkfileColourCodeGroup.Leave += ModifyColourWorkfileColourCodeGroup_Leave;
            }
            void InitializeDataView()
            {
                From = ModifyColourWorkfile;
                Relations.Add(LineListOrder, 
                		LineListOrder.ProductNumber.IsEqualTo(_parent.PProductNumber), 
                	LineListOrder.SortByMOS_FRA_LINE_LIST_ORDER_X1);
                
                Relations.Add(ProductColours, 
                		ProductColours.ProductNumber.IsEqualTo(_parent.PProductNumber).And(
                		ProductColours.ColourCode.IsEqualTo(ModifyColourWorkfile.OriginalColour)), 
                	ProductColours.SortBySHP_Product_Colours_X1);
                
                Relations.Add(FranchiseColourAmendments, 
                		FranchiseColourAmendments.LineListNumber.IsEqualTo(LineListOrder.LineListNumber).And(
                		FranchiseColourAmendments.ProductNumber.IsEqualTo(_parent.PProductNumber)).And(
                		FranchiseColourAmendments.ColourRelativePosition.IsEqualTo(ProductColours.ColourRelativePosition)), 
                	FranchiseColourAmendments.SortByMOS_FRA_COL_AMEND_X1);
                Relations[FranchiseColourAmendments].OrderBy.Reversed = true;
                
                Relations.Add(MOS_FRA_ORDER_PACKS, 
                		MOS_FRA_ORDER_PACKS.PRODUCT_NUMBER.IsEqualTo(_parent.PProductNumber), 
                	MOS_FRA_ORDER_PACKS.SortByMOS_FRA_ORDER_PACKS_X1);
                
                Relations.Add(Colour, 
                		Colour.ColourCode.IsEqualTo(ModifyColourWorkfile.ColourCode), 
                	Colour.SortByREF_Colour_X1);
                
                Where.Add(ModifyColourWorkfile.ProductNumber.IsEqualTo(_parent.PProductNumber));
                OrderBy = ModifyColourWorkfile.SortByMOS_MOD_COL_SIZE_WRK_X1;
                
                #region Columns
                
                Columns.Add(ModifyColourWorkfile.ProductNumber);
                Columns.Add(ModifyColourWorkfile.ColourCode);
                Columns.Add(ModifyColourWorkfile.ColourChanged);
                Columns.Add(ModifyColourWorkfile.OriginalColour);
                
                Columns.Add(RCOnOrderLotItem);
                Columns.Add(RCOnSSItemPrice);
                Columns.Add(RCOnSubstitutes);
                Columns.Add(RCOnOptionGradeSets);
                Columns.Add(RCOnPackAllocs);
                Columns.Add(RCOnWebSelectedColours);
                Columns.Add(RCOnWebSelectedSizes);
                Columns.Add(RCOnOptionComments);
                Columns.Add(RCOnWebPackShots);
                Columns.Add(RCOnWebOptionOrder);
                Columns.Add(RCOnWebItemOrder);
                Columns.Add(RCOnWebProductStatus);
                Columns.Add(RCOnOptionAttributes);
                Columns.Add(RCOnStoryOptions);
                Columns.Add(RCOnProductCost);
                Columns.Add(RCOnProgramOptionGrade);
                Columns.Add(RCOnPacksMakeup);
                Columns.Add(RCOnFranchPacksMakeup);
                Columns.Add(RCOnModelsDetail);
                Columns.Add(RCOnRefTcodes);
                Columns.Add(RCOnRefTilprc);
                Columns.Add(RCOnPo2060ItemExtract);
                Columns.Add(RCOnPo2060OptionExtract);
                Columns.Add(RCOnWebPhotoDetail);
                Columns.Add(RCOnWebImageTBlob);
                Columns.Add(RCOnWebImageSBlob);
                Columns.Add(RCOnWebImageMBlob);
                Columns.Add(RCOnWebImageLBlob);
                Columns.Add(RCOnWebImageBlob);
                Columns.Add(RCOnPo2140Orders);
                Columns.Add(RCOnPo2140OrdersPacks);
                Columns.Add(RCOnPo2140PacksMakeup);
                Columns.Add(RCOnSSLineMonitorExtract);
                Columns.Add(RCOnSSLineMonitorPlan);
                Columns.Add(RCOnALCPackAllocs);
                
                Columns.Add(RCProductOnLineList);
                Relations[LineListOrder].NotifyRowWasFoundTo(RCProductOnLineList);
                Columns.Add(LineListOrder.MackaysOrderNumber);
                Columns.Add(LineListOrder.LotNumber);
                Columns.Add(LineListOrder.LineListNumber);
                Columns.Add(LineListOrder.ProductNumber);
                
                Columns.Add(ProductColours.ProductNumber);
                Columns.Add(ProductColours.ColourCode);
                Columns.Add(ProductColours.ColourRelativePosition);
                
                Columns.Add(RCAuditRecordFound);
                Relations[FranchiseColourAmendments].NotifyRowWasFoundTo(RCAuditRecordFound);
                Columns.Add(FranchiseColourAmendments.LineListNumber);
                Columns.Add(FranchiseColourAmendments.ProductNumber);
                Columns.Add(FranchiseColourAmendments.ColourRelativePosition);
                Columns.Add(FranchiseColourAmendments.AuditVersion);
                
                Columns.Add(RCOrderFound);
                Relations[MOS_FRA_ORDER_PACKS].NotifyRowWasFoundTo(RCOrderFound);
                Columns.Add(MOS_FRA_ORDER_PACKS.FRANCHISEE_ORDER_NUMBER);
                Columns.Add(MOS_FRA_ORDER_PACKS.MACKAYS_ORDER_NUMBER);
                Columns.Add(MOS_FRA_ORDER_PACKS.LOT_NUMBER);
                Columns.Add(MOS_FRA_ORDER_PACKS.PRODUCT_NUMBER);
                Columns.Add(MOS_FRA_ORDER_PACKS.PACK_CODE);
                
                Columns.Add(RCChangedToAValidColour);
                Relations[Colour].NotifyRowWasFoundTo(RCChangedToAValidColour);
                Columns.Add(Colour.ColourCode);
                #endregion
            }
            
            /// <summary>Find Colour Changes</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                RowLocking = LockingStrategy.OnRowLoading;
                TransactionScope = TransactionScopes.Task;
                AllowUserAbort = true;
                if(NewViewRequired)
                {
                    View = ()=> new Views.MaintModColSizePo2071PleaseWait1(this);
                }
            }
            void ModifyColourWorkfileColourCodeGroup_Leave()
            {
                if(ModifyColourWorkfile.ColourChanged && RCChangedToAValidColour)
                {
                    Cached<ReadProductColour>().Run();
                    // write franchise amendment before product colours are amended
                    if(RCProductOnLineList && RCOrderFound)
                    {
                        Cached<WriteFranchColourAmendments>().Run();
                    }
                    Cached<WriteProdColour>().Run();
                    Cached<WriteProdColSize>().Run();
                    if(u.Delay(5))
                    {
                        Cached<CheckTablesViaMagic>().Run();
                    }
                    Cached<RefreshOrderLotItemOption>().Run();
                    Cached<UpdatePlaceholder>().Run();
                }
            }
            
            
            
            /// <summary>Write ProdColSize(P#487.9.1)</summary>
            // Last change before Migration: 20/11/2012 10:43:40
            class WriteProdColSize : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Colour Size</summary>
                readonly Models.ProductColourSize ProductColourSize = new Models.ProductColourSize { AllowRowLocking = true };
                #endregion
                
                FindColourChanges _parent;
                
                
                /// <summary>Write ProdColSize(P#487.9.1)</summary>
                public WriteProdColSize(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Write ProdColSize";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductColourSize;
                    Where.Add(ProductColourSize.ProductNumber.IsEqualTo(_parent.ModifyColourWorkfile.ProductNumber));
                    Where.Add(ProductColourSize.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour));
                    OrderBy = ProductColourSize.SortByREF_PrdColSz_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductColourSize.ProductNumber);
                    Columns.Add(ProductColourSize.ColourCode);
                    #endregion
                }
                
                /// <summary>Write ProdColSize</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    // Product Colour Size
                    ProductColourSize.ColourCode.Value = _parent.ModifyColourWorkfile.ColourCode;
                }
                
                
            }
            
            /// <summary>Write ProdColour(P#487.9.2)</summary>
            // Last change before Migration: 20/11/2012 10:43:44
            class WriteProdColour : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Colours</summary>
                readonly Models.ProductColours ProductColours = new Models.ProductColours { AllowRowLocking = true };
                #endregion
                
                FindColourChanges _parent;
                
                
                /// <summary>Write ProdColour(P#487.9.2)</summary>
                public WriteProdColour(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Write ProdColour";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(ProductColours, RelationType.InsertIfNotFound, 
                    		ProductColours.ProductNumber.BindEqualTo(_parent._parent.PProductNumber).And(
                    		ProductColours.ColourCode.BindEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	ProductColours.SortBySHP_Product_Colours_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(ProductColours.ProductNumber);
                    Columns.Add(ProductColours.ColourCode);
                    Columns.Add(ProductColours.LastUpdateUsrID);
                    Columns.Add(ProductColours.LastUpdateDate);
                    Columns.Add(ProductColours.LastUpdateTime);
                    #endregion
                }
                
                /// <summary>Write ProdColour</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    ProductColours.ColourCode.Value = _parent.ModifyColourWorkfile.ColourCode;
                    ProductColours.LastUpdateUsrID.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                    ProductColours.LastUpdateDate.Value = Date.Now;
                    ProductColours.LastUpdateTime.Value = Time.Now;
                }
                
                
            }
            
            /// <summary>Check tables via magic(P#487.9.3)</summary>
            // Last change before Migration: 23/11/2012 14:32:19
            class CheckTablesViaMagic : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Order Lot Item</summary>
                readonly Models.OrderLotItem OrderLotItem = new Models.OrderLotItem { ReadOnly = true };
                
                /// <summary>Intake Item Week</summary>
                readonly Models.IntakeItemWeek IntakeItemWeek = new Models.IntakeItemWeek { ReadOnly = true };
                
                /// <summary>Price File</summary>
                readonly Models.PriceFile PriceFile = new Models.PriceFile { ReadOnly = true };
                
                /// <summary>Substitutes</summary>
                readonly Models.Substitutes Substitutes = new Models.Substitutes { ReadOnly = true };
                
                /// <summary>Option Grade Set</summary>
                readonly Models.OptionGradeSet OptionGradeSet = new Models.OptionGradeSet { ReadOnly = true };
                
                /// <summary>ALC_Pack_Allocs</summary>
                readonly Models.ALC_Pack_Allocs ALC_Pack_Allocs = new Models.ALC_Pack_Allocs { ReadOnly = true };
                
                /// <summary>Web Selected Colours</summary>
                readonly Models.WebSelectedColours WebSelectedColours = new Models.WebSelectedColours { ReadOnly = true };
                
                /// <summary>Web Selected Sizes</summary>
                readonly Models.WebSelectedSizes WebSelectedSizes = new Models.WebSelectedSizes { ReadOnly = true };
                
                /// <summary>ALC_Option_comments</summary>
                readonly Models.ALC_Option_comments ALC_Option_comments = new Models.ALC_Option_comments { ReadOnly = true };
                
                /// <summary>Web Pack Shots</summary>
                readonly Models.WebPackShots WebPackShots = new Models.WebPackShots { ReadOnly = true };
                
                /// <summary>Web Option Order</summary>
                readonly Models.WebOptionOrder WebOptionOrder = new Models.WebOptionOrder { ReadOnly = true };
                
                /// <summary>Web Item Order</summary>
                readonly Models.WebItemOrder WebItemOrder = new Models.WebItemOrder { ReadOnly = true };
                
                /// <summary>Web Test Selected Colours</summary>
                readonly Models.WebTestSelectedColours WebTestSelectedColours = new Models.WebTestSelectedColours { ReadOnly = true };
                
                /// <summary>Web Test Selected Sizes</summary>
                readonly Models.WebTestSelectedSizes WebTestSelectedSizes = new Models.WebTestSelectedSizes { ReadOnly = true };
                
                /// <summary>Web Product Status</summary>
                readonly Models.WebProductStatus WebProductStatus = new Models.WebProductStatus { ReadOnly = true };
                
                /// <summary>Option Attributes</summary>
                readonly Models.OptionAttributes OptionAttributes = new Models.OptionAttributes { ReadOnly = true };
                
                /// <summary>Story Options</summary>
                readonly Models.StoryOptions StoryOptions = new Models.StoryOptions { ReadOnly = true };
                
                /// <summary>REF_PRODCOST</summary>
                readonly Models.REF_PRODCOST REF_PRODCOST = new Models.REF_PRODCOST { ReadOnly = true };
                
                /// <summary>Programs Option Gradeset</summary>
                readonly Models.ProgramsOptionGradeset ProgramsOptionGradeset = new Models.ProgramsOptionGradeset { ReadOnly = true };
                
                /// <summary>Packs Make Up</summary>
                readonly Models.PacksMakeUp PacksMakeUp = new Models.PacksMakeUp { ReadOnly = true };
                
                /// <summary>Franchisee Pack Makeup</summary>
                readonly Models.FranchiseePackMakeup FranchiseePackMakeup = new Models.FranchiseePackMakeup { Cached = false, ReadOnly = true };
                
                /// <summary>Models Detail</summary>
                readonly Models.ModelsDetail ModelsDetail = new Models.ModelsDetail { ReadOnly = true };
                
                /// <summary>Tcodes</summary>
                readonly Models.Tcodes Tcodes = new Models.Tcodes { ReadOnly = true };
                
                /// <summary>Till Price</summary>
                readonly Models.TillPrice TillPrice = new Models.TillPrice { ReadOnly = true };
                
                /// <summary>Web Selected Sizes</summary>
                readonly Models.WebSelectedSizes WebSelectedSizes1 = new Models.WebSelectedSizes { ReadOnly = true };
                
                /// <summary>MOS_po2060_Item_Extract</summary>
                readonly Models.MOS_po2060_Item_Extract MOS_po2060_Item_Extract = new Models.MOS_po2060_Item_Extract { AllowRowLocking = true };
                
                /// <summary>MOS_po2060_Option_Extract</summary>
                readonly Models.MOS_po2060_Option_Extract MOS_po2060_Option_Extract = new Models.MOS_po2060_Option_Extract { AllowRowLocking = true };
                
                /// <summary>Web Photo Detail</summary>
                readonly Models.WebPhotoDetail WebPhotoDetail = new Models.WebPhotoDetail { AllowRowLocking = true };
                
                /// <summary>MOS_Web_Image_TBlob</summary>
                readonly Models.MOS_Web_Image_TBlob MOS_Web_Image_TBlob = new Models.MOS_Web_Image_TBlob { AllowRowLocking = true };
                
                /// <summary>MOS_Web_Image_SBlob</summary>
                readonly Models.MOS_Web_Image_SBlob MOS_Web_Image_SBlob = new Models.MOS_Web_Image_SBlob { AllowRowLocking = true };
                
                /// <summary>MOS_Web_Image_MBlob</summary>
                readonly Models.MOS_Web_Image_MBlob MOS_Web_Image_MBlob = new Models.MOS_Web_Image_MBlob { AllowRowLocking = true };
                
                /// <summary>MOS_Web_Image_LBlob</summary>
                readonly Models.MOS_Web_Image_LBlob MOS_Web_Image_LBlob = new Models.MOS_Web_Image_LBlob { AllowRowLocking = true };
                
                /// <summary>MOS_Web_Image_Blob</summary>
                readonly Models.MOS_Web_Image_Blob MOS_Web_Image_Blob = new Models.MOS_Web_Image_Blob { AllowRowLocking = true };
                
                /// <summary>Mos po2140 Orders</summary>
                readonly Models.MosPo2140Orders MosPo2140Orders = new Models.MosPo2140Orders { AllowRowLocking = true };
                
                /// <summary>Mos po2140 Orders Packs</summary>
                readonly Models.MosPo2140OrdersPacks MosPo2140OrdersPacks = new Models.MosPo2140OrdersPacks { AllowRowLocking = true };
                
                /// <summary>MOS_PO2140_PACKS_MAKEUP</summary>
                readonly Models.MOS_PO2140_PACKS_MAKEUP MOS_PO2140_PACKS_MAKEUP = new Models.MOS_PO2140_PACKS_MAKEUP { AllowRowLocking = true };
                
                /// <summary>SS_LINE_MONITOR_EXT</summary>
                readonly Models.SS_LINE_MONITOR_EXT SS_LINE_MONITOR_EXT = new Models.SS_LINE_MONITOR_EXT { AllowRowLocking = true };
                
                /// <summary>SS_LINE_MONITOR_PLAN</summary>
                readonly Models.SS_LINE_MONITOR_PLAN SS_LINE_MONITOR_PLAN = new Models.SS_LINE_MONITOR_PLAN { AllowRowLocking = true };
                
                /// <summary>ALC_Pack_Allocs</summary>
                readonly Models.ALC_Pack_Allocs ALC_Pack_Allocs1 = new Models.ALC_Pack_Allocs { ReadOnly = true };
                #endregion
                
                FindColourChanges _parent;
                
                
                /// <summary>Check tables via magic(P#487.9.3)</summary>
                public CheckTablesViaMagic(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Check tables via magic";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(OrderLotItem, 
                    		OrderLotItem.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		OrderLotItem.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	OrderLotItem.SortByMOS_ORDER_LOT_ITEM_X2);
                    
                    Relations.Add(IntakeItemWeek, 
                    		IntakeItemWeek.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		IntakeItemWeek.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	IntakeItemWeek.SortByMOS_Intake_Item_Week_X1);
                    
                    Relations.Add(PriceFile, 
                    		PriceFile.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		PriceFile.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	PriceFile.SortBySS_ITEM_PRICE_X1);
                    
                    Relations.Add(Substitutes, 
                    		Substitutes.PRIMARY_PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		Substitutes.PRIMARY_COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	Substitutes.SortByALC_SUBSTITUTE_ITEMS_X1);
                    
                    Relations.Add(OptionGradeSet, 
                    		OptionGradeSet.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		OptionGradeSet.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	OptionGradeSet.SortByALC_OPTION_GRADE_SET_X1);
                    
                    Relations.Add(ALC_Pack_Allocs, 
                    		ALC_Pack_Allocs.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ALC_Pack_Allocs.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	ALC_Pack_Allocs.SortByALC_Pack_Allocs_X1);
                    Relations[ALC_Pack_Allocs].BindEnabled(()=> false);
                    
                    Relations.Add(WebSelectedColours, 
                    		WebSelectedColours.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebSelectedColours.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebSelectedColours.SortByMOS_Web_Selected_Colours_X1);
                    
                    Relations.Add(WebSelectedSizes, 
                    		WebSelectedSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebSelectedSizes.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebSelectedSizes.SortByMOS_Web_Selected_Sizes_X1);
                    
                    Relations.Add(ALC_Option_comments, 
                    		ALC_Option_comments.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ALC_Option_comments.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	ALC_Option_comments.SortByALC_Option_Comments_X1);
                    
                    Relations.Add(WebPackShots, 
                    		WebPackShots.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebPackShots.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebPackShots.SortByMOS_Web_PackShots_X1);
                    
                    Relations.Add(WebOptionOrder, 
                    		WebOptionOrder.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebOptionOrder.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebOptionOrder.SortByMOS_Web_Option_Order_X1);
                    
                    Relations.Add(WebItemOrder, 
                    		WebItemOrder.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebItemOrder.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebItemOrder.SortByMOS_Web_Item_Order_X1);
                    
                    Relations.Add(WebTestSelectedColours, 
                    		WebTestSelectedColours.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebTestSelectedColours.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebTestSelectedColours.SortByMOS_WebTst_Selectd_Colours_X1);
                    
                    Relations.Add(WebTestSelectedSizes, 
                    		WebTestSelectedSizes.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebTestSelectedSizes.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebTestSelectedSizes.SortByMOS_WebTst_Selected_Sizes_X1);
                    
                    Relations.Add(WebProductStatus, 
                    		WebProductStatus.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebProductStatus.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebProductStatus.SortByMOS_Web_Prod_Status_X1);
                    
                    Relations.Add(OptionAttributes, 
                    		OptionAttributes.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		OptionAttributes.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	OptionAttributes.SortByREF_OPT_ATT_X3);
                    
                    Relations.Add(StoryOptions, 
                    		StoryOptions.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		StoryOptions.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	StoryOptions.SortByALC_STORY_OPTIONS_X2);
                    
                    Relations.Add(REF_PRODCOST, 
                    		REF_PRODCOST.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		REF_PRODCOST.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	REF_PRODCOST.SortByREF_PRODCOST_X1);
                    
                    Relations.Add(ProgramsOptionGradeset, 
                    		ProgramsOptionGradeset.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ProgramsOptionGradeset.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	ProgramsOptionGradeset.SortByALC_PROG_OPTION_GRADESET_X2);
                    
                    Relations.Add(PacksMakeUp, 
                    		PacksMakeUp.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		PacksMakeUp.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	PacksMakeUp.SortByWAR_Pack_MakeUp_X1);
                    
                    Relations.Add(FranchiseePackMakeup, 
                    		FranchiseePackMakeup.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		FranchiseePackMakeup.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	FranchiseePackMakeup.SortByMOS_FRA_PACK_MAKEUP_X1);
                    
                    Relations.Add(ModelsDetail, 
                    		ModelsDetail.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ModelsDetail.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	ModelsDetail.SortByPRC_MODELS_DETAIL_X1);
                    
                    Relations.Add(Tcodes, 
                    		Tcodes.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		Tcodes.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	Tcodes.SortByREF_TCODES_X2);
                    
                    Relations.Add(TillPrice, 
                    		TillPrice.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		TillPrice.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	TillPrice.SortByREF_TilPrc_X2);
                    
                    Relations.Add(WebSelectedSizes1, 
                    		WebSelectedSizes1.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebSelectedSizes1.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebSelectedSizes1.SortByMOS_Web_Selected_Sizes_X1);
                    
                    Relations.Add(MOS_po2060_Item_Extract, 
                    		MOS_po2060_Item_Extract.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_po2060_Item_Extract.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_po2060_Item_Extract.SortByMOS_PO2060_ITEM_EXTRACT_X1);
                    
                    Relations.Add(MOS_po2060_Option_Extract, 
                    		MOS_po2060_Option_Extract.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_po2060_Option_Extract.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_po2060_Option_Extract.SortByMOS_PO2060_OPTION_EXTRACT_X1);
                    
                    Relations.Add(WebPhotoDetail, 
                    		WebPhotoDetail.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		WebPhotoDetail.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	WebPhotoDetail.SortByMOS_Web_Photo_Detail_X2);
                    
                    Relations.Add(MOS_Web_Image_TBlob, 
                    		MOS_Web_Image_TBlob.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_Web_Image_TBlob.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_Web_Image_TBlob.SortByMOS_WEB_IMAGE_TBLOB_X1);
                    
                    Relations.Add(MOS_Web_Image_SBlob, 
                    		MOS_Web_Image_SBlob.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_Web_Image_SBlob.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_Web_Image_SBlob.SortByMOS_WEB_IMAGE_SBLOB_X1);
                    
                    Relations.Add(MOS_Web_Image_MBlob, 
                    		MOS_Web_Image_MBlob.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_Web_Image_MBlob.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_Web_Image_MBlob.SortByMOS_WEB_IMAGE_MBLOB_X1);
                    
                    Relations.Add(MOS_Web_Image_LBlob, 
                    		MOS_Web_Image_LBlob.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_Web_Image_LBlob.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_Web_Image_LBlob.SortByMOS_WEB_IMAGE_LBLOB_X1);
                    
                    Relations.Add(MOS_Web_Image_Blob, 
                    		MOS_Web_Image_Blob.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		MOS_Web_Image_Blob.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MOS_Web_Image_Blob.SortByMOS_WEB_IMAGE_BLOB_X1);
                    
                    Relations.Add(MosPo2140Orders, 
                    		MosPo2140Orders.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour).And(
                    		MosPo2140Orders.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber)), 
                    	MosPo2140Orders.SortByMOS_PO2140_ORDERS_X1);
                    
                    Relations.Add(MosPo2140OrdersPacks, 
                    		MosPo2140OrdersPacks.OrderNumber.IsEqualTo(MosPo2140Orders.ORDER_NUMBER).And(
                    		MosPo2140OrdersPacks.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	MosPo2140OrdersPacks.SortByMOS_po2140_Orders_Packs_X1);
                    
                    Relations.Add(MOS_PO2140_PACKS_MAKEUP, 
                    		MOS_PO2140_PACKS_MAKEUP.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour).And(
                    		MOS_PO2140_PACKS_MAKEUP.PRODUCT1.IsEqualTo(_parent._parent.PProductNumber)), 
                    	MOS_PO2140_PACKS_MAKEUP.SortByMOS_PO2140_PACKS_MAKEUP_X1);
                    
                    Relations.Add(SS_LINE_MONITOR_EXT, 
                    		SS_LINE_MONITOR_EXT.PRODUCT_NUMBER.IsEqualTo(_parent._parent.PProductNumber).And(
                    		SS_LINE_MONITOR_EXT.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	SS_LINE_MONITOR_EXT.SortBySS_LINE_MONITOR_EXT_X1);
                    
                    Relations.Add(SS_LINE_MONITOR_PLAN, 
                    		SS_LINE_MONITOR_PLAN.MASTER_PRODUCT.IsEqualTo(_parent._parent.PProductNumber).And(
                    		SS_LINE_MONITOR_PLAN.COLOUR_CODE.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	SS_LINE_MONITOR_PLAN.SortBySS_LINE_MONITOR_PLAN_X1);
                    
                    Relations.Add(ALC_Pack_Allocs1, 
                    		ALC_Pack_Allocs1.ProductNumber.IsEqualTo(_parent._parent.PProductNumber).And(
                    		ALC_Pack_Allocs1.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour)), 
                    	ALC_Pack_Allocs1.SortByALC_Pack_Allocs_X1);
                    
                    
                    #region Columns
                    
                    Relations[OrderLotItem].NotifyRowWasFoundTo(_parent.RCOnOrderLotItem);
                    Columns.Add(OrderLotItem.PRODUCT_NUMBER);
                    Columns.Add(OrderLotItem.COLOUR_CODE);
                    Columns.Add(OrderLotItem.SIZE_CODE);
                    Columns.Add(OrderLotItem.DUE_WEEK);
                    Columns.Add(OrderLotItem.ORDER_NUMBER);
                    Columns.Add(OrderLotItem.LOT_NUMBER);
                    
                    Columns.Add(IntakeItemWeek.ProductNumber);
                    Columns.Add(IntakeItemWeek.ColourCode);
                    Columns.Add(IntakeItemWeek.SizeCode);
                    Columns.Add(IntakeItemWeek.WRCWeek);
                    Columns.Add(IntakeItemWeek.WRCDate);
                    Columns.Add(IntakeItemWeek.OrderNumber);
                    Columns.Add(IntakeItemWeek.LotNumber);
                    Columns.Add(IntakeItemWeek.WRCNumber);
                    
                    Relations[PriceFile].NotifyRowWasFoundTo(_parent.RCOnSSItemPrice);
                    Columns.Add(PriceFile.PRODUCT_NUMBER);
                    Columns.Add(PriceFile.COLOUR_CODE);
                    Columns.Add(PriceFile.SIZE_CODE);
                    Columns.Add(PriceFile.START_DATETIME);
                    Columns.Add(PriceFile.ZONE);
                    
                    Relations[Substitutes].NotifyRowWasFoundTo(_parent.RCOnSubstitutes);
                    Columns.Add(Substitutes.PRIMARY_PRODUCT_NUMBER);
                    Columns.Add(Substitutes.PRIMARY_COLOUR_CODE);
                    Columns.Add(Substitutes.PRIMARY_SIZE_CODE);
                    Columns.Add(Substitutes.SUBSTITUTED_PRODUCT_NUMBER);
                    Columns.Add(Substitutes.SUBSTITUTED_COLOUR_CODE);
                    Columns.Add(Substitutes.SUBSTITUTED_SIZE_CODE);
                    
                    Relations[OptionGradeSet].NotifyRowWasFoundTo(_parent.RCOnOptionGradeSets);
                    Columns.Add(OptionGradeSet.PRODUCT_NUMBER);
                    Columns.Add(OptionGradeSet.COLOUR_CODE);
                    
                    Relations[ALC_Pack_Allocs].NotifyRowWasFoundTo(_parent.RCOnPackAllocs);
                    Columns.Add(ALC_Pack_Allocs.ProductNumber);
                    Columns.Add(ALC_Pack_Allocs.PackCode);
                    Columns.Add(ALC_Pack_Allocs.ColourCode);
                    
                    Relations[WebSelectedColours].NotifyRowWasFoundTo(_parent.RCOnWebSelectedColours);
                    Columns.Add(WebSelectedColours.ProductNumber);
                    Columns.Add(WebSelectedColours.ColourCode);
                    
                    Relations[WebSelectedSizes].NotifyRowWasFoundTo(_parent.RCOnWebSelectedSizes);
                    Columns.Add(WebSelectedSizes.ProductNumber);
                    Columns.Add(WebSelectedSizes.ColourCode);
                    Columns.Add(WebSelectedSizes.SizeCode);
                    
                    Relations[ALC_Option_comments].NotifyRowWasFoundTo(_parent.RCOnOptionComments);
                    Columns.Add(ALC_Option_comments.PRODUCT_NUMBER);
                    Columns.Add(ALC_Option_comments.COLOUR_CODE);
                    
                    Relations[WebPackShots].NotifyRowWasFoundTo(_parent.RCOnWebPackShots);
                    Columns.Add(WebPackShots.ProductNumber);
                    Columns.Add(WebPackShots.ColourCode);
                    Columns.Add(WebPackShots.PackShotEvent);
                    Columns.Add(WebPackShots.EventDateTime);
                    
                    Relations[WebOptionOrder].NotifyRowWasFoundTo(_parent.RCOnWebOptionOrder);
                    Columns.Add(WebOptionOrder.ProductNumber);
                    Columns.Add(WebOptionOrder.ColourCode);
                    
                    Relations[WebItemOrder].NotifyRowWasFoundTo(_parent.RCOnWebItemOrder);
                    Columns.Add(WebItemOrder.ProductNumber);
                    Columns.Add(WebItemOrder.ColourCode);
                    Columns.Add(WebItemOrder.SizeCode);
                    
                    Columns.Add(WebTestSelectedColours.ProductNumber);
                    Columns.Add(WebTestSelectedColours.ColourCode);
                    
                    Columns.Add(WebTestSelectedSizes.ProductNumber);
                    Columns.Add(WebTestSelectedSizes.ColourCode);
                    Columns.Add(WebTestSelectedSizes.SizeCode);
                    
                    Relations[WebProductStatus].NotifyRowWasFoundTo(_parent.RCOnWebProductStatus);
                    Columns.Add(WebProductStatus.ProductNumber);
                    Columns.Add(WebProductStatus.ColourCode);
                    Columns.Add(WebProductStatus.SizeCode);
                    Columns.Add(WebProductStatus.ProductStatusEvent);
                    Columns.Add(WebProductStatus.EventDateTime);
                    
                    Relations[OptionAttributes].NotifyRowWasFoundTo(_parent.RCOnOptionAttributes);
                    Columns.Add(OptionAttributes.PRODUCT_NUMBER);
                    Columns.Add(OptionAttributes.COLOUR_CODE);
                    Columns.Add(OptionAttributes.ATTRIBUTE_TYPE);
                    Columns.Add(OptionAttributes.ATTRIBUTE_CODE);
                    
                    Relations[StoryOptions].NotifyRowWasFoundTo(_parent.RCOnStoryOptions);
                    Columns.Add(StoryOptions.PRODUCT_NUMBER);
                    Columns.Add(StoryOptions.COLOUR_CODE);
                    Columns.Add(StoryOptions.STORY_CODE);
                    
                    Relations[REF_PRODCOST].NotifyRowWasFoundTo(_parent.RCOnProductCost);
                    Columns.Add(REF_PRODCOST.PRODUCT_NUMBER);
                    Columns.Add(REF_PRODCOST.COLOUR_CODE);
                    Columns.Add(REF_PRODCOST.SIZE_CODE);
                    Columns.Add(REF_PRODCOST.LAST_AMEND_DATE);
                    
                    Relations[ProgramsOptionGradeset].NotifyRowWasFoundTo(_parent.RCOnProgramOptionGrade);
                    Columns.Add(ProgramsOptionGradeset.MAGIC_OR_DSS);
                    Columns.Add(ProgramsOptionGradeset.PROGRAM_ID);
                    Columns.Add(ProgramsOptionGradeset.PRODUCT_NUMBER);
                    Columns.Add(ProgramsOptionGradeset.COLOUR_CODE);
                    Columns.Add(ProgramsOptionGradeset.DSS_DEPARTMENT_CODE);
                    Columns.Add(ProgramsOptionGradeset.DSS_SUB_DEPARTMENT_CODE);
                    Columns.Add(ProgramsOptionGradeset.DSS_SECTION_CODE);
                    Columns.Add(ProgramsOptionGradeset.DSS_RANGE_CODE);
                    Columns.Add(ProgramsOptionGradeset.DSS_SUB_RANGE_CODE);
                    Columns.Add(ProgramsOptionGradeset.GRADE_SET_ID);
                    
                    Relations[PacksMakeUp].NotifyRowWasFoundTo(_parent.RCOnPacksMakeup);
                    Columns.Add(PacksMakeUp.ProductNumber);
                    Columns.Add(PacksMakeUp.PackCode);
                    Columns.Add(PacksMakeUp.ColourCode);
                    Columns.Add(PacksMakeUp.SizeCode);
                    
                    Relations[FranchiseePackMakeup].NotifyRowWasFoundTo(_parent.RCOnFranchPacksMakeup);
                    Columns.Add(FranchiseePackMakeup.ProductNumber);
                    Columns.Add(FranchiseePackMakeup.PackCode);
                    Columns.Add(FranchiseePackMakeup.ColourCode);
                    Columns.Add(FranchiseePackMakeup.SizeCode);
                    
                    Relations[ModelsDetail].NotifyRowWasFoundTo(_parent.RCOnModelsDetail);
                    Columns.Add(ModelsDetail.PRICE_MODEL_ID);
                    Columns.Add(ModelsDetail.RANGE_CONCATENATION);
                    Columns.Add(ModelsDetail.PRODUCT_NUMBER);
                    Columns.Add(ModelsDetail.COLOUR_CODE);
                    Columns.Add(ModelsDetail.SIZE_CODE);
                    
                    Relations[Tcodes].NotifyRowWasFoundTo(_parent.RCOnRefTcodes);
                    Columns.Add(Tcodes.PRODUCT_NUMBER);
                    Columns.Add(Tcodes.COLOUR_CODE);
                    Columns.Add(Tcodes.SIZE_CODE);
                    Columns.Add(Tcodes.TILL_CODE);
                    
                    Relations[TillPrice].NotifyRowWasFoundTo(_parent.RCOnRefTilprc);
                    Columns.Add(TillPrice.ProductNumber);
                    Columns.Add(TillPrice.ColourCode);
                    Columns.Add(TillPrice.SizeCode);
                    Columns.Add(TillPrice.TillCode);
                    
                    Columns.Add(WebSelectedSizes1.ProductNumber);
                    Columns.Add(WebSelectedSizes1.ColourCode);
                    Columns.Add(WebSelectedSizes1.SizeCode);
                    
                    Relations[MOS_po2060_Item_Extract].NotifyRowWasFoundTo(_parent.RCOnPo2060ItemExtract);
                    Columns.Add(MOS_po2060_Item_Extract.PRODUCT_NUMBER);
                    Columns.Add(MOS_po2060_Item_Extract.COLOUR_CODE);
                    Columns.Add(MOS_po2060_Item_Extract.SIZE_CODE);
                    
                    Relations[MOS_po2060_Option_Extract].NotifyRowWasFoundTo(_parent.RCOnPo2060OptionExtract);
                    Columns.Add(MOS_po2060_Option_Extract.PRODUCT_NUMBER);
                    Columns.Add(MOS_po2060_Option_Extract.COLOUR_CODE);
                    
                    Relations[WebPhotoDetail].NotifyRowWasFoundTo(_parent.RCOnWebPhotoDetail);
                    Columns.Add(WebPhotoDetail.ProductNumber);
                    Columns.Add(WebPhotoDetail.ColourCode);
                    Columns.Add(WebPhotoDetail.PhotoType);
                    Columns.Add(WebPhotoDetail.PhotosBatchID);
                    
                    Relations[MOS_Web_Image_TBlob].NotifyRowWasFoundTo(_parent.RCOnWebImageTBlob);
                    Columns.Add(MOS_Web_Image_TBlob.ProductNumber);
                    Columns.Add(MOS_Web_Image_TBlob.ColourCode);
                    Columns.Add(MOS_Web_Image_TBlob.ImageType);
                    Columns.Add(MOS_Web_Image_TBlob.SequenceNo);
                    
                    Relations[MOS_Web_Image_SBlob].NotifyRowWasFoundTo(_parent.RCOnWebImageSBlob);
                    Columns.Add(MOS_Web_Image_SBlob.ProductNumber);
                    Columns.Add(MOS_Web_Image_SBlob.ColourCode);
                    Columns.Add(MOS_Web_Image_SBlob.ImageType);
                    Columns.Add(MOS_Web_Image_SBlob.SequenceNo);
                    
                    Relations[MOS_Web_Image_MBlob].NotifyRowWasFoundTo(_parent.RCOnWebImageMBlob);
                    Columns.Add(MOS_Web_Image_MBlob.ProductNumber);
                    Columns.Add(MOS_Web_Image_MBlob.ColourCode);
                    Columns.Add(MOS_Web_Image_MBlob.ImageType);
                    Columns.Add(MOS_Web_Image_MBlob.SequenceNo);
                    
                    Relations[MOS_Web_Image_LBlob].NotifyRowWasFoundTo(_parent.RCOnWebImageLBlob);
                    Columns.Add(MOS_Web_Image_LBlob.ProductNumber);
                    Columns.Add(MOS_Web_Image_LBlob.ColourCode);
                    Columns.Add(MOS_Web_Image_LBlob.ImageType);
                    Columns.Add(MOS_Web_Image_LBlob.SequenceNo);
                    
                    Relations[MOS_Web_Image_Blob].NotifyRowWasFoundTo(_parent.RCOnWebImageBlob);
                    Columns.Add(MOS_Web_Image_Blob.PRODUCT_NUMBER);
                    Columns.Add(MOS_Web_Image_Blob.COLOUR_CODE);
                    Columns.Add(MOS_Web_Image_Blob.IMAGE_TYPE);
                    Columns.Add(MOS_Web_Image_Blob.SEQUENCE_NO);
                    
                    Relations[MosPo2140Orders].NotifyRowWasFoundTo(_parent.RCOnPo2140Orders);
                    Columns.Add(MosPo2140Orders.ORDER_NUMBER);
                    Columns.Add(MosPo2140Orders.COLOUR_CODE);
                    Columns.Add(MosPo2140Orders.PRODUCT_NUMBER);
                    Columns.Add(MosPo2140Orders.LOT1);
                    
                    Relations[MosPo2140OrdersPacks].NotifyRowWasFoundTo(_parent.RCOnPo2140OrdersPacks);
                    Columns.Add(MosPo2140OrdersPacks.OrderNumber);
                    Columns.Add(MosPo2140OrdersPacks.ColourCode);
                    Columns.Add(MosPo2140OrdersPacks.Lot1);
                    Columns.Add(MosPo2140OrdersPacks.PackCode);
                    
                    Relations[MOS_PO2140_PACKS_MAKEUP].NotifyRowWasFoundTo(_parent.RCOnPo2140PacksMakeup);
                    Columns.Add(MOS_PO2140_PACKS_MAKEUP.ORDER_NUMBER);
                    Columns.Add(MOS_PO2140_PACKS_MAKEUP.COLOUR_CODE);
                    Columns.Add(MOS_PO2140_PACKS_MAKEUP.PACK_CODE);
                    Columns.Add(MOS_PO2140_PACKS_MAKEUP.PRODUCT1);
                    
                    Relations[SS_LINE_MONITOR_EXT].NotifyRowWasFoundTo(_parent.RCOnSSLineMonitorExtract);
                    Columns.Add(SS_LINE_MONITOR_EXT.MASTER_PRODUCT);
                    Columns.Add(SS_LINE_MONITOR_EXT.PRODUCT_NUMBER);
                    Columns.Add(SS_LINE_MONITOR_EXT.COLOUR_CODE);
                    Columns.Add(SS_LINE_MONITOR_EXT.FINANCIAL_WEEK);
                    Columns.Add(SS_LINE_MONITOR_EXT.SUB_RANGE);
                    
                    Relations[SS_LINE_MONITOR_PLAN].NotifyRowWasFoundTo(_parent.RCOnSSLineMonitorPlan);
                    Columns.Add(SS_LINE_MONITOR_PLAN.SUB_RANGE);
                    Columns.Add(SS_LINE_MONITOR_PLAN.MASTER_PRODUCT);
                    Columns.Add(SS_LINE_MONITOR_PLAN.COLOUR_CODE);
                    Columns.Add(SS_LINE_MONITOR_PLAN.FINANCIAL_WEEK);
                    
                    Relations[ALC_Pack_Allocs1].NotifyRowWasFoundTo(_parent.RCOnALCPackAllocs);
                    Columns.Add(ALC_Pack_Allocs1.ProductNumber);
                    Columns.Add(ALC_Pack_Allocs1.PackCode);
                    Columns.Add(ALC_Pack_Allocs1.ColourCode);
                    #endregion
                }
                
                /// <summary>Check tables via magic</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnStart()
                {
                    _parent.RCOnOrderLotItem.Value = false;
                    _parent.RCOnSSItemPrice.Value = false;
                    _parent.RCOnSubstitutes.Value = false;
                    _parent.RCOnOptionGradeSets.Value = false;
                    _parent.RCOnPackAllocs.Value = false;
                    _parent.RCOnWebSelectedColours.Value = false;
                    _parent.RCOnWebSelectedSizes.Value = false;
                    _parent.RCOnOptionComments.Value = false;
                    _parent.RCOnWebPackShots.Value = false;
                    _parent.RCOnWebOptionOrder.Value = false;
                    _parent.RCOnWebItemOrder.Value = false;
                    _parent.RCOnWebProductStatus.Value = false;
                    _parent.RCOnOptionAttributes.Value = false;
                    _parent.RCOnStoryOptions.Value = false;
                    _parent.RCOnProductCost.Value = false;
                    _parent.RCOnProgramOptionGrade.Value = false;
                    _parent.RCOnPacksMakeup.Value = false;
                    _parent.RCOnModelsDetail.Value = false;
                    _parent.RCOnRefTcodes.Value = false;
                    _parent.RCOnRefTilprc.Value = false;
                    _parent.RCOnPo2060ItemExtract.Value = false;
                    _parent.RCOnPo2060OptionExtract.Value = false;
                    _parent.RCOnWebPhotoDetail.Value = false;
                    _parent.RCOnWebImageTBlob.Value = false;
                    _parent.RCOnWebImageSBlob.Value = false;
                    _parent.RCOnWebImageMBlob.Value = false;
                    _parent.RCOnWebImageLBlob.Value = false;
                    _parent.RCOnWebImageBlob.Value = false;
                    _parent.RCOnPo2140Orders.Value = false;
                    _parent.RCOnPo2140OrdersPacks.Value = false;
                    _parent.RCOnPo2140PacksMakeup.Value = false;
                    _parent.RCOnSSLineMonitorExtract.Value = false;
                    _parent.RCOnSSLineMonitorPlan.Value = false;
                    _parent.RCOnALCPackAllocs.Value = false;
                }
                protected override void OnLeaveRow()
                {
                    if(_parent.RCOnOrderLotItem)
                    {
                        Cached<ChangeOrderLotItem>().Run();
                    }
                    if(_parent.RCOnSSItemPrice)
                    {
                        Cached<ChangeSSItemPrice>().Run();
                    }
                    if(_parent.RCOnSubstitutes)
                    {
                        Cached<ChangeSubstitutes>().Run();
                    }
                    if(_parent.RCOnPackAllocs)
                    {
                        Cached<ChangePackAllocs>().Run();
                    }
                    if(_parent.RCOnWebSelectedSizes)
                    {
                        Cached<ChangeWebSelectedSizes>().Run();
                    }
                    if(_parent.RCOnWebItemOrder)
                    {
                        Cached<ChangeWebItemOrder>().Run();
                    }
                    if(_parent.RCOnWebProductStatus)
                    {
                        Cached<ChangeWebProductStatus>().Run();
                    }
                    if(_parent.RCOnOptionGradeSets)
                    {
                        Cached<ChangeOptionGradeSet>().Run();
                    }
                    if(_parent.RCOnWebSelectedColours)
                    {
                        Cached<ChangeWebSelectedColours>().Run();
                    }
                    if(_parent.RCOnOptionComments)
                    {
                        Cached<ChangeOptionComments>().Run();
                    }
                    if(_parent.RCOnWebPackShots)
                    {
                        Cached<ChangeWebPackShots>().Run();
                    }
                    if(_parent.RCOnWebOptionOrder)
                    {
                        Cached<ChangeWebOptionOrder>().Run();
                    }
                    if(_parent.RCOnOptionAttributes)
                    {
                        Cached<ChangeOptionAttributes>().Run();
                    }
                    if(_parent.RCOnStoryOptions)
                    {
                        Cached<ChangeStoryOptions>().Run();
                    }
                    if(_parent.RCOnProductCost)
                    {
                        Cached<ChangeProductCost>().Run();
                    }
                    if(_parent.RCOnProgramOptionGrade)
                    {
                        Cached<ChangeProgramOptionGrade>().Run();
                    }
                    if(_parent.RCOnPacksMakeup)
                    {
                        Cached<ChangePacksMakeup>().Run();
                    }
                    if(_parent.RCOnFranchPacksMakeup && _parent.RCProductOnLineList)
                    {
                        Cached<ChangeFranchPacksMakeup>().Run();
                    }
                    if(_parent.RCOnModelsDetail)
                    {
                        Cached<ChangeModelsDetail>().Run();
                    }
                    if(_parent.RCOnRefTcodes)
                    {
                        Cached<ChangeRefTcodes>().Run();
                    }
                    if(_parent.RCOnRefTilprc)
                    {
                        Cached<ChangeRefTillPrice>().Run();
                    }
                    if(_parent.RCOnPo2060ItemExtract)
                    {
                        Cached<ChangePo2060ItemExtract>().Run();
                    }
                    if(_parent.RCOnPo2060OptionExtract)
                    {
                        Cached<ChangePo2060OptionExtract>().Run();
                    }
                    if(_parent.RCOnWebPhotoDetail)
                    {
                        Cached<ChangeWebPhotoDetail>().Run();
                    }
                    if(_parent.RCOnWebImageTBlob)
                    {
                        Cached<ChangeWebImageTBlob>().Run();
                    }
                    if(_parent.RCOnWebImageSBlob)
                    {
                        Cached<ChangeWebImageSBlob>().Run();
                    }
                    if(_parent.RCOnWebImageMBlob)
                    {
                        Cached<ChangeWebImageMBlob>().Run();
                    }
                    if(_parent.RCOnWebImageLBlob)
                    {
                        Cached<ChangeWebImageLBlob>().Run();
                    }
                    if(_parent.RCOnWebImageBlob)
                    {
                        Cached<ChangeWebImageBlob>().Run();
                    }
                    if(_parent.RCOnPo2140Orders)
                    {
                        Cached<ChangePo2140Orders>().Run();
                    }
                    if(_parent.RCOnPo2140OrdersPacks)
                    {
                        Cached<ChangePo2140OrdersPacks>().Run();
                    }
                    if(_parent.RCOnPo2140PacksMakeup)
                    {
                        Cached<ChangePo2140PacksMakeup>().Run();
                    }
                    if(_parent.RCOnSSLineMonitorExtract)
                    {
                        Cached<ChangeSSLineMonitorExtract>().Run();
                    }
                    if(_parent.RCOnSSLineMonitorPlan)
                    {
                        Cached<ChangeSSLineMonitorPlan>().Run();
                    }
                    if(_parent.RCOnALCPackAllocs)
                    {
                        Cached<ChangeALCPackAllocs>().Run();
                    }
                }
                
                
                
                /// <summary>Change Order Lot Item(P#487.9.3.1)</summary>
                // Last change before Migration: 20/11/2012 10:42:06
                class ChangeOrderLotItem : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Order Lot Item</summary>
                    readonly Models.OrderLotItem OrderLotItem = new Models.OrderLotItem { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Order Lot Item(P#487.9.3.1)</summary>
                    public ChangeOrderLotItem(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Order Lot Item";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OrderLotItem;
                        Where.Add(OrderLotItem.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(OrderLotItem.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = OrderLotItem.SortByMOS_ORDER_LOT_ITEM_X1;
                        
                        #region Columns
                        
                        Columns.Add(OrderLotItem.PRODUCT_NUMBER);
                        Columns.Add(OrderLotItem.COLOUR_CODE);
                        Columns.Add(OrderLotItem.LAST_MODIFY_BY);
                        Columns.Add(OrderLotItem.LAST_MODIFY_DATE);
                        Columns.Add(OrderLotItem.LAST_MODIFY_TIME);
                        #endregion
                    }
                    
                    /// <summary>Change Order Lot Item</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        OrderLotItem.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        OrderLotItem.LAST_MODIFY_BY.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        OrderLotItem.LAST_MODIFY_DATE.Value = Date.Now;
                        OrderLotItem.LAST_MODIFY_TIME.Value = Time.Now;
                    }
                    
                    
                }
                
                /// <summary>Change SS Item Price(P#487.9.3.2)</summary>
                // Last change before Migration: 23/04/2013 16:11:14
                class ChangeSSItemPrice : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Price File</summary>
                    readonly Models.PriceFile PriceFile = new Models.PriceFile { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change SS Item Price(P#487.9.3.2)</summary>
                    public ChangeSSItemPrice(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change SS Item Price";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = PriceFile;
                        Where.Add(PriceFile.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(PriceFile.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = PriceFile.SortBySS_ITEM_PRICE_X1;
                        
                        #region Columns
                        
                        Columns.Add(PriceFile.PRODUCT_NUMBER);
                        Columns.Add(PriceFile.COLOUR_CODE);
                        Columns.Add(PriceFile.START_DATETIME);
                        Columns.Add(PriceFile.MODIFY_DATETIME);
                        #endregion
                    }
                    
                    /// <summary>Change SS Item Price</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        PriceFile.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        PriceFile.MODIFY_DATETIME.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Substitutes(P#487.9.3.3)</summary>
                // Last change before Migration: 20/11/2012 10:42:13
                class ChangeSubstitutes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Substitutes</summary>
                    readonly Models.Substitutes Substitutes = new Models.Substitutes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Substitutes(P#487.9.3.3)</summary>
                    public ChangeSubstitutes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Substitutes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = Substitutes;
                        Where.Add(Substitutes.PRIMARY_PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(Substitutes.PRIMARY_COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = Substitutes.SortByALC_SUBSTITUTE_ITEMS_X1;
                        
                        #region Columns
                        
                        Columns.Add(Substitutes.PRIMARY_PRODUCT_NUMBER);
                        Columns.Add(Substitutes.PRIMARY_COLOUR_CODE);
                        Columns.Add(Substitutes.AMEND_USER);
                        Columns.Add(Substitutes.AMEND_DATETIME);
                        #endregion
                    }
                    
                    /// <summary>Change Substitutes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        Substitutes.PRIMARY_COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        Substitutes.AMEND_USER.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        Substitutes.AMEND_DATETIME.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Pack Allocs(P#487.9.3.4)</summary>
                // Last change before Migration: 20/11/2012 10:42:17
                class ChangePackAllocs : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>ALC_Pack_Allocs</summary>
                    readonly Models.ALC_Pack_Allocs ALC_Pack_Allocs = new Models.ALC_Pack_Allocs { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Pack Allocs(P#487.9.3.4)</summary>
                    public ChangePackAllocs(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Pack Allocs";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ALC_Pack_Allocs;
                        Where.Add(ALC_Pack_Allocs.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ALC_Pack_Allocs.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = ALC_Pack_Allocs.SortByALC_Pack_Allocs_X1;
                        
                        #region Columns
                        
                        Columns.Add(ALC_Pack_Allocs.ProductNumber);
                        Columns.Add(ALC_Pack_Allocs.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change Pack Allocs</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ALC_Pack_Allocs.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Web Selected Sizes(P#487.9.3.5)</summary>
                // Last change before Migration: 20/11/2012 10:42:21
                class ChangeWebSelectedSizes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Selected Sizes</summary>
                    readonly Models.WebSelectedSizes WebSelectedSizes = new Models.WebSelectedSizes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Selected Sizes(P#487.9.3.5)</summary>
                    public ChangeWebSelectedSizes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Selected Sizes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebSelectedSizes;
                        Where.Add(WebSelectedSizes.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebSelectedSizes.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebSelectedSizes.SortByMOS_Web_Selected_Sizes_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebSelectedSizes.ProductNumber);
                        Columns.Add(WebSelectedSizes.ColourCode);
                        Columns.Add(WebSelectedSizes.ModifiedBy);
                        Columns.Add(WebSelectedSizes.ModifiedDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Selected Sizes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebSelectedSizes.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        WebSelectedSizes.ModifiedBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        WebSelectedSizes.ModifiedDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Item Order(P#487.9.3.6)</summary>
                // Last change before Migration: 20/11/2012 10:42:25
                class ChangeWebItemOrder : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Item Order</summary>
                    readonly Models.WebItemOrder WebItemOrder = new Models.WebItemOrder { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Item Order(P#487.9.3.6)</summary>
                    public ChangeWebItemOrder(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Item Order";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebItemOrder;
                        Where.Add(WebItemOrder.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebItemOrder.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebItemOrder.SortByMOS_Web_Item_Order_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebItemOrder.ProductNumber);
                        Columns.Add(WebItemOrder.ColourCode);
                        Columns.Add(WebItemOrder.ModifyBy);
                        Columns.Add(WebItemOrder.ModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Item Order</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebItemOrder.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        WebItemOrder.ModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        WebItemOrder.ModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Product Status(P#487.9.3.7)</summary>
                // Last change before Migration: 27/03/2013 11:04:06
                class ChangeWebProductStatus : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Product Status</summary>
                    readonly Models.WebProductStatus WebProductStatus = new Models.WebProductStatus { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Product Status(P#487.9.3.7)</summary>
                    public ChangeWebProductStatus(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Product Status";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebProductStatus;
                        Where.Add(WebProductStatus.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebProductStatus.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebProductStatus.SortByMOS_Web_Prod_Status_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebProductStatus.ProductNumber);
                        Columns.Add(WebProductStatus.ColourCode);
                        Columns.Add(WebProductStatus.ProductStatusEvent);
                        Columns.Add(WebProductStatus.EventDateTime);
                        Columns.Add(WebProductStatus.EventUser);
                        #endregion
                    }
                    
                    /// <summary>Change Web Product Status</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebProductStatus.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        if(false)
                        {
                            WebProductStatus.ProductStatusEvent.Value = 99;
                        }
                        if(false)
                        {
                            WebProductStatus.EventDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                        }
                        WebProductStatus.EventUser.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                    }
                    
                    
                }
                
                /// <summary>Change Option Grade Set(P#487.9.3.8)</summary>
                // Last change before Migration: 23/11/2012 14:25:56
                class ChangeOptionGradeSet : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Option Grade Set</summary>
                    readonly Models.OptionGradeSet OptionGradeSet = new Models.OptionGradeSet { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Option Grade Set(P#487.9.3.8)</summary>
                    public ChangeOptionGradeSet(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Option Grade Set";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OptionGradeSet;
                        Where.Add(OptionGradeSet.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(OptionGradeSet.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = OptionGradeSet.SortByALC_OPTION_GRADE_SET_X1;
                        
                        #region Columns
                        
                        Columns.Add(OptionGradeSet.PRODUCT_NUMBER);
                        Columns.Add(OptionGradeSet.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Option Grade Set</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        OptionGradeSet.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        // not updating the last update name and date anymore because it stops the grades from being refreshed by al1045
                    }
                    
                    
                }
                
                /// <summary>Change Web Selected Colours(P#487.9.3.9)</summary>
                // Last change before Migration: 20/11/2012 10:42:38
                class ChangeWebSelectedColours : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Selected Colours</summary>
                    readonly Models.WebSelectedColours WebSelectedColours = new Models.WebSelectedColours { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Selected Colours(P#487.9.3.9)</summary>
                    public ChangeWebSelectedColours(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Selected Colours";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebSelectedColours;
                        Where.Add(WebSelectedColours.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebSelectedColours.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebSelectedColours.SortByMOS_Web_Selected_Colours_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebSelectedColours.ProductNumber);
                        Columns.Add(WebSelectedColours.ColourCode);
                        Columns.Add(WebSelectedColours.ModifiedBy);
                        Columns.Add(WebSelectedColours.ModifiedDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Selected Colours</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebSelectedColours.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        WebSelectedColours.ModifiedBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        WebSelectedColours.ModifiedDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Option Comments(P#487.9.3.10)</summary>
                // Last change before Migration: 20/11/2012 10:42:42
                class ChangeOptionComments : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>ALC_Option_comments</summary>
                    readonly Models.ALC_Option_comments ALC_Option_comments = new Models.ALC_Option_comments { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Option Comments(P#487.9.3.10)</summary>
                    public ChangeOptionComments(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Option Comments";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ALC_Option_comments;
                        Where.Add(ALC_Option_comments.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ALC_Option_comments.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = ALC_Option_comments.SortByALC_Option_Comments_X1;
                        
                        #region Columns
                        
                        Columns.Add(ALC_Option_comments.PRODUCT_NUMBER);
                        Columns.Add(ALC_Option_comments.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Option Comments</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ALC_Option_comments.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Web Pack Shots(P#487.9.3.11)</summary>
                // Last change before Migration: 23/11/2012 14:26:43
                class ChangeWebPackShots : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Pack Shots</summary>
                    readonly Models.WebPackShots WebPackShots = new Models.WebPackShots { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Pack Shots(P#487.9.3.11)</summary>
                    public ChangeWebPackShots(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Pack Shots";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebPackShots;
                        Where.Add(WebPackShots.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebPackShots.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebPackShots.SortByMOS_Web_PackShots_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebPackShots.ProductNumber);
                        Columns.Add(WebPackShots.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change Web Pack Shots</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebPackShots.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Web Option Order(P#487.9.3.12)</summary>
                // Last change before Migration: 20/11/2012 10:42:49
                class ChangeWebOptionOrder : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Option Order</summary>
                    readonly Models.WebOptionOrder WebOptionOrder = new Models.WebOptionOrder { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Option Order(P#487.9.3.12)</summary>
                    public ChangeWebOptionOrder(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Option Order";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebOptionOrder;
                        Where.Add(WebOptionOrder.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebOptionOrder.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebOptionOrder.SortByMOS_Web_Option_Order_X1;
                        
                        #region Columns
                        
                        Columns.Add(WebOptionOrder.ProductNumber);
                        Columns.Add(WebOptionOrder.ColourCode);
                        Columns.Add(WebOptionOrder.ModifyBy);
                        Columns.Add(WebOptionOrder.ModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Option Order</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebOptionOrder.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        WebOptionOrder.ModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        WebOptionOrder.ModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Option Attributes(P#487.9.3.13)</summary>
                // Last change before Migration: 20/11/2012 10:42:53
                class ChangeOptionAttributes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Option Attributes</summary>
                    readonly Models.OptionAttributes OptionAttributes = new Models.OptionAttributes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Option Attributes(P#487.9.3.13)</summary>
                    public ChangeOptionAttributes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Option Attributes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OptionAttributes;
                        Where.Add(OptionAttributes.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(OptionAttributes.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = OptionAttributes.SortByREF_OPT_ATT_X3;
                        
                        #region Columns
                        
                        Columns.Add(OptionAttributes.PRODUCT_NUMBER);
                        Columns.Add(OptionAttributes.COLOUR_CODE);
                        Columns.Add(OptionAttributes.LAST_AMENDED_DATE);
                        Columns.Add(OptionAttributes.LAST_AMENDED_TIME);
                        Columns.Add(OptionAttributes.LAST_AMENDED_BY);
                        #endregion
                    }
                    
                    /// <summary>Change Option Attributes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        OptionAttributes.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        OptionAttributes.LAST_AMENDED_DATE.Value = Date.Now;
                        OptionAttributes.LAST_AMENDED_TIME.Value = Time.Now;
                        OptionAttributes.LAST_AMENDED_BY.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                    }
                    
                    
                }
                
                /// <summary>Change Story Options(P#487.9.3.14)</summary>
                // Last change before Migration: 20/11/2012 10:42:56
                class ChangeStoryOptions : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Story Options</summary>
                    readonly Models.StoryOptions StoryOptions = new Models.StoryOptions { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Story Options(P#487.9.3.14)</summary>
                    public ChangeStoryOptions(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Story Options";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = StoryOptions;
                        Where.Add(StoryOptions.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(StoryOptions.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = StoryOptions.SortByALC_STORY_OPTIONS_X2;
                        
                        #region Columns
                        
                        Columns.Add(StoryOptions.PRODUCT_NUMBER);
                        Columns.Add(StoryOptions.COLOUR_CODE);
                        Columns.Add(StoryOptions.AMEND_USER);
                        Columns.Add(StoryOptions.AMEND_DATETIME);
                        #endregion
                    }
                    
                    /// <summary>Change Story Options</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        StoryOptions.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        StoryOptions.AMEND_USER.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        StoryOptions.AMEND_DATETIME.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Product Cost(P#487.9.3.15)</summary>
                // Last change before Migration: 20/11/2012 10:43:00
                class ChangeProductCost : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>REF_PRODCOST</summary>
                    readonly Models.REF_PRODCOST REF_PRODCOST = new Models.REF_PRODCOST { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Product Cost(P#487.9.3.15)</summary>
                    public ChangeProductCost(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Product Cost";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = REF_PRODCOST;
                        Where.Add(REF_PRODCOST.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(REF_PRODCOST.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = REF_PRODCOST.SortByREF_PRODCOST_X1;
                        
                        #region Columns
                        
                        Columns.Add(REF_PRODCOST.PRODUCT_NUMBER);
                        Columns.Add(REF_PRODCOST.COLOUR_CODE);
                        Columns.Add(REF_PRODCOST.LAST_AMEND_DATE);
                        #endregion
                    }
                    
                    /// <summary>Change Product Cost</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        REF_PRODCOST.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        REF_PRODCOST.LAST_AMEND_DATE.Value = Date.Now;
                    }
                    
                    
                }
                
                /// <summary>Change Program Option Grade(P#487.9.3.16)</summary>
                // Last change before Migration: 20/11/2012 10:43:03
                class ChangeProgramOptionGrade : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Programs Option Gradeset</summary>
                    readonly Models.ProgramsOptionGradeset ProgramsOptionGradeset = new Models.ProgramsOptionGradeset { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Program Option Grade(P#487.9.3.16)</summary>
                    public ChangeProgramOptionGrade(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Program Option Grade";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ProgramsOptionGradeset;
                        Where.Add(ProgramsOptionGradeset.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ProgramsOptionGradeset.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = ProgramsOptionGradeset.SortByALC_PROG_OPTION_GRADESET_X2;
                        
                        #region Columns
                        
                        Columns.Add(ProgramsOptionGradeset.PRODUCT_NUMBER);
                        Columns.Add(ProgramsOptionGradeset.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Program Option Grade</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ProgramsOptionGradeset.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Packs Makeup(P#487.9.3.17)</summary>
                // Last change before Migration: 20/11/2012 10:43:08
                class ChangePacksMakeup : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Packs Make Up</summary>
                    readonly Models.PacksMakeUp PacksMakeUp = new Models.PacksMakeUp { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Packs Makeup(P#487.9.3.17)</summary>
                    public ChangePacksMakeup(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Packs Makeup";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = PacksMakeUp;
                        Where.Add(PacksMakeUp.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(PacksMakeUp.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = PacksMakeUp.SortByWAR_Pack_MakeUp_X1;
                        
                        #region Columns
                        
                        Columns.Add(PacksMakeUp.ProductNumber);
                        Columns.Add(PacksMakeUp.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change Packs Makeup</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        PacksMakeUp.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Franch Packs Makeup(P#487.9.3.18)</summary>
                // Last change before Migration: 23/11/2012 14:28:25
                class ChangeFranchPacksMakeup : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Franchisee Pack Makeup</summary>
                    readonly Models.FranchiseePackMakeup FranchiseePackMakeup = new Models.FranchiseePackMakeup { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Franch Packs Makeup(P#487.9.3.18)</summary>
                    public ChangeFranchPacksMakeup(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Franch Packs Makeup";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = FranchiseePackMakeup;
                        Where.Add(FranchiseePackMakeup.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(FranchiseePackMakeup.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = FranchiseePackMakeup.SortByMOS_FRA_PACK_MAKEUP_X1;
                        
                        #region Columns
                        
                        Columns.Add(FranchiseePackMakeup.ProductNumber);
                        Columns.Add(FranchiseePackMakeup.ColourCode);
                        Columns.Add(FranchiseePackMakeup.LastUpdateUser);
                        Columns.Add(FranchiseePackMakeup.LastUpdateDate);
                        Columns.Add(FranchiseePackMakeup.LastUpdateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Franch Packs Makeup</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        FranchiseePackMakeup.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        FranchiseePackMakeup.LastUpdateUser.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        FranchiseePackMakeup.LastUpdateDate.Value = Date.Now;
                        FranchiseePackMakeup.LastUpdateTime.Value = Time.Now;
                    }
                    
                    
                }
                
                /// <summary>Change Models Detail(P#487.9.3.19)</summary>
                // Last change before Migration: 20/11/2012 13:56:16
                class ChangeModelsDetail : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Models Detail</summary>
                    readonly Models.ModelsDetail ModelsDetail = new Models.ModelsDetail { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Models Detail(P#487.9.3.19)</summary>
                    public ChangeModelsDetail(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Models Detail";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ModelsDetail;
                        Where.Add(ModelsDetail.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ModelsDetail.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = ModelsDetail.SortByPRC_MODELS_DETAIL_X1;
                        
                        #region Columns
                        
                        Columns.Add(ModelsDetail.PRODUCT_NUMBER);
                        Columns.Add(ModelsDetail.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Models Detail</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ModelsDetail.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Ref Tcodes(P#487.9.3.20)</summary>
                // Last change before Migration: 20/11/2012 14:01:16
                class ChangeRefTcodes : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Tcodes</summary>
                    readonly Models.Tcodes Tcodes = new Models.Tcodes { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Ref Tcodes(P#487.9.3.20)</summary>
                    public ChangeRefTcodes(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Ref Tcodes";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = Tcodes;
                        Where.Add(Tcodes.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(Tcodes.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = Tcodes.SortByREF_TCODES_X2;
                        
                        #region Columns
                        
                        Columns.Add(Tcodes.PRODUCT_NUMBER);
                        Columns.Add(Tcodes.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Ref Tcodes</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        Tcodes.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Ref Till Price(P#487.9.3.21)</summary>
                // Last change before Migration: 20/11/2012 14:11:15
                class ChangeRefTillPrice : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Till Price</summary>
                    readonly Models.TillPrice TillPrice = new Models.TillPrice { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Ref Till Price(P#487.9.3.21)</summary>
                    public ChangeRefTillPrice(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Ref Till Price";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = TillPrice;
                        Where.Add(TillPrice.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(TillPrice.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = TillPrice.SortByREF_TilPrc_X2;
                        
                        #region Columns
                        
                        Columns.Add(TillPrice.ProductNumber);
                        Columns.Add(TillPrice.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change Ref Till Price</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        TillPrice.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change po2060 Item Extract(P#487.9.3.22)</summary>
                // Last change before Migration: 20/11/2012 14:15:27
                class ChangePo2060ItemExtract : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_po2060_Item_Extract</summary>
                    readonly Models.MOS_po2060_Item_Extract MOS_po2060_Item_Extract = new Models.MOS_po2060_Item_Extract { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change po2060 Item Extract(P#487.9.3.22)</summary>
                    public ChangePo2060ItemExtract(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change po2060 Item Extract";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_po2060_Item_Extract;
                        Where.Add(MOS_po2060_Item_Extract.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_po2060_Item_Extract.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_po2060_Item_Extract.SortByMOS_PO2060_ITEM_EXTRACT_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_po2060_Item_Extract.PRODUCT_NUMBER);
                        Columns.Add(MOS_po2060_Item_Extract.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change po2060 Item Extract</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_po2060_Item_Extract.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change po2060 Option Extract(P#487.9.3.23)</summary>
                // Last change before Migration: 20/11/2012 14:16:17
                class ChangePo2060OptionExtract : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_po2060_Option_Extract</summary>
                    readonly Models.MOS_po2060_Option_Extract MOS_po2060_Option_Extract = new Models.MOS_po2060_Option_Extract { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change po2060 Option Extract(P#487.9.3.23)</summary>
                    public ChangePo2060OptionExtract(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change po2060 Option Extract";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_po2060_Option_Extract;
                        Where.Add(MOS_po2060_Option_Extract.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_po2060_Option_Extract.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_po2060_Option_Extract.SortByMOS_PO2060_OPTION_EXTRACT_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_po2060_Option_Extract.PRODUCT_NUMBER);
                        Columns.Add(MOS_po2060_Option_Extract.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change po2060 Option Extract</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_po2060_Option_Extract.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change Web Photo Detail(P#487.9.3.24)</summary>
                // Last change before Migration: 22/11/2012 14:46:48
                class ChangeWebPhotoDetail : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Web Photo Detail</summary>
                    readonly Models.WebPhotoDetail WebPhotoDetail = new Models.WebPhotoDetail { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Photo Detail(P#487.9.3.24)</summary>
                    public ChangeWebPhotoDetail(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Photo Detail";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = WebPhotoDetail;
                        Where.Add(WebPhotoDetail.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(WebPhotoDetail.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = WebPhotoDetail.SortByMOS_Web_Photo_Detail_X2;
                        
                        #region Columns
                        
                        Columns.Add(WebPhotoDetail.ProductNumber);
                        Columns.Add(WebPhotoDetail.ColourCode);
                        Columns.Add(WebPhotoDetail.AmendDatetime);
                        Columns.Add(WebPhotoDetail.AmendBy);
                        #endregion
                    }
                    
                    /// <summary>Change Web Photo Detail</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        WebPhotoDetail.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        WebPhotoDetail.AmendDatetime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                        WebPhotoDetail.AmendBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                    }
                    
                    
                }
                
                /// <summary>Change Web Image TBlob(P#487.9.3.25)</summary>
                // Last change before Migration: 22/11/2012 14:47:35
                class ChangeWebImageTBlob : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_Web_Image_TBlob</summary>
                    readonly Models.MOS_Web_Image_TBlob MOS_Web_Image_TBlob = new Models.MOS_Web_Image_TBlob { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Image TBlob(P#487.9.3.25)</summary>
                    public ChangeWebImageTBlob(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Image TBlob";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_Web_Image_TBlob;
                        Where.Add(MOS_Web_Image_TBlob.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_Web_Image_TBlob.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_Web_Image_TBlob.SortByMOS_WEB_IMAGE_TBLOB_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_Web_Image_TBlob.ProductNumber);
                        Columns.Add(MOS_Web_Image_TBlob.ColourCode);
                        Columns.Add(MOS_Web_Image_TBlob.LastModifyBy);
                        Columns.Add(MOS_Web_Image_TBlob.LastModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Image TBlob</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_Web_Image_TBlob.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        MOS_Web_Image_TBlob.LastModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        MOS_Web_Image_TBlob.LastModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Image SBlob(P#487.9.3.26)</summary>
                // Last change before Migration: 22/11/2012 14:48:05
                class ChangeWebImageSBlob : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_Web_Image_SBlob</summary>
                    readonly Models.MOS_Web_Image_SBlob MOS_Web_Image_SBlob = new Models.MOS_Web_Image_SBlob { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Image SBlob(P#487.9.3.26)</summary>
                    public ChangeWebImageSBlob(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Image SBlob";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_Web_Image_SBlob;
                        Where.Add(MOS_Web_Image_SBlob.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_Web_Image_SBlob.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_Web_Image_SBlob.SortByMOS_WEB_IMAGE_SBLOB_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_Web_Image_SBlob.ProductNumber);
                        Columns.Add(MOS_Web_Image_SBlob.ColourCode);
                        Columns.Add(MOS_Web_Image_SBlob.LastModifyBy);
                        Columns.Add(MOS_Web_Image_SBlob.LastModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Image SBlob</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_Web_Image_SBlob.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        MOS_Web_Image_SBlob.LastModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        MOS_Web_Image_SBlob.LastModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Image MBlob(P#487.9.3.27)</summary>
                // Last change before Migration: 22/11/2012 14:48:35
                class ChangeWebImageMBlob : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_Web_Image_MBlob</summary>
                    readonly Models.MOS_Web_Image_MBlob MOS_Web_Image_MBlob = new Models.MOS_Web_Image_MBlob { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Image MBlob(P#487.9.3.27)</summary>
                    public ChangeWebImageMBlob(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Image MBlob";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_Web_Image_MBlob;
                        Where.Add(MOS_Web_Image_MBlob.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_Web_Image_MBlob.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_Web_Image_MBlob.SortByMOS_WEB_IMAGE_MBLOB_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_Web_Image_MBlob.ProductNumber);
                        Columns.Add(MOS_Web_Image_MBlob.ColourCode);
                        Columns.Add(MOS_Web_Image_MBlob.LastModifyBy);
                        Columns.Add(MOS_Web_Image_MBlob.LastModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Image MBlob</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_Web_Image_MBlob.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        MOS_Web_Image_MBlob.LastModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        MOS_Web_Image_MBlob.LastModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Image LBlob(P#487.9.3.28)</summary>
                // Last change before Migration: 22/11/2012 14:49:04
                class ChangeWebImageLBlob : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_Web_Image_LBlob</summary>
                    readonly Models.MOS_Web_Image_LBlob MOS_Web_Image_LBlob = new Models.MOS_Web_Image_LBlob { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Image LBlob(P#487.9.3.28)</summary>
                    public ChangeWebImageLBlob(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Image LBlob";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_Web_Image_LBlob;
                        Where.Add(MOS_Web_Image_LBlob.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_Web_Image_LBlob.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_Web_Image_LBlob.SortByMOS_WEB_IMAGE_LBLOB_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_Web_Image_LBlob.ProductNumber);
                        Columns.Add(MOS_Web_Image_LBlob.ColourCode);
                        Columns.Add(MOS_Web_Image_LBlob.LastModifyBy);
                        Columns.Add(MOS_Web_Image_LBlob.LastModifyDateTime);
                        #endregion
                    }
                    
                    /// <summary>Change Web Image LBlob</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_Web_Image_LBlob.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                        MOS_Web_Image_LBlob.LastModifyBy.Value = u.Upper(ENV.Security.UserManager.CurrentUser.Name);
                        MOS_Web_Image_LBlob.LastModifyDateTime.Value = u.DStr(Date.Now, "YYYY-MM-DD") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    
                    
                }
                
                /// <summary>Change Web Image Blob(P#487.9.3.29)</summary>
                // Last change before Migration: 23/11/2012 14:35:18
                class ChangeWebImageBlob : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_Web_Image_Blob</summary>
                    readonly Models.MOS_Web_Image_Blob MOS_Web_Image_Blob = new Models.MOS_Web_Image_Blob { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change Web Image Blob(P#487.9.3.29)</summary>
                    public ChangeWebImageBlob(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change Web Image Blob";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_Web_Image_Blob;
                        Where.Add(MOS_Web_Image_Blob.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(MOS_Web_Image_Blob.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MOS_Web_Image_Blob.SortByMOS_WEB_IMAGE_BLOB_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_Web_Image_Blob.PRODUCT_NUMBER);
                        Columns.Add(MOS_Web_Image_Blob.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change Web Image Blob</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_Web_Image_Blob.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change po2140 Orders(P#487.9.3.30)</summary>
                // Last change before Migration: 20/11/2012 14:22:13
                class ChangePo2140Orders : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Mos po2140 Orders</summary>
                    readonly Models.MosPo2140Orders MosPo2140Orders = new Models.MosPo2140Orders { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change po2140 Orders(P#487.9.3.30)</summary>
                    public ChangePo2140Orders(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change po2140 Orders";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MosPo2140Orders;
                        Where.Add(MosPo2140Orders.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        Where.Add(MosPo2140Orders.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        OrderBy = MosPo2140Orders.SortByMOS_PO2140_ORDERS_X1;
                        
                        #region Columns
                        
                        Columns.Add(MosPo2140Orders.COLOUR_CODE);
                        Columns.Add(MosPo2140Orders.PRODUCT_NUMBER);
                        #endregion
                    }
                    
                    /// <summary>Change po2140 Orders</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MosPo2140Orders.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change po2140 Orders Packs(P#487.9.3.31)</summary>
                // Last change before Migration: 23/11/2012 14:32:19
                class ChangePo2140OrdersPacks : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Mos po2140 Orders Packs</summary>
                    readonly Models.MosPo2140OrdersPacks MosPo2140OrdersPacks = new Models.MosPo2140OrdersPacks { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change po2140 Orders Packs(P#487.9.3.31)</summary>
                    public ChangePo2140OrdersPacks(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change po2140 Orders Packs";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MosPo2140OrdersPacks;
                        Where.Add(MosPo2140OrdersPacks.OrderNumber.IsEqualTo(_parent.MosPo2140Orders.ORDER_NUMBER));
                        Where.Add(MosPo2140OrdersPacks.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = MosPo2140OrdersPacks.SortByMOS_po2140_Orders_Packs_X1;
                        
                        #region Columns
                        
                        Columns.Add(MosPo2140OrdersPacks.OrderNumber);
                        Columns.Add(MosPo2140OrdersPacks.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change po2140 Orders Packs</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MosPo2140OrdersPacks.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change po2140 Packs Makeup(P#487.9.3.32)</summary>
                // Last change before Migration: 21/11/2012 15:58:45
                class ChangePo2140PacksMakeup : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>MOS_PO2140_PACKS_MAKEUP</summary>
                    readonly Models.MOS_PO2140_PACKS_MAKEUP MOS_PO2140_PACKS_MAKEUP = new Models.MOS_PO2140_PACKS_MAKEUP { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change po2140 Packs Makeup(P#487.9.3.32)</summary>
                    public ChangePo2140PacksMakeup(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change po2140 Packs Makeup";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = MOS_PO2140_PACKS_MAKEUP;
                        Where.Add(MOS_PO2140_PACKS_MAKEUP.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        Where.Add(MOS_PO2140_PACKS_MAKEUP.PRODUCT1.IsLessOrEqualTo(_parent._parent._parent.PProductNumber));
                        OrderBy = MOS_PO2140_PACKS_MAKEUP.SortByMOS_PO2140_PACKS_MAKEUP_X1;
                        
                        #region Columns
                        
                        Columns.Add(MOS_PO2140_PACKS_MAKEUP.COLOUR_CODE);
                        Columns.Add(MOS_PO2140_PACKS_MAKEUP.PRODUCT1);
                        #endregion
                    }
                    
                    /// <summary>Change po2140 Packs Makeup</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        MOS_PO2140_PACKS_MAKEUP.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change SS Line Monitor Extract(P#487.9.3.33)</summary>
                // Last change before Migration: 20/11/2012 14:26:57
                class ChangeSSLineMonitorExtract : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>SS_LINE_MONITOR_EXT</summary>
                    readonly Models.SS_LINE_MONITOR_EXT SS_LINE_MONITOR_EXT = new Models.SS_LINE_MONITOR_EXT { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change SS Line Monitor Extract(P#487.9.3.33)</summary>
                    public ChangeSSLineMonitorExtract(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change SS Line Monitor Extract";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = SS_LINE_MONITOR_EXT;
                        Where.Add(SS_LINE_MONITOR_EXT.PRODUCT_NUMBER.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(SS_LINE_MONITOR_EXT.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = SS_LINE_MONITOR_EXT.SortBySS_LINE_MONITOR_EXT_X1;
                        
                        #region Columns
                        
                        Columns.Add(SS_LINE_MONITOR_EXT.PRODUCT_NUMBER);
                        Columns.Add(SS_LINE_MONITOR_EXT.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change SS Line Monitor Extract</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        SS_LINE_MONITOR_EXT.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change SS Line Monitor Plan(P#487.9.3.34)</summary>
                // Last change before Migration: 20/11/2012 14:28:35
                class ChangeSSLineMonitorPlan : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>SS_LINE_MONITOR_PLAN</summary>
                    readonly Models.SS_LINE_MONITOR_PLAN SS_LINE_MONITOR_PLAN = new Models.SS_LINE_MONITOR_PLAN { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change SS Line Monitor Plan(P#487.9.3.34)</summary>
                    public ChangeSSLineMonitorPlan(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change SS Line Monitor Plan";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = SS_LINE_MONITOR_PLAN;
                        Where.Add(SS_LINE_MONITOR_PLAN.MASTER_PRODUCT.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(SS_LINE_MONITOR_PLAN.COLOUR_CODE.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = SS_LINE_MONITOR_PLAN.SortBySS_LINE_MONITOR_PLAN_X1;
                        
                        #region Columns
                        
                        Columns.Add(SS_LINE_MONITOR_PLAN.MASTER_PRODUCT);
                        Columns.Add(SS_LINE_MONITOR_PLAN.COLOUR_CODE);
                        #endregion
                    }
                    
                    /// <summary>Change SS Line Monitor Plan</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        SS_LINE_MONITOR_PLAN.COLOUR_CODE.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
                
                /// <summary>Change ALC Pack Allocs(P#487.9.3.35)</summary>
                // Last change before Migration: 20/11/2012 14:29:13
                class ChangeALCPackAllocs : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>ALC_Pack_Allocs</summary>
                    readonly Models.ALC_Pack_Allocs ALC_Pack_Allocs = new Models.ALC_Pack_Allocs { AllowRowLocking = true };
                    #endregion
                    
                    CheckTablesViaMagic _parent;
                    
                    
                    /// <summary>Change ALC Pack Allocs(P#487.9.3.35)</summary>
                    public ChangeALCPackAllocs(CheckTablesViaMagic parent)
                    {
                        _parent = parent;
                        Title = "Change ALC Pack Allocs";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = ALC_Pack_Allocs;
                        Where.Add(ALC_Pack_Allocs.ProductNumber.IsEqualTo(_parent._parent._parent.PProductNumber));
                        Where.Add(ALC_Pack_Allocs.ColourCode.IsEqualTo(_parent._parent.ModifyColourWorkfile.OriginalColour));
                        OrderBy = ALC_Pack_Allocs.SortByALC_Pack_Allocs_X1;
                        
                        #region Columns
                        
                        Columns.Add(ALC_Pack_Allocs.ProductNumber);
                        Columns.Add(ALC_Pack_Allocs.ColourCode);
                        #endregion
                    }
                    
                    /// <summary>Change ALC Pack Allocs</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        ALC_Pack_Allocs.ColourCode.Value = _parent._parent.ModifyColourWorkfile.ColourCode;
                    }
                    
                    
                }
            }
            
            /// <summary>Read Product Colour(P#487.9.4)</summary>
            // Last change before Migration: 20/11/2012 10:44:13
            class ReadProductColour : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Product Colours</summary>
                readonly Models.ProductColours ProductColours = new Models.ProductColours { AllowRowLocking = true };
                #endregion
                
                FindColourChanges _parent;
                
                
                /// <summary>Read Product Colour(P#487.9.4)</summary>
                public ReadProductColour(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Read Product Colour";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProductColours;
                    Where.Add(ProductColours.ProductNumber.IsEqualTo(_parent._parent.PProductNumber));
                    Where.Add(ProductColours.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour));
                    OrderBy = ProductColours.SortBySHP_Product_Colours_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProductColours.ProductNumber);
                    Columns.Add(ProductColours.ColourCode);
                    Columns.Add(ProductColours.ColourRelativePosition);
                    Columns.Add(ProductColours.CreateUser);
                    Columns.Add(ProductColours.CreateDate);
                    Columns.Add(ProductColours.CreateTime);
                    Columns.Add(ProductColours.LastUpdateUsrID);
                    Columns.Add(ProductColours.LastUpdateDate);
                    Columns.Add(ProductColours.LastUpdateTime);
                    #endregion
                }
                
                /// <summary>Read Product Colour</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    Cached<WriteAuditProductColour>().Run();
                }
                
                
                
                /// <summary>Write Audit Product Colour(P#487.9.4.1)</summary>
                // Last change before Migration: 20/11/2012 10:44:12
                class WriteAuditProductColour : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Audit Product Colour</summary>
                    readonly Models.AuditProductColour AuditProductColour = new Models.AuditProductColour { AllowRowLocking = true };
                    #endregion
                    
                    ReadProductColour _parent;
                    
                    
                    /// <summary>Write Audit Product Colour(P#487.9.4.1)</summary>
                    public WriteAuditProductColour(ReadProductColour parent)
                    {
                        _parent = parent;
                        Title = "Write Audit Product Colour";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        Relations.Add(AuditProductColour, RelationType.Insert, 
                        	AuditProductColour.SortBySHP_Audit_Product_Colour_X1);
                        
                        
                        #region Columns
                        
                        Columns.Add(AuditProductColour.ProductNumber).BindValue(_parent._parent._parent.PProductNumber);
                        Columns.Add(AuditProductColour.CreateDate).BindValue(() => Date.Now);
                        Columns.Add(AuditProductColour.CreateTime).BindValue(() => Time.Now);
                        Columns.Add(AuditProductColour.ColourRelativePosition).BindValue(_parent.ProductColours.ColourRelativePosition);
                        Columns.Add(AuditProductColour.ColourCode).BindValue(_parent._parent.ModifyColourWorkfile.ColourCode);
                        Columns.Add(AuditProductColour.ExtractStatus).BindValue(() => 0);
                        Columns.Add(AuditProductColour.CreateUser).BindValue(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name));
                        Columns.Add(AuditProductColour.AuditAction).BindValue(() => 3);
                        #endregion
                    }
                    
                    /// <summary>Write Audit Product Colour</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        Exit(ExitTiming.AfterRow);
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    
                    
                }
            }
            
            /// <summary>Refresh Order Lot Item/Option(P#487.9.5)</summary>
            // Last change before Migration: 20/11/2012 10:44:39
            class RefreshOrderLotItemOption : Mos.BusinessProcessBase 
            {
                FindColourChanges _parent;
                
                
                /// <summary>Refresh Order Lot Item/Option(P#487.9.5)</summary>
                public RefreshOrderLotItemOption(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Refresh Order Lot Item/Option";
                }
                
                /// <summary>Refresh Order Lot Item/Option</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AsSoonAsPossible);
                }
                protected override void OnEnd()
                {
                    Cached<ClearOrderLotItemForOrder>().Run();
                    Cached<RegenOrderLotItem>().Run();
                    Cached<ClearOrderLotOptionForOrd>().Run();
                    Cached<RegenOrderLotOption>().Run();
                }
                
                
                
                /// <summary>Clear order lot item for order(P#487.9.5.1)</summary>
                // Last change before Migration: 20/11/2012 10:44:21
                class ClearOrderLotItemForOrder : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Order Lot Item</summary>
                    readonly Models.OrderLotItem OrderLotItem = new Models.OrderLotItem { AllowRowLocking = true };
                    #endregion
                    
                    RefreshOrderLotItemOption _parent;
                    
                    
                    /// <summary>Clear order lot item for order(P#487.9.5.1)</summary>
                    public ClearOrderLotItemForOrder(RefreshOrderLotItemOption parent)
                    {
                        _parent = parent;
                        Title = "Clear order lot item for order";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OrderLotItem;
                        Where.Add(OrderLotItem.ORDER_NUMBER.IsEqualTo(_parent._parent._parent.POrderNumber));
                        OrderBy = OrderLotItem.SortByMOS_ORDER_LOT_ITEM_X1;
                        
                        #region Columns
                        
                        Columns.Add(OrderLotItem.ORDER_NUMBER);
                        #endregion
                    }
                    
                    /// <summary>Clear order lot item for order</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        Activity = Activities.Delete;
                    }
                    
                    
                }
                
                /// <summary>Regen Order Lot Item(P#487.9.5.2)</summary>
                // Last change before Migration: 20/11/2012 10:44:25
                class RegenOrderLotItem : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    DynamicSQLEntity sqlEntity;
                    
                    /// <summary>Order Lot Item</summary>
                    readonly Models.OrderLotItem OrderLotItem = new Models.OrderLotItem { AllowRowLocking = true };
                    #endregion
                    
                    #region Columns
                    
                    /// <summary>ORDER_NUMBER</summary>
                    readonly NumberColumn ORDER_NUMBER = new NumberColumn("ORDER_NUMBER", "N6")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>LOT_NUMBER</summary>
                    readonly TextColumn LOT_NUMBER = new TextColumn("LOT_NUMBER", "2")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>PRODUCT_NUMBER</summary>
                    readonly NumberColumn PRODUCT_NUMBER = new NumberColumn("PRODUCT_NUMBER", "N8")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>COLOUR_CODE</summary>
                    readonly NumberColumn COLOUR_CODE = new NumberColumn("COLOUR_CODE", "N4")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>SIZE_CODE</summary>
                    readonly NumberColumn SIZE_CODE = new NumberColumn("SIZE_CODE", "N4")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>DELIVERY_DATE</summary>
                    readonly DateColumn DELIVERY_DATE = new DateColumn("DELIVERY_DATE", "DD/MM/YYYY")
                    {
                    	AllowNull = true,
                    	Storage = new ENV.Data.Storage.DateTimeDateStorage()
                    };
                    
                    /// <summary>CENTURYWEEK</summary>
                    readonly NumberColumn CENTURYWEEK = new NumberColumn("CENTURYWEEK", "N6")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYORD</summary>
                    readonly NumberColumn QTYORD = new NumberColumn("QTYORD", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYDEL</summary>
                    readonly NumberColumn QTYDEL = new NumberColumn("QTYDEL", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYOS</summary>
                    readonly NumberColumn QTYOS = new NumberColumn("QTYOS", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>CREATE_USER</summary>
                    readonly TextColumn CREATE_USER = new TextColumn("CREATE_USER", "10")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>CREATE_DATE</summary>
                    readonly DateColumn CREATE_DATE = new DateColumn("CREATE_DATE", "DD/MM/YYYY")
                    {
                    	AllowNull = true,
                    	Storage = new ENV.Data.Storage.DateTimeDateStorage()
                    };
                    
                    /// <summary>CREATE_TIME</summary>
                    readonly NumberColumn CREATE_TIME = new NumberColumn("CREATE_TIME", "6");
                    
                    /// <summary>QTYUNAPPR</summary>
                    readonly NumberColumn QTYUNAPPR = new NumberColumn("QTYUNAPPR", "10.3")
                    {
                    	AllowNull = true
                    };
                    #endregion
                    
                    RefreshOrderLotItemOption _parent;
                    
                    
                    /// <summary>Regen Order Lot Item(P#487.9.5.2)</summary>
                    public RegenOrderLotItem(RefreshOrderLotItemOption parent)
                    {
                        _parent = parent;
                        Title = "Regen Order Lot Item";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        sqlEntity = new DynamicSQLEntity(Models.DataSources.MOS, 
@"select oli.order_number, oli.lot_number, oli.product_number, oli.colour_code, oli.size_code, 
       oli.delivery_date, oli.centuryweek,
       oli.qtyord, oli.qtydel, oli.qtyos,  
       oli.create_user, oli.create_date, oli.create_time, oli.qtyunappr
  from 
(           
(Select olp.order_number, olp.lot_number, w1.product_number, w1.colour_code, w1.size_code, 
       lot.delivery_date, dates.centuryweek,
       sum(case when ord.order_status > 0 then (w1.items_in_pack * olp.quantity_of_pack) else 0 end) qtyord,
       sum(w1.items_in_pack * olp.delivery_quantity) qtydel,
       sum(case when (    ord.order_status > 0 
                      and lot.ord_lot_complete_status = 0 
                      and olp.quantity_of_pack > olp.delivery_quantity)
                then (w1.items_in_pack * (olp.quantity_of_pack - olp.delivery_quantity)) else 0 end) qtyos, 
       ord.create_user, ord.create_date, ord.create_time, lot.last_update_usr_id, 
       lot.last_update_date, lot.last_update_time,
       sum(case when (    ord.order_status = 0 
                      and lot.ord_lot_complete_status = 0 
                      and olp.quantity_of_pack > olp.delivery_quantity)
                then (w1.items_in_pack * (olp.quantity_of_pack - olp.delivery_quantity)) else 0 end) qtyunappr                            
       from mackays.war_pack_makeup w1,
            mackays.shp_order_lot_packs olp,
            mackays.shp_orders ord,
            mackays.shp_lots lot,
            mackays.ref_date dates
       where w1.product_number = olp.product_number
         and w1.pack_code = olp.pack_code
         and olp.order_number = :1
         and olp.order_number = ord.order_number
         and olp.order_number = lot.order_number
         and olp.lot_number = lot.lot_number
         and (ord.order_status > 0 or lot.ord_lot_complete_status = 0)
         and olp.quantity_of_pack > 0
         and dates.centuryweek =
           (select min (centuryweek) from mackays.ref_date
           where week_ending_date =
                 (select min(dd.week_ending_date)
             from mackays.ref_date dd
           where week_ending_date    >= lot.delivery_date) )
group by olp.order_number, olp.lot_number, w1.product_number, w1.colour_code, w1.size_code, 
       lot.delivery_date, dates.centuryweek, 
       ord.create_user, ord.create_date, ord.create_time, 
       lot.last_update_usr_id, lot.last_update_date, lot.last_update_time)

union all
-- Production Bookings - Single piece, not Sized therefore use 9999
(Select olp.order_number, olp.lot_number, olp.product_number, pc.colour_code, 9999, 
        lot.delivery_date, dates.centuryweek,
        sum(case when ord.order_status > 0 then olp.quantity_of_pack else 0 end) qtyord,
        0  qtydel,
        sum(case when (    ord.order_status > 0 
                      and lot.ord_lot_complete_status = 0 
                      and olp.quantity_of_pack > olp.delivery_quantity)
                then (olp.quantity_of_pack - olp.delivery_quantity) else 0 end) qtyos, 
       ord.create_user, ord.create_date, ord.create_time, lot.last_update_usr_id, 
       lot.last_update_date, lot.last_update_time,
       sum(case when (    ord.order_status = 0 
                      and lot.ord_lot_complete_status = 0 
                      and olp.quantity_of_pack > olp.delivery_quantity)
                then (olp.quantity_of_pack - olp.delivery_quantity) else 0 end) qtyunappr 
       from mackays.shp_order_lot_packs olp,
            mackays.shp_orders ord,
            mackays.shp_lots lot,
            mackays.shp_product_colours pc,
            mackays.ref_date dates
      where olp.product_number = pc.product_number
        and olp.order_number = :1
        and olp.pack_type = 'Z'
        and olp.order_number = ord.order_number
        and olp.order_number = lot.order_number
        and olp.lot_number = lot.lot_number
        and (ord.order_status > 0 or lot.ord_lot_complete_status = 0)
        and olp.quantity_of_pack > 0
        and substr(olp.pack_code,1,1) = pc.colour_relative_position
         and dates.centuryweek =
           (select min (centuryweek) from mackays.ref_date
           where week_ending_date =
                 (select min(dd.week_ending_date)
             from mackays.ref_date dd
           where week_ending_date    >= lot.delivery_date) )
group by olp.order_number, olp.lot_number, olp.product_number, pc.colour_code, 
       lot.delivery_date, dates.centuryweek, 
       ord.create_user, ord.create_date, ord.create_time, 
       lot.last_update_usr_id, lot.last_update_date, lot.last_update_time) ) oli
order by oli.order_number, oli.lot_number");
                        sqlEntity.AddParameter(_parent._parent._parent.POrderNumber); //:1;
                        sqlEntity.Columns.Add(ORDER_NUMBER, LOT_NUMBER, PRODUCT_NUMBER, COLOUR_CODE, SIZE_CODE, DELIVERY_DATE, CENTURYWEEK, QTYORD, QTYDEL, QTYOS, CREATE_USER, CREATE_DATE, CREATE_TIME, QTYUNAPPR);
                        From = sqlEntity;
                        Relations.Add(OrderLotItem, RelationType.InsertIfNotFound, 
                        		OrderLotItem.ORDER_NUMBER.BindEqualTo(ORDER_NUMBER).And(
                        		OrderLotItem.LOT_NUMBER.BindEqualTo(LOT_NUMBER)).And(
                        		OrderLotItem.PRODUCT_NUMBER.BindEqualTo(PRODUCT_NUMBER)).And(
                        		OrderLotItem.COLOUR_CODE.BindEqualTo(COLOUR_CODE)).And(
                        		OrderLotItem.SIZE_CODE.BindEqualTo(SIZE_CODE)).And(
                        		OrderLotItem.DUE_DATE.BindEqualTo(DELIVERY_DATE)).And(
                        		OrderLotItem.DUE_WEEK.BindEqualTo(CENTURYWEEK)), 
                        	OrderLotItem.SortByMOS_ORDER_LOT_ITEM_X1);
                        
                        
                        #region Columns
                        
                        Columns.Add(ORDER_NUMBER);
                        Columns.Add(LOT_NUMBER);
                        Columns.Add(PRODUCT_NUMBER);
                        Columns.Add(COLOUR_CODE);
                        Columns.Add(SIZE_CODE);
                        Columns.Add(DELIVERY_DATE);
                        Columns.Add(CENTURYWEEK);
                        Columns.Add(QTYORD);
                        Columns.Add(QTYDEL);
                        Columns.Add(QTYOS);
                        Columns.Add(CREATE_USER);
                        Columns.Add(CREATE_DATE);
                        Columns.Add(CREATE_TIME);
                        Columns.Add(QTYUNAPPR);
                        
                        Columns.Add(OrderLotItem.ORDER_NUMBER);
                        Columns.Add(OrderLotItem.LOT_NUMBER);
                        Columns.Add(OrderLotItem.PRODUCT_NUMBER);
                        Columns.Add(OrderLotItem.COLOUR_CODE);
                        Columns.Add(OrderLotItem.SIZE_CODE);
                        Columns.Add(OrderLotItem.DUE_DATE);
                        Columns.Add(OrderLotItem.DUE_WEEK);
                        Columns.Add(OrderLotItem.QUANTITY_ORDERED).BindValue(QTYORD);
                        Columns.Add(OrderLotItem.QUANTITY_DELIVERED).BindValue(QTYDEL);
                        Columns.Add(OrderLotItem.QUANTITY_OUTSTANDING).BindValue(QTYOS);
                        Columns.Add(OrderLotItem.CREATE_BY).BindValue(CREATE_USER);
                        Columns.Add(OrderLotItem.CREATE_DATE).BindValue(CREATE_DATE);
                        Columns.Add(OrderLotItem.CREATE_TIME).BindValue(() => u.ToTime(CREATE_TIME));
                        Columns.Add(OrderLotItem.LAST_MODIFY_BY).BindValue(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name));
                        Columns.Add(OrderLotItem.LAST_MODIFY_DATE).BindValue(() => Date.Now);
                        Columns.Add(OrderLotItem.LAST_MODIFY_TIME).BindValue(() => Time.Now);
                        Columns.Add(OrderLotItem.QUANTITY_UNAPPROVED).BindValue(QTYUNAPPR);
                        #endregion
                    }
                    
                    /// <summary>Regen Order Lot Item</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                    }
                    
                    
                }
                
                /// <summary>Clear order lot option for ord(P#487.9.5.3)</summary>
                // Last change before Migration: 20/11/2012 10:44:30
                class ClearOrderLotOptionForOrd : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Order Lot Option</summary>
                    readonly Models.OrderLotOption OrderLotOption = new Models.OrderLotOption { AllowRowLocking = true };
                    #endregion
                    
                    RefreshOrderLotItemOption _parent;
                    
                    
                    /// <summary>Clear order lot option for ord(P#487.9.5.3)</summary>
                    public ClearOrderLotOptionForOrd(RefreshOrderLotItemOption parent)
                    {
                        _parent = parent;
                        Title = "Clear order lot option for ord";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        From = OrderLotOption;
                        Where.Add(OrderLotOption.ORDER_NUMBER.IsEqualTo(_parent._parent._parent.POrderNumber));
                        OrderBy = OrderLotOption.SortByMOS_ORD_LOT_OPTION_X1;
                        
                        #region Columns
                        
                        Columns.Add(OrderLotOption.ORDER_NUMBER);
                        #endregion
                    }
                    
                    /// <summary>Clear order lot option for ord</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        Activity = Activities.Delete;
                        AllowUserAbort = true;
                    }
                    
                    
                }
                
                /// <summary>Regen Order Lot Option(P#487.9.5.4)</summary>
                // Last change before Migration: 20/11/2012 10:44:38
                class RegenOrderLotOption : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    DynamicSQLEntity sqlEntity;
                    
                    /// <summary>Order Lot Option</summary>
                    readonly Models.OrderLotOption OrderLotOption = new Models.OrderLotOption { AllowRowLocking = true };
                    #endregion
                    
                    #region Columns
                    
                    /// <summary>ORDER_NUMBER</summary>
                    readonly NumberColumn ORDER_NUMBER = new NumberColumn("ORDER_NUMBER", "N6")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>LOT_NUMBER</summary>
                    readonly TextColumn LOT_NUMBER = new TextColumn("LOT_NUMBER", "2")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>PRODUCT_NUMBER</summary>
                    readonly NumberColumn PRODUCT_NUMBER = new NumberColumn("PRODUCT_NUMBER", "N8")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>COLOUR_CODE</summary>
                    readonly NumberColumn COLOUR_CODE = new NumberColumn("COLOUR_CODE", "N4")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYORD</summary>
                    readonly NumberColumn QTYORD = new NumberColumn("QTYORD", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYDEL</summary>
                    readonly NumberColumn QTYDEL = new NumberColumn("QTYDEL", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYOUT</summary>
                    readonly NumberColumn QTYOUT = new NumberColumn("QTYOUT", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>QTYUNAP</summary>
                    readonly NumberColumn QTYUNAP = new NumberColumn("QTYUNAP", "10.3")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>MIN(T.CREATE_DATE)</summary>
                    readonly DateColumn MINTCREATE_DATE = new DateColumn("MIN(T.CREATE_DATE)", "DD/MM/YYYY")
                    {
                    	AllowNull = true,
                    	Storage = new ENV.Data.Storage.DateTimeDateStorage()
                    };
                    
                    /// <summary>MIN(T.CREATE_TIME)</summary>
                    readonly TextColumn MINTCREATE_TIME = new TextColumn("MIN(T.CREATE_TIME)", "6")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>MAX(T.LAST_MODIFY_DATE)</summary>
                    readonly DateColumn MAXTLAST_MODIFY_DATE = new DateColumn("MAX(T.LAST_MODIFY_DATE)", "DD/MM/YYYY")
                    {
                    	AllowNull = true,
                    	Storage = new ENV.Data.Storage.DateTimeDateStorage()
                    };
                    
                    /// <summary>MAX(T.LAST_MODIFY_TIME)</summary>
                    readonly TextColumn MAXTLAST_MODIFY_TIME = new TextColumn("MAX(T.LAST_MODIFY_TIME)", "6")
                    {
                    	AllowNull = true
                    };
                    
                    /// <summary>CREATE_BY</summary>
                    readonly TextColumn CREATE_BY = new TextColumn("CREATE_BY", "10")
                    {
                    	AllowNull = true
                    };
                    #endregion
                    
                    RefreshOrderLotItemOption _parent;
                    
                    
                    /// <summary>Regen Order Lot Option(P#487.9.5.4)</summary>
                    public RegenOrderLotOption(RefreshOrderLotItemOption parent)
                    {
                        _parent = parent;
                        Title = "Regen Order Lot Option";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        sqlEntity = new DynamicSQLEntity(Models.DataSources.MOS, 
@"select t.order_number,
       t.lot_number,
       t.product_number,
       t.colour_code,
       sum(t.quantity_ordered) qtyord,
       sum(t.quantity_delivered) qtydel,
       sum(t.quantity_outstanding) qtyout,
       sum(t.quantity_unapproved) qtyunap,
       min(t.create_date),
       min(t.create_time),
       max(t.last_modify_date),
       max(t.last_modify_time),
       t.create_by

  from mos_order_lot_item t

 where t.order_number = :1

 group by t.order_number,
          t.lot_number,
          t.product_number,
          t.colour_code,
          t.create_by

 order by t.order_number, t.lot_number, t.product_number, t.colour_code");
                        sqlEntity.AddParameter(_parent._parent._parent.POrderNumber); //:1;
                        sqlEntity.Columns.Add(ORDER_NUMBER, LOT_NUMBER, PRODUCT_NUMBER, COLOUR_CODE, QTYORD, QTYDEL, QTYOUT, QTYUNAP, MINTCREATE_DATE, MINTCREATE_TIME, MAXTLAST_MODIFY_DATE, MAXTLAST_MODIFY_TIME, CREATE_BY);
                        From = sqlEntity;
                        Relations.Add(OrderLotOption, RelationType.InsertIfNotFound, 
                        		OrderLotOption.ORDER_NUMBER.BindEqualTo(ORDER_NUMBER).And(
                        		OrderLotOption.LOT_NUMBER.BindEqualTo(LOT_NUMBER)).And(
                        		OrderLotOption.PRODUCT_NUMBER.BindEqualTo(PRODUCT_NUMBER)).And(
                        		OrderLotOption.COLOUR_CODE.BindEqualTo(COLOUR_CODE)), 
                        	OrderLotOption.SortByMOS_ORD_LOT_OPTION_X1);
                        
                        
                        #region Columns
                        
                        Columns.Add(ORDER_NUMBER);
                        Columns.Add(LOT_NUMBER);
                        Columns.Add(PRODUCT_NUMBER);
                        Columns.Add(COLOUR_CODE);
                        Columns.Add(QTYORD);
                        Columns.Add(QTYDEL);
                        Columns.Add(QTYOUT);
                        Columns.Add(QTYUNAP);
                        Columns.Add(MINTCREATE_DATE);
                        Columns.Add(MINTCREATE_TIME);
                        Columns.Add(MAXTLAST_MODIFY_DATE);
                        Columns.Add(MAXTLAST_MODIFY_TIME);
                        Columns.Add(CREATE_BY);
                        
                        Columns.Add(OrderLotOption.ORDER_NUMBER);
                        Columns.Add(OrderLotOption.LOT_NUMBER);
                        Columns.Add(OrderLotOption.PRODUCT_NUMBER);
                        Columns.Add(OrderLotOption.COLOUR_CODE);
                        Columns.Add(OrderLotOption.QTY_ORDERED).BindValue(QTYORD);
                        Columns.Add(OrderLotOption.QTY_DELIVERED).BindValue(QTYDEL);
                        Columns.Add(OrderLotOption.QUANTITY_OUTSTANDING).BindValue(QTYOUT);
                        Columns.Add(OrderLotOption.QUANTITY_UNAPPROVED).BindValue(QTYUNAP);
                        Columns.Add(OrderLotOption.CREATE_USER).BindValue(CREATE_BY);
                        Columns.Add(OrderLotOption.CREATE_DATE).BindValue(MINTCREATE_DATE);
                        Columns.Add(OrderLotOption.CREATE_TIME).BindValue(() => u.TVal(MINTCREATE_TIME, "HH:MM:SS"));
                        Columns.Add(OrderLotOption.LAST_UPDATE_USER).BindValue(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name));
                        Columns.Add(OrderLotOption.LAST_UPDATE_DATE).BindValue(() => Date.Now);
                        Columns.Add(OrderLotOption.LAST_UPDATE_TIME).BindValue(() => Time.Now);
                        #endregion
                    }
                    
                    /// <summary>Regen Order Lot Option</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    
                    
                }
            }
            
            /// <summary>Update Placeholder(P#487.9.6)</summary>
            // Last change before Migration: 20/11/2012 10:44:48
            class UpdatePlaceholder : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>PLN_RP_STYLE</summary>
                readonly Models.PLN_RP_STYLE PLN_RP_STYLE = new Models.PLN_RP_STYLE { ReadOnly = true };
                
                /// <summary>Colour</summary>
                readonly Models.Colour Colour = new Models.Colour { ReadOnly = true };
                
                /// <summary>Colour</summary>
                readonly Models.Colour Colour1 = new Models.Colour { ReadOnly = true };
                #endregion
                
                FindColourChanges _parent;
                
                
                /// <summary>Update Placeholder(P#487.9.6)</summary>
                public UpdatePlaceholder(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Update Placeholder";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(PLN_RP_STYLE, 
                    		PLN_RP_STYLE.STYLE_CODE.IsEqualTo(_parent._parent.PStyleCode).And(
                    		PLN_RP_STYLE.ORDER_NUMBER.IsEqualTo(_parent._parent.POrderNumber)).And(
                    		PLN_RP_STYLE.PRODUCT1.IsEqualTo(_parent._parent.PProductNumber)), 
                    	PLN_RP_STYLE.SortByPLN_RP_STYLE_X1);
                    
                    Relations.Add(Colour, 
                    		Colour.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.OriginalColour), 
                    	Colour.SortByREF_Colour_X1);
                    
                    Relations.Add(Colour1, 
                    		Colour1.ColourCode.IsEqualTo(_parent.ModifyColourWorkfile.ColourCode), 
                    	Colour1.SortByREF_Colour_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(PLN_RP_STYLE.INTAKE_SEASON);
                    Columns.Add(PLN_RP_STYLE.PLNSUBRANGE);
                    Columns.Add(PLN_RP_STYLE.STYLE_CODE);
                    Columns.Add(PLN_RP_STYLE.ORDER_NUMBER);
                    Columns.Add(PLN_RP_STYLE.PRODUCT1);
                    Columns.Add(PLN_RP_STYLE.PRODUCT_SEQ);
                    
                    // Original colour
                    Columns.Add(Colour.ColourCode);
                    Columns.Add(Colour.ColourDescription).Caption = "Colour Description old";
                    
                    // New colour
                    Columns.Add(Colour1.ColourCode);
                    Columns.Add(Colour1.ColourDescription).Caption = "Colour Description new";
                    #endregion
                }
                
                /// <summary>Update Placeholder</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    Cached<WriteNewColour>().Run();
                }
                
                
                
                /// <summary>Write new colour(P#487.9.6.1)</summary>
                // Last change before Migration: 20/11/2012 10:44:47
                class WriteNewColour : Mos.BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>PLN_RP_PLACEHOLDER</summary>
                    readonly Models.PLN_RP_PLACEHOLDER PLN_RP_PLACEHOLDER = new Models.PLN_RP_PLACEHOLDER { AllowRowLocking = true };
                    #endregion
                    
                    UpdatePlaceholder _parent;
                    
                    
                    /// <summary>Write new colour(P#487.9.6.1)</summary>
                    public WriteNewColour(UpdatePlaceholder parent)
                    {
                        _parent = parent;
                        Title = "Write new colour";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        Relations.Add(PLN_RP_PLACEHOLDER, 
                        		PLN_RP_PLACEHOLDER.INTAKE_SEASON.IsEqualTo(_parent.PLN_RP_STYLE.INTAKE_SEASON).And(
                        		PLN_RP_PLACEHOLDER.PLNSUBRANGE.IsEqualTo(_parent.PLN_RP_STYLE.PLNSUBRANGE)).And(
                        		PLN_RP_PLACEHOLDER.PRODUCT_SEQ.IsEqualTo(_parent.PLN_RP_STYLE.PRODUCT_SEQ)).And(
                        		PLN_RP_PLACEHOLDER.COLOUR1.IsEqualTo(_parent.Colour.ColourDescription)), 
                        	PLN_RP_PLACEHOLDER.SortByPLN_RP_PLACEHOLDER_X1);
                        
                        
                        #region Columns
                        
                        Columns.Add(PLN_RP_PLACEHOLDER.INTAKE_SEASON);
                        Columns.Add(PLN_RP_PLACEHOLDER.PLNSUBRANGE);
                        Columns.Add(PLN_RP_PLACEHOLDER.PLACEHOLDER_OPTION);
                        Columns.Add(PLN_RP_PLACEHOLDER.PRODUCT_SEQ);
                        Columns.Add(PLN_RP_PLACEHOLDER.COLOUR1);
                        #endregion
                    }
                    
                    /// <summary>Write new colour</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    protected override void OnLoad()
                    {
                        Exit(ExitTiming.AfterRow);
                        RowLocking = LockingStrategy.OnRowLoading;
                        TransactionScope = TransactionScopes.Task;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        PLN_RP_PLACEHOLDER.COLOUR1.Value = _parent.Colour1.ColourDescription;
                    }
                    
                    
                }
            }
            
            /// <summary>Write Franch Colour Amendments(P#487.9.7)</summary>
            // Last change before Migration: 23/01/2013 12:40:36
            class WriteFranchColourAmendments : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Franchise Colour Amendments</summary>
                readonly Models.FranchiseColourAmendments FranchiseColourAmendments = new Models.FranchiseColourAmendments { AllowRowLocking = true };
                #endregion
                
                FindColourChanges _parent;
                
                
                /// <summary>Write Franch Colour Amendments(P#487.9.7)</summary>
                public WriteFranchColourAmendments(FindColourChanges parent)
                {
                    _parent = parent;
                    Title = "Write Franch Colour Amendments";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(FranchiseColourAmendments, RelationType.Insert, 
                    	FranchiseColourAmendments.SortByMOS_FRA_COL_AMEND_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(FranchiseColourAmendments.LineListNumber).BindValue(_parent.LineListOrder.LineListNumber);
                    Columns.Add(FranchiseColourAmendments.ProductNumber).BindValue(_parent._parent.PProductNumber);
                    Columns.Add(FranchiseColourAmendments.ColourRelativePosition).BindValue(_parent.ProductColours.ColourRelativePosition);
                    Columns.Add(FranchiseColourAmendments.AuditVersion).BindValue(() => u.If(_parent.RCAuditRecordFound, _parent.FranchiseColourAmendments.AuditVersion + 1, 0));
                    Columns.Add(FranchiseColourAmendments.ColourCode).BindValue(_parent.ModifyColourWorkfile.ColourCode);
                    Columns.Add(FranchiseColourAmendments.CreateUser).BindValue(() => u.Trim(u.Upper(ENV.Security.UserManager.CurrentUser.Name)));
                    Columns.Add(FranchiseColourAmendments.CreateDate).BindValue(() => Date.Now);
                    Columns.Add(FranchiseColourAmendments.CreateTime).BindValue(() => Time.Now);
                    #endregion
                }
                
                /// <summary>Write Franch Colour Amendments</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    RowLocking = LockingStrategy.OnRowLoading;
                    TransactionScope = TransactionScopes.Task;
                    AllowUserAbort = true;
                }
                
                
            }
        }
        
        /// <summary>Store prices(P#487.10)</summary>
        // Last change before Migration: 20/11/2012 10:45:06
        class StorePrices : Mos.BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>Product Sizes</summary>
            readonly Models.ProductSizes ProductSizes = new Models.ProductSizes { ReadOnly = true };
            
            /// <summary>Prod Size Price Workfile</summary>
            readonly Models.ProdSizePriceWorkfile ProdSizePriceWorkfile = new Models.ProdSizePriceWorkfile { AllowRowLocking = true };
            #endregion
            
            MaintModColSizePo2071Core _parent;
            
            
            /// <summary>Store prices(P#487.10)</summary>
            public StorePrices(MaintModColSizePo2071Core parent)
            {
                _parent = parent;
                Title = "Store prices";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                From = ProductSizes;
                Relations.Add(ProdSizePriceWorkfile, RelationType.InsertIfNotFound, 
                		ProdSizePriceWorkfile.ProductNumber.BindEqualTo(_parent.PProductNumber).And(
                		ProdSizePriceWorkfile.SizeCode.BindEqualTo(ProductSizes.SizeCode)), 
                	ProdSizePriceWorkfile.SortByMOS_PROD_SIZE_PRICE_WRK_X1);
                
                Where.Add(ProductSizes.ProductNumber.IsEqualTo(_parent.PProductNumber));
                OrderBy = ProductSizes.SortBySHP_Product_Sizes_X1;
                
                #region Columns
                
                Columns.Add(ProductSizes.ProductNumber);
                Columns.Add(ProductSizes.SizeCode);
                Columns.Add(ProductSizes.SellingPrice);
                
                Columns.Add(ProdSizePriceWorkfile.ProductNumber);
                Columns.Add(ProdSizePriceWorkfile.SizeCode);
                Columns.Add(ProdSizePriceWorkfile.SellingPrice);
                #endregion
            }
            
            /// <summary>Store prices</summary>
            internal void Run()
            {
                Execute();
            }
            protected override void OnLoad()
            {
                RowLocking = LockingStrategy.OnRowLoading;
                TransactionScope = TransactionScopes.Task;
                AllowUserAbort = true;
            }
            protected override void OnStart()
            {
                Cached<clearWorkfile>().Run();
            }
            protected override void OnLeaveRow()
            {
                ProdSizePriceWorkfile.SellingPrice.Value = ProductSizes.SellingPrice;
            }
            
            
            
            /// <summary>clear workfile(P#487.10.1)</summary>
            // Last change before Migration: 20/11/2012 10:45:05
            class clearWorkfile : Mos.BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Prod Size Price Workfile</summary>
                readonly Models.ProdSizePriceWorkfile ProdSizePriceWorkfile = new Models.ProdSizePriceWorkfile { AllowRowLocking = true };
                #endregion
                
                
                /// <summary>clear workfile(P#487.10.1)</summary>
                public clearWorkfile()
                {
                    Title = "clear workfile";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = ProdSizePriceWorkfile;
                    OrderBy = ProdSizePriceWorkfile.SortByMOS_PROD_SIZE_PRICE_WRK_X1;
                    
                    #region Columns
                    
                    Columns.Add(ProdSizePriceWorkfile.ProductNumber);
                    Columns.Add(ProdSizePriceWorkfile.SizeCode);
                    Columns.Add(ProdSizePriceWorkfile.SellingPrice);
                    #endregion
                }
                
                /// <summary>clear workfile</summary>
                internal void Run()
                {
                    Execute();
                }
                protected override void OnLoad()
                {
                    Activity = Activities.Delete;
                    AllowUserAbort = true;
                }
                
                
            }
        }
    }
}
