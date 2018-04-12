using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsManufacturerCollection
    {
        //public constructor for the class
        public clsManufacturerCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblManufacturer_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a new instance of the manufacturer class
                clsManufacturer AManufacturer = new clsManufacturer();
                //get the manufacturer name
                AManufacturer.Name = DB.DataTable.Rows[Index]["ManufacturerName"].ToString();
                //get the primary key
                AManufacturer.ManufacturerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ManufacturerNo"]);
                //add the manufacturer to the private list
                mAllManufacturers.Add(AManufacturer);
                //increment the index
                Index++;
            }


        }
           /* //create an instance of the manufacturer class to store a manufacturer
            clsManufacturer AManufacturer = new clsManufacturer();
            //set the name to apple
            AManufacturer.Name = "Apple";
            //add the name to the private list
            mAllManufacturers.Add(AManufacturer);
            //re-initalise to add a new item
            AManufacturer = new clsManufacturer();
            //set the name to samsung
            AManufacturer.Name = "Samsung";
            //add the name to the private list
            mAllManufacturers.Add(AManufacturer);
            */
        


        // public List<clsManufacturer> AllManufacturers { get; set; }
        public List<clsManufacturer> mAllManufacturers = new List<clsManufacturer>();
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllManufacturers.Count;
            }
            set
            {
                
            }
        }
        //public property for allmanufacturers
        public List<clsManufacturer> AllManufacturers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllManufacturers;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllManufacturers = value;
            }
        }


    }
}