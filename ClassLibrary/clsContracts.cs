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
        public bool Valid(string SomeContractType, string SomeDataAllowance, string SomeNumberOfMinutes, string SomeNumberOfTexts, int SomePricePerMonth)
        {
            //boolean flag to indicate that all is ok
            Boolean OK = true;
            //if the name of the contract type is not blank
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
            if (SomeDataAllowance == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the contract type is more than 10 characters 
            if (SomeDataAllowance.Length > 10)
            {
                //flag an error
                OK = false;
            }
            if (SomeNumberOfMinutes == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the contract type is more than 50 characters 
            if (SomeNumberOfMinutes.Length > 50)
            {
                //flag an error
                OK = false;
            }
            if (SomeNumberOfTexts == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the contract type is more than 50 characters 
            if (SomeNumberOfTexts.Length > 50)
            {
                //flag an error
                OK = false;
            }
            if (SomePricePerMonth == 0)
            {
                //flag an error
                OK = false;
            }
            //if the name of the contract type is more than 50 characters 
            if (SomePricePerMonth > 999999999)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }

    }
    }
