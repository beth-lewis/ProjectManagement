using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePalClassLibrary
{
  
    public class clsContracts
    {

        //private Data member for ContractType Property
        private string mContractType;

        //public property for Contract Type
        public string ContractType
        {
            get
            {
                //return the private data
                return mContractType;
            }
            set
            {
                //set the private data 
                mContractType = value;
            }
        }

        //private Data member for Data Allowance Property
        private string mDataAllowance;

        //public property for Data Allowance
        public string DataAllowance
        {
            get
            {
                //return the private data
                return mDataAllowance;
            }
            set
            {
                //set the private data 
                mDataAllowance = value;
            }
        }
        //private Data member for Number Of Minutes Property
        private string mNumberOfMinutes;

        //public property for Number Of Minutes
        public string NumberOfMinutes
        {
            get
            {
                //return the private data
                return mNumberOfMinutes;
            }
            set
            {
                //set the private data 
                mNumberOfMinutes = value;
            }
        }
        //private Data member for Number Of Texts Property
        private string mNumberOfTexts;

        //public property for Number Of Texts
        public string NumberOfTexts
        {
            get
            {
                //return the private data
                return mNumberOfTexts;
            }
            set
            {
                //set the private data 
                mNumberOfTexts = value;
            }
        }

        //private Data member for Price Per Month Property
        private decimal mPricePerMonth;

        //public property for Price Per Month
        public decimal PricePerMonth
        {
            get
            {
                //return the private data
                return mPricePerMonth;
            }
            set
            {
                //set the private data 
                mPricePerMonth = value;
            }
        }

        //private Data member for Contract No Property
        private Int32 mContractNo;

        //public property for Contract No
        public int ContractNo
        {
            get
            {
                //return the private data
                return mContractNo;
            }
            set
            {
                //set the private data 
                mContractNo = value;
            }
        }

        //private Data member for Customer No Property
        private Int32 mCustomerNo;

        //public property for Customer No
        public int CustomerNo
        {
            get
            {
                //return the private data
                return mCustomerNo;
            }
            set
            {
                //set the private data 
                mCustomerNo = value;
            }
        }

        //private Data member for Manufacturer No Property
        private Int32 mManufacturerNo;

        //public property for Manufacturer No
        public int ManufacturerNo
        {
            get
            {
                //return the private data
                return mManufacturerNo;
            }
            set
            {
                //set the private data 
                mManufacturerNo = value;
            }
        }
        //private Data member for Duration Property
        private string mDuration;

        //public property for Duration
        public string Duration
        {
            get
            {
                //return the private data
                return mDuration;
            }
            set
            {
                //set the private data 
                mDuration = value;
            }
        }

        //private Data member for Staff No Property
        private Int32 mStaffNo;

        //public property for Staff No
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set the private data
                mStaffNo = value;
            }
        }

        //private Data member for Start Date Property
        private DateTime mStartDate;

        //public property for Start Date
        public DateTime StartDate
        {
            get
            {
                //return the private data
                return mStartDate;
            }
            set
            {
                //set the private data
                mStartDate = value;
            }
        }
        public bool Find( int ContractNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the contract no to search for
            DB.AddParameter("@ContractNo", ContractNo);
            //execute the stored procedure
            DB.Execute("sproc_tblContracts_FilterByContractNo");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mContractNo = Convert.ToInt32(DB.DataTable.Rows[0]["ContractNo"]);
                mContractType = Convert.ToString(DB.DataTable.Rows[0]["ContractType"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mDataAllowance = Convert.ToString(DB.DataTable.Rows[0]["DataAllowance"]);
                mDuration = Convert.ToString(DB.DataTable.Rows[0]["Duration"]);
                mManufacturerNo = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturerNo"]);
                mNumberOfMinutes = Convert.ToString(DB.DataTable.Rows[0]["NumberOfMinutes"]);
                mNumberOfTexts = Convert.ToString(DB.DataTable.Rows[0]["NumberOfTexts"]);
                mPricePerMonth = Convert.ToDecimal(DB.DataTable.Rows[0]["PricePerMonth"]);
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string SomeContractType,
                            string SomeDataAllowance, 
                            string SomeNumberOfMinutes,
                            string SomeNumberOfTexts,
                            string SomePricePerMonth, 
                            string SomeDuration,
                            string TheStartDate,
                            string SomeStaffNo,
                            string SomeManufacturerNo,
                            string SomeCustomerNo)

        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the name of the contract type is blank
            if (SomeContractType == "")
            {
                //record the error
                Error = Error + "The Contract Type May Not Be Blank";
            }
            //if the name of the contract type is more than 30 characters 
            if (SomeContractType.Length > 30)
            {
                //record the error
                Error = Error + "The Contract Type must be less than 30 characters";
            }
            //if data allowance is blank
            if (SomeDataAllowance == "")
            {
                //record the error
                Error = Error + "The Data Allowance May Not Be Blank";
            }
            //if the name of the data allowance is more than 10 characters 
            if (SomeDataAllowance.Length > 10)
            {
                //record the error
                Error = Error + "The Data Allowance must be less than 10 characters";
            }
            //if number of minutes is blank
            if (SomeNumberOfMinutes == "")
            {
                //record an error
                Error = Error + "Number of Minutes Can't Be Blank";
            }
            //if the name of number of minutes  is more than 50 characters 
            if (SomeNumberOfMinutes.Length > 50)
            {
                //record the error
                Error = Error + "The Number of Minutes must be less than 50 characters";
            }
            //if number of texts is blank
            if (SomeNumberOfTexts == "")
            {
                //record an error
                Error = Error + "Number of Texts Can't Be Blank";
            }
            //if the name of Number of Texts is more than 50 characters 
            if (SomeNumberOfTexts.Length > 50)
            {
                //record the error
                Error = Error + "The Number of Texts must be less than 50 characters";
            }
            //if price of month is equal to zero
            if (Convert.ToDecimal( SomePricePerMonth) == 0)
            {
                //record an error
                Error = Error + "Price Per Month Cannot Be £0";
            }
            //if the number is higher than 9999 for price per month
            if (Convert.ToDecimal(SomePricePerMonth) > 9999)
            {
                //record an error
                Error = Error + "Price Per Month Cannot Be £9999";
            }
            //if duration is blank
            if (SomeDuration == "")
            {
                //record the error
                Error = Error + "The Duration cannot Be Blank";
            }
            //if the name of duration is less than 6 characters
            if (SomeDuration.Length < 6)
            {
                //record the error
                Error = Error + "The Duration must be more than 6 characters";
            }
            //if the name of duration is more than 11 characters
            if (SomeDuration.Length > 20)
            {
                //record the error
                Error = Error + "The Duration must be less than 20 characters";
            }
            //if StafNo is blank
            if (SomeStaffNo == "")
            {
                //record the error
                Error = Error + "The Staff No cannot Be Blank";
            }
            //if CustomerNo is blank
            if (SomeCustomerNo == "")
            {
                //record the error
                Error = Error + "The Customer No cannot Be Blank";
            }
            //if ManufacturerNo is blank
            if (SomeManufacturerNo == "")
            {
                //record the error
                Error = Error + "The ManufacturerNo cannot Be Blank";
            }

            try { 
            //copy the the startDate Value to the DateTemp Variable
            DateTemp = Convert.ToDateTime(TheStartDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
        }
        catch
        {
                //record the error
                Error = Error + "The Date was not a valid date";
        }
            //return any error messages
            return Error + "";
        }
        



}
    
    }
