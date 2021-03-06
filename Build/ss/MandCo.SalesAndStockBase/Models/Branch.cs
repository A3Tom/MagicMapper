﻿using Firefly.Box;
using ENV.Data;
namespace MandCo.SalesAndStock.Models
{
    /// <summary>Branch(E#1)</summary>
    public class Branch : OracleEntity 
    {
        
        #region Columns
        /// <summary>Branch Number</summary>
        public readonly Types.BranchNumber BranchNumber = new Types.BranchNumber
        {
        	Name = "Branch_Number"
        };
        /// <summary>Branch Name</summary>
        public readonly Types.Alpha20 BranchName = new Types.Alpha20
        {
        	Caption = "Branch Name",
        	Name = "Branch_Name"
        };
        /// <summary>Company Number</summary>
        public readonly Types.CompanyNumber CompanyNumber = new Types.CompanyNumber
        {
        	Name = "Company_Number"
        };
        /// <summary>Stock Company Number</summary>
        public readonly Types.CompanyNumber StockCompanyNumber = new Types.CompanyNumber
        {
        	Caption = "Stock Company Number",
        	Name = "Stock_Company_Number"
        };
        /// <summary>Area Code</summary>
        public readonly Types.AreaCode AreaCode = new Types.AreaCode
        {
        	Name = "Area_Code"
        };
        /// <summary>Branch Address 1</summary>
        public readonly Types.Alpha30 BranchAddress1 = new Types.Alpha30
        {
        	Caption = "Branch Address 1",
        	Name = "Branch_Address_1"
        };
        /// <summary>Branch Address 2</summary>
        public readonly Types.Alpha30 BranchAddress2 = new Types.Alpha30
        {
        	Caption = "Branch Address 2",
        	Name = "Branch_Address_2"
        };
        /// <summary>Branch Address 3</summary>
        public readonly Types.Alpha30 BranchAddress3 = new Types.Alpha30
        {
        	Caption = "Branch Address 3",
        	Name = "Branch_Address_3"
        };
        /// <summary>Branch Address 4</summary>
        public readonly Types.Alpha30 BranchAddress4 = new Types.Alpha30
        {
        	Caption = "Branch Address 4",
        	Name = "Branch_Address_4"
        };
        /// <summary>Branch Status</summary>
        public readonly Types.BranchStatus BranchStatus = new Types.BranchStatus
        {
        	Name = "Branch_Status"
        };
        /// <summary>Effective Date</summary>
        public readonly Types.Date1 EffectiveDate = new Types.Date1
        {
        	Caption = "Effective Date",
        	Name = "Effective_Date",
        	Storage = new ENV.Data.Storage.DateTimeDateStorage()
        };
        /// <summary>Manager Name</summary>
        public readonly Types.Alpha30 ManagerName = new Types.Alpha30
        {
        	Caption = "Manager Name",
        	Name = "Manager_Name"
        };
        /// <summary>Telephone Number</summary>
        public readonly Types.TelephoneNumber TelephoneNumber = new Types.TelephoneNumber
        {
        	Name = "Telephone_Number"
        };
        /// <summary>Number of Tills</summary>
        public readonly Types.NumberOfTills NumberOfTills = new Types.NumberOfTills
        {
        	Name = "Number_of_Tills"
        };
        /// <summary>EPoS Software Release</summary>
        public readonly Types.EPoSSoftwareRelease EPoSSoftwareRelease = new Types.EPoSSoftwareRelease
        {
        	Name = "EPoS_Software_Release"
        };
        /// <summary>Wage Cost</summary>
        public readonly Types.WageCost WageCost = new Types.WageCost
        {
        	Name = "Wage_Cost"
        };
        /// <summary>Staff Discount pcent</summary>
        public readonly Types.StaffDiscountPcent StaffDiscountPcent = new Types.StaffDiscountPcent
        {
        	Name = "Staff_Discount_pcent"
        };
        /// <summary>Commission Rate</summary>
        public readonly Types.CommissionRate CommissionRate = new Types.CommissionRate
        {
        	Name = "Commission_Rate"
        };
        #endregion
        
        #region Indexes
        /// <summary>REF_Branch_X1</summary>
        public readonly Index SortByREF_Branch_X1 = new Index
        {
        	Caption = "REF_Branch_X1",
        	Name = "REF_Branch_X1",
        	AutoCreate = true,
        	Unique = true
        };
        /// <summary>REF_Branch_X2</summary>
        public readonly Index SortByREF_Branch_X2 = new Index
        {
        	Caption = "REF_Branch_X2",
        	Name = "REF_Branch_X2",
        	AutoCreate = true,
        	Unique = true
        };
        /// <summary>REF_Branch_X3</summary>
        public readonly Index SortByREF_Branch_X3 = new Index
        {
        	Caption = "REF_Branch_X3",
        	Name = "REF_Branch_X3",
        	AutoCreate = true,
        	Unique = true
        };
        #endregion
        
        public Branch():base("REF_Branch", "Branch", DataSources.Ref1)
        {
            Cached = false;
            UseRowIdAsPrimaryKey();
            InitializeIndexes();
        }
        void InitializeIndexes()
        {
            SortByREF_Branch_X1.Add(BranchNumber);
            
            SortByREF_Branch_X2.Add(AreaCode, BranchNumber);
            
            SortByREF_Branch_X3.Add(CompanyNumber, BranchNumber);
            
        }
        
        
    }
}
