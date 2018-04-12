using System;

namespace ClassLibrary
{
    public class clsManufacturer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public int ManufacturerNo { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }

        public string Valid(string manufacturerName,string manufacturerLocation, string yearStarted,string eMail, string telephone)
        {

            //boolean to flag that all is OK
            string Error = "";
           // DateTime DateTemp;
            //if the field is blank
            if(manufacturerName == "")
            {
                //flag an error
                Error = Error + "Manufacturer name may not be blank ";
            }
            //if the name of the manufacturer is more than 50
            if(manufacturerName.Length > 50)
            {
                //flag an error
                Error = Error + "Manufacturer name must be less than 50 characters ";
            }
          /*  DateTemp = Convert.ToDateTime(yearStarted);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "the date cannot be in the past : ";
            }
            if(DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "the date cannot be in the future : ";
            }*/
            return Error;


        }
    }
}