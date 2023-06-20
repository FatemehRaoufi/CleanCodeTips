using System;
using System.Collections.Generic;

//Eliminate God classes by Extract Class Refactoring
/*
 * A God class is a class that tries to accomplish everything, 
 * usually by extending another class or classes. 
 * They have many methods and properties, and they typically have no clear responsibility. 
 * These classes are hard to understand, hard to maintain, and hard to test. 
 * They’re often the result of code duplication, 
 * and they’re a significant problem in software development.
 
 */
namespace CleanCodeTips
{
    public class ExtractClassRefactoring
    {
        //AddressDetails class is: Extract Class
        public class AddressDetails
        {
            internal string Street { get; set; }
            internal int HouseNumber { get; set; }
            internal string City { get; set; }
            internal string PostalNumber { get; set; }
            internal string Country { get; set; }
        }
        public class Person
        {
           
            internal string Name { get; set; }
            internal string TelephoneNumber { get; set; }
            internal string Email { get; set; }

            //Befor using  Extract class:
            //Address Details fields are:           
            //internal string Street { get; set; }
            //internal int HouseNumber { get; set; }
            //internal string City { get; set; }
            //internal string PostalNumber { get; set; }
            //internal string Country { get; set; }
            //internal bool FreeDelivery()
            //{
            //    return int.Parse(PostalNumber) < 40000;
            //}

       //After Extract Class Refactoring, we have:
            public AddressDetails Address { get; set; }
            internal bool FreeDelivery()
            {
                return int.Parse(Address.PostalNumber) < 40000;
            }
            //Other person methods here...

            internal string GetFullAddress()
            {
                return $"{Address.Street} {Address.HouseNumber}, {Address.PostalNumber} {Address.City}, {Address.Country}";
            }

            public Person()
            {
                Address = new AddressDetails();
            }
        }
    }
}
//https://methodpoet.com/extract-class-refactoring/
//https://methodpoet.com/clean-code/