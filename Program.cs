///Best coding pratice 1
///<summary>
///Use String.Empty instead of ""
///</summary>
///Good
if (firstName == String.Empty) { }

///Bad
if (firstName == "") { }


///Best coding pratice 2
///<summary>
///Avoid passing many parameters to function. If you have 
///more than 4-5 parameters use class or structure to pass it.
///</summary>
///Good
public void UpdateAddress(Address address) { }

///Bad
public void UpdateAddress(int addressId, string country, string state, string phoneNumber, string pinCode, string address1, string address2) { }


///Best coding pratice 3
///<summary>
///The using statements should be sort by framework
///namespaces first and then application namespaces in ascending order
///</summary>
///Good
using System;  
using System.Collections.Generic; using System.IO;  
using System.Text;  
using Company.Product.BusinessLayer; 


///Best coding pratice 4
///<summary>
///Simplify your code by using the C# using statement.
///If you have a try-finally statement in which the only code in the finally block is a call to 
///the Dispose method, use a using statement instead.
///</summary>
///Good
using (var fileToOpen = new FileInfo(fileName))
{
    // File operation  
}

///Bad
var fileInfo = new FileInfo(fileName);
try
{
    // File operation  
}
finally
{
    if (fileInfo != null)
    {
        fileInfo.Delete();
    }
}


///Best coding pratice 5
///<summary>
///The method or function should have only single responsibility (one job). 
///Don’t try to combine multiple functionalities into single function.
///</summary>
///Good
public void UpdateAddress(Address address) { }
public void InsertAddress(Address address) { }

///Bad
public void SaveAddress(Address address)
{
    if (address.AddressId == 0) { } else { }
}


///Best coding pratice 6
///<summary>
///The method name should have meaningful name so that it cannot mislead names. 
///The meaningful method name doesn’t need code comments.
///</summary>
///Good
private void SaveAddress(Address address) { }

///Bad
// This method used to save address  
private void Save(Address address) { }



///Best coding pratice 7
///<summary>
///Avoid using common type system. Use the language specific aliases
///</summary>
///Good
int age;
string firstName;
object addressInfo;

///Bad
System.Int32 age; String firstName;
Object addressInfo;


///Best coding pratice 8
///<summary>
///While comparing string, convert string variables into Upper or Lower case
///</summary>

///Good
if (firstName.ToLower() == "yogesh") { }
if (firstName.ToUpper() == “YOGESH”) { }

///Bad
if (firstName == “rohit”) { }


///Best coding pratice 9
///<summary>
///Always do null check for objects and complex objects before accessing them
///</summary>

///Good
public Contact GetContactDetails(Address address)
{
    if (address != null && address.Contact != null)
    {
        return address.Contact;
    }
}

///Bad
public Contact GetContactDetails(Address address)
{
    return address.Contact;
}


///Best coding pratice 10
///<summary>
///Use object initializers to simplify object creation.
///</summary>

///Good
var employee = new Employee
{
    FirstName = “ABC”,
    LastName = “PQR”,
    Manager = “XYZ”,
    Salary = 12346.25
};

///Bad
var employee = new Employee();
employee.FirstName = “ABC”;
employee.LastName = “PQR”;
employee.Manager = “XYZ”;
employee.Salary = 12346.25;


///Best coding pratice 11
///<summary>
///Avoid using comments, only use when a method is complex and requires in-depth explanation
///</summary>


///Bad
//This is looping through an array and returning the elements contained in the array
int[] fruits = new int[](){"apple", "carrot", "cabbage"};


///Best coding pratice 12
///<summary>
///Avoid complicated conditional logic in your code
///</summary>

///Good
if (something) {
    //doSomething
}


///Bad
if (something) {
    if(something else){
        if(another thing){
            //doSomething
        }
    }
}


///Best coding pratice 13
///<summary>
///Avoid returning null as method result
///</summary>


///Best coding pratice 14
///<summary>
///Use pascal casing ("PascalCasing") when naming a class, record, or struct.
///</summary>

///Good
public class DataService{}


///Bad
public class dataservice { }


///Best coding pratice 15
///<summary>
///When naming an interface, use pascal casing in addition to prefixing the name with an I. 
///This clearly indicates to consumers that it's an interface.
///</summary>

///Good
public interface IWorkerQueue{}


///Bad
public interface workerQueue{}
