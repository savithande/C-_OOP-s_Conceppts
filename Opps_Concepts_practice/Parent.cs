using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts_practice
{
    class Parent
    {
        public string name; 
        public string place;
        public string child_Name;
        public string phoneNumber;
        

        //Contructor
        public Parent(string nativePlace, string childName, string mobileNumber) 
        {

            name = "ASP.NET"; // initializing the value
            place = nativePlace;
            child_Name = childName;
            phoneNumber = mobileNumber;


        }

        public bool isValidPhoneNumber(string phoneNumber)
        {
            foreach (char ch in phoneNumber)
            {
                if (ch < '0' || ch > '9')
                {
                    return false;
                }

            }
            return true;
        }


        

        

         
    }
}
