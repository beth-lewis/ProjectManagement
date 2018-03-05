using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePalClassLibrary
{
    public class clsContracts
    {
        public string contractType { get; set; }//property for Contract Type - data type string
        public string dataAllowance { get; set; }//public property for Data Allowance - data type string
        public string numberOfMinutes { get; set; }//public property for Number of Minutes - data type string
        public string numberOfTexts { get; set; }//public property for Number of Texts - data type string
        public decimal pricePerMonth { get; set; }//public property for Price Per Month - data type decimal
        public int contractNo { get; set; }//public property for Contract No - data type int 
        public int customerNo { get; set; }//public property for Customer No - data type int 
        public int manufacturerNo { get; set; }//public property for Manufacturer No - data type int 
        public string duration { get; set; }//public property for Duration - data type string
        public int staffNo { get; set; }//public property for Staff No - data type int 
        public DateTime startDate { get; set; }//public property for Start Date - data type string
        public string Valid(string SomeContractType,
                            string SomeDataAllowance, 
                            string SomeNumberOfMinutes,
                            string SomeNumberOfTexts,
                            string SomePricePerMonth, 
                            string SomeDuration,
                            string SomeContractNo,
                            string SomeCustomerNo,
                            string SomeManufacturerNo,
                            string SomeStaffNo,
                            string TheStartDate)

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

            //if the ManufacturerNo is blank
            if (Convert.ToInt32(SomeManufacturerNo) == 0)
            {
                //record the error
                Error = Error + "The Manufacturer No Cannot Be Blank";
            }
            //if the ContractNo is blank
            if (Convert.ToInt32(SomeContractNo) == 0)
            {
                //record the error
                Error = Error + "The Contract No Cannot Be Blank";
            }
            //if the CustomerNo is blank
            if (Convert.ToInt32(SomeCustomerNo) == 0)
            {
                //record the error
                Error = Error + "The Customer No Cannot Be Blank";
            }
            //if the StaffNo is blank
            if (Convert.ToInt32(SomeStaffNo) == 0)
            {
                //record the error
                Error = Error + "The Staff No Cannot Be Blank";
            }
            try { 
            //copy the the startDate Value to the DateTemp Variable
            DateTemp = Convert.ToDateTime(startDate);
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
            return Error;
        }


    }
    
    }
