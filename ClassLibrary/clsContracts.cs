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
        public int ContractNo { get; set; }//public property for ContractNo - data type int
        public int CustomerNo { get; set; } //public property for CustomerNo - data type int
        public int ManufacturerNo { get; set; }//public property for ManufacturerNo - data type int
        public string Duration { get; set; }//public property for Duration - data type int 
        public int StaffNo { get; set; } //public property for StaffNo - data type int
        public DateTime StartDate { get; set; } //public property for Start Date - data type DateTime
    }
}
