using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PhonePalClassLibrary
{
    public class clsContractCollection
    {
        //private data member for allContracts List
        private List<clsContracts> mAllContracts = new List<clsContracts>();
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllContracts.Count;
            }
            set
            {

            }
        }
        //public constructor for the class        
        public clsContractCollection()
        {
            //create an instance of the contract class store a contract
            clsContracts AContractType = new clsContracts();
            //set the Contract Type to Pay As You Go
            AContractType.ContractType = "Pay As You Go";
            //add the contract type to the private list of contract types
            mAllContracts.Add(AContractType);
            //re initialise the AContractType object to accept a new item
            AContractType = new clsContracts();
            //set the contract type to Monthly
            AContractType.ContractType = "Monthly";
            //add the second contract type to the private list of contract type
            mAllContracts.Add(AContractType);
            //private list now contains two contract types
        }       

        public List<clsContracts> AllContracts
        {
            get
            {
                //return the private data member
                return mAllContracts;
            }
            set
            {
                //assign the incoming value to the private data member
                mAllContracts = value;
            }
        }
    }
}