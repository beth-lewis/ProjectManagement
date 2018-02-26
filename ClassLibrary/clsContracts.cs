using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonePalClassLibrary
{
    public class clsContract
    {
        public string ContractType { get; set; }//property for Contract Type - data type string
        public string DataAllowance { get; set; }//public property for Data Allowance - data type string
        public string NumberOfMinutes { get; set; }//public property for Number of Minutes - data type string
        public string NumberOfTexts { get; set; }//public property for Number of Texts - data type string
        public decimal PricePerMonth { get; set; }//public property for Price Per Month - data type decimal
        public int ContractNo { get; set; }//public property for Contract No - data type int 
        public int CustomerNo { get; set; }//public property for Customer No - data type int 
        public int ManufacturerNo { get; set; }//public property for Manufacturer No - data type int 
        public string Duration { get; set; }//public property for Duration - data type string
        public int StaffNo { get; set; }//public property for Staff No - data type int 
        public DateTime StartDate { get; set; }//public property for Start Date - data type string
        public bool Valid(string SomeContractType, 
            string SomeDataAllowance, string SomeNumberOfMinutes, 
            string SomeNumberOfTexts, int SomePricePerMonth, string 
            SomeDuration, int SomeContractNo, int 
            SomeCustomerNo, int SomeManufacturerNo, 
            int SomeStaffNo, DateTime TheStartDate)

        {
            //create a temporary variable to store data values
           // DateTime DateTemp;
            //boolean flag to indicate that all is ok
            Boolean OK = true;
            //if the name of the contract type is blank
            if (SomeContractType == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the contract type is more than 30 characters 
            if(SomeContractType.Length > 30)
            {
                //flag an error
                OK = false;
            }
            //if data allowance is blank
            if (SomeDataAllowance == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the data allowance is more than 10 characters 
            if (SomeDataAllowance.Length > 10)
            {
                //flag an error
                OK = false;
            }
            //if number of minutes is blank
            if (SomeNumberOfMinutes == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of number of minutes  is more than 50 characters 
            if (SomeNumberOfMinutes.Length > 50)
            {
                //flag an error
                OK = false;
            }
            //if number of texts is blank
            if (SomeNumberOfTexts == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of Number of Texts is more than 50 characters 
            if (SomeNumberOfTexts.Length > 50)
            {
                //flag an error
                OK = false;
            }
            //if price of month is equal to zero
            if (SomePricePerMonth == 0)
            {
                //flag an error
                OK = false;
            }
            //if the number is higher than 9999 for price per month
            if (SomePricePerMonth > 9999)
            {
                //flag an error
                OK = false;
            }
            //if duration is blank
            if (SomeDuration == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of duration is less than 6 characters
            if (SomeDuration == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of duration is more than 11 characters
            if (SomeDuration.Length > 20)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }


    }
    
    }
