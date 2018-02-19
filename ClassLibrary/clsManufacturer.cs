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

        public bool Valid(string someManufacturer)
        {
            //if the name of the country is not blank
            if(someManufacturer != "")
            {
                //return true
                return true;
            }
            else //else false
            {
                return false;
            }
        }

        public bool Valid(object someManufacturer)
        {
            throw new NotImplementedException();
        }
    }
}