using System;

namespace Practice2.System
{

#region CLASS REQUIREMENTS

/*

Address #

The address contains a string for the street address, the city, state/province, and country.
The address should have a method that can return whether it is in the USA or not.
The address should have a method to return a string all of its fields together in one string 
(with newline characters where appropriate)

*/

#endregion

public class Address
{
    private bool _livesInUSA = false;

    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


///<summary>
/// Determines if the
/// country is the United States.
///</summary>
 public bool LivesInUSA()
 {
    if (_country == "USA" || _country == "United States")
    {
        _livesInUSA = true;
    }
    return _livesInUSA;
 }   

///<summary>
/// Returns all of the
/// address components
/// combined into one string.
///</summary>
 public string GetFullAddress(){
   
   string _fullAddress = String.Empty;
   string _newLine = Environment.NewLine;

   _fullAddress = $"{_streetAddress}{_newLine}{_city}, {_stateOrProvince}{_newLine}{_country}";

   return _fullAddress;

 }

}

}