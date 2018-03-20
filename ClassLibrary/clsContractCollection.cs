using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhonePalClassLibrary
{
    public class clsContractCollection
    {
        //private data member for the list
        List<clsContracts> mContractList = new List<clsContracts>();
        //private data member thisContract
        clsContracts mThisContract = new clsContracts();
        //private data member for the allContracts list
        private List<clsContracts> mAllContracts = new List<clsContracts>();
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
                AContract.contractNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ContractNo"]);
                AContract.contractType = Convert.ToString(DB.DataTable.Rows[Index]["ContractType"]);
                AContract.customerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AContract.dataAllowance = Convert.ToString(DB.DataTable.Rows[Index]["DataAllowance"]);
                AContract.duration = Convert.ToString(DB.DataTable.Rows[Index]["Duration"]);
                AContract.manufacturerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ManufacturerNo"]);
                AContract.numberOfMinutes = Convert.ToString(DB.DataTable.Rows[Index]["NumberOfMinutes"]);
                AContract.numberOfTexts = Convert.ToString(DB.DataTable.Rows[Index]["NumberOfTexts"]);
                AContract.pricePerMonth = Convert.ToDecimal(DB.DataTable.Rows[Index]["PricePerMonth"]);
                AContract.staffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AContract.startDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //add the record to the private data member
                mContractList.Add(AContract);
                //point at the next record
                Index++;

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