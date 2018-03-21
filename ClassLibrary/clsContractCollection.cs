using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhonePalClassLibrary
{
    public class clsContractCollection
    {
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //private data member for the list
        List<clsContracts> mContractList = new List<clsContracts>();
        //private data member thisContract
        clsContracts mThisContract = new clsContracts();
        //private data member for the allContracts list
        private List<clsContracts> mAllContracts = new List<clsContracts>();
      
        public int Add()
        {
            //adds a new record to the database based on the values of mThisContract
            //set the parameters for the stored procedure
            DB.AddParameter("@ContractType", mThisContract.ContractType);//parameter for Contract Type
            DB.AddParameter("@CustomerNo", mThisContract.CustomerNo);//parameter for CustomerNo
            DB.AddParameter("@DataAllowance", mThisContract.DataAllowance);//parameter for Data Allowance
            DB.AddParameter("@Duration", mThisContract.Duration);//parameter for Duration
            DB.AddParameter("@ManufacturerNo", mThisContract.ManufacturerNo);//parameter for Manufacturer No 
            DB.AddParameter("@NumberOfMinutes", mThisContract.NumberOfMinutes);//parameter for Number Of Minutes
            DB.AddParameter("@NumberOfTexts", mThisContract.NumberOfTexts);//parameter for Number Of Texts
            DB.AddParameter("@PricePerMonth", mThisContract.PricePerMonth);//parameter for Price Per Month
            DB.AddParameter("@StaffNo", mThisContract.StaffNo);//parameter for StaffNo
            DB.AddParameter("@StartDate", mThisContract.StartDate);//parameter for Start Date
            //execute the query return the primary key value
            return DB.Execute("sproc_tblContracts_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed by ThisContract
            //set the parameters
            DB.AddParameter("@ContractNo", mThisContract.ContractNo);
            //execute the stored procedure
            DB.Execute("sproc_tblContracts_Delete");
        }

        public void Update()
        {

        }
        //public constructor for the class        
        public clsContractCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblContracts_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank contract 
                clsContracts AContract = new clsContracts();
                //read in the fields from the current record
                AContract.ContractNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ContractNo"]);
                AContract.ContractType = Convert.ToString(DB.DataTable.Rows[Index]["ContractType"]);
                AContract.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AContract.DataAllowance = Convert.ToString(DB.DataTable.Rows[Index]["DataAllowance"]);
                AContract.Duration = Convert.ToString(DB.DataTable.Rows[Index]["Duration"]);
                AContract.ManufacturerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ManufacturerNo"]);
                AContract.NumberOfMinutes = Convert.ToString(DB.DataTable.Rows[Index]["NumberOfMinutes"]);
                AContract.NumberOfTexts = Convert.ToString(DB.DataTable.Rows[Index]["NumberOfTexts"]);
                AContract.PricePerMonth = Convert.ToDecimal(DB.DataTable.Rows[Index]["PricePerMonth"]);
                AContract.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AContract.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //add the record to the private data member
                mContractList.Add(AContract);
                //point at the next record
                Index++;

            }
        }
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mContractList.Count;
            }
            set
            {

            }
        }
        public List<clsContracts> AllContracts
        {
            get
            {
                //return the private data
                return mAllContracts;
            }
            set
            {
                mAllContracts = value;
            }
        }
            

        public List<clsContracts> ContractList
        {
            get
            {
                //return the private data
                return mContractList;
            }
            set
            {
                //set the private data
                mContractList = value;
            }
        }
        //public property for ThisContract
        public clsContracts ThisContract
        {
            get
            {
                //return the private data member 
                return mThisContract;
            }
            set
            {
                //set the private data
                mThisContract = value;
            }
        }
    }
}