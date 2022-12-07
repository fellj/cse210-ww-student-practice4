using System;
using Practice2.System;

namespace Practice2.Directing
{

    #region CLASS REQUIREMENTS

    /*

    Write a program that creates at least two orders with a 2-3 products each. 
    Call the methods to get the packing label, the shipping label, and the total price of the order, and display the 
    results of these methods.

    */


    #endregion


    public class Director
    {



        ///<summary>
        /// Create orders
        ///</summary>
        public void CreateOrders()
        {

            // Create order 1
            
            string customerName1            = "Albert Enstein";
            string customerStreetAddress1   = "123 Wallaby Way";
            string customerCity1            = "Ulm";
            string customerStateOrProvince1 = "Baden-Wurttemberg";
            string customerCountry1         = "Germany";
            Order order1                    = new Order(customerName1, customerStreetAddress1, customerCity1, customerStateOrProvince1, customerCountry1);


        }



        
    }




}