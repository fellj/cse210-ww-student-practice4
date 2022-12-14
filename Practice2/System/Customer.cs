using System;

namespace Practice2.System
{

    #region CLASS REQUIREMENTS
    /*

    Customer #

    The customer contains a name and an address.
    The name is a string, but the Address is a class.
    The customer should have a method that can return whether they live in the USA or not. 
    (Hint this should call a method on the address to find this.)

    */



    #endregion

    public class Customer
    {

        private string _customerName;

        private Address _customerAddress = new Address();

        public Customer(string customerName, string streetAddress, string city, string stateOrProvince, string country)
        {
            // Define customer name
            _customerName = customerName;

            // Define customer address
            _customerAddress.SetStreetAddress(streetAddress);
            _customerAddress.SetCity(city);
            _customerAddress.SetStateOrProvince(stateOrProvince);
            _customerAddress.SetCountry(country);
            
        }

        ///<summary>
        /// Set the customer name
        ///</summary>
        public void SetCustomerName(string inputCustomerName)
        {
            _customerName = inputCustomerName;
        }

        ///<summary>
        /// Get the customer name
        ///</summary>        
        public string GetCustomerName()
        {
            return _customerName;
        }

        ///<summary>
        /// Set the customer address
        ///</summary>        
        public void SetCustomerAddress(Address inputAddress)
        {
            _customerAddress = inputAddress;
        }

        ///<summary>
        /// Get the customer address
        ///</summary>
        public string GetCustomerAddress()
        {
            return _customerAddress.GetFullAddress();
        }

        ///<summary>
        /// Returns true if the
        /// customer lives
        /// in the USA. Returns
        /// false otherwise.
        ///</summary>
        public bool LivesInUSA()
        {
            bool _livesInUSA = _customerAddress.LivesInUSA();

            return _livesInUSA;
        }
        
    }
}