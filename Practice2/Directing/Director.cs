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

        private List<Order> _orders = new List<Order>();
        private static string _newLine = Environment.NewLine;


        ///<summary>
        /// Create orders
        ///</summary>
        public void CreateOrders()
        {

            // Create order 1
            // *************************************************************************************
            
            string customerName1            = "Albert Enstein";
            string customerStreetAddress1   = "123 Wallaby Way";
            string customerCity1            = "Ulm";
            string customerStateOrProvince1 = "Baden-Wurttemberg";
            string customerCountry1         = "Germany";
            Order order1                    = new Order(customerName1, 
                                            customerStreetAddress1, customerCity1, 
                                            customerStateOrProvince1, customerCountry1);

            _orders.Add(order1);

            // Add products to order 1
            Product product1 = new Product("Quantum Mechanics for Dummies", "8888", 25.00M, 1);
            Product product2 = new Product("Flux Capacitor", "8889", 54.99M, 10);
            Product product3 = new Product("Old Fashioned Bow Tie", "0052", 19.50M, 3);

            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);


            // Create order 2
            // *************************************************************************************
            string customerName2            = "Barak Obama";
            string customerStreetAddress2   = "2500 W Golf Road";
            string customerCity2            = "Hoffman Eestates";
            string customerStateOrProvince2 = "Illinois";
            string customerCountry2         = "USA";
            Order order2                    = new Order(customerName2, 
                                            customerStreetAddress2, customerCity2, 
                                            customerStateOrProvince2, customerCountry2);

            _orders.Add(order2);


            // Add products to order 1
            Product product4 = new Product("How to help the U.S. economny", "3612", 55.00M, 5);
            Product product5 = new Product("Covid-19 Mask", "4006", 9.99M, 20);
            Product product6 = new Product("Presidential ball point pen", "0939", 12.99M, 1);

            order2.AddProduct(product4);
            order2.AddProduct(product5);
            order2.AddProduct(product6);


        }

        ///<summary>
        /// Display order contents
        /// such as customer and their
        /// products.
        ///</summary>
        public void DisplayOrders()
        {

            int orderCounter = 1;
            

            foreach (Order order in _orders)
            {

                Console.WriteLine($"Processing Order {orderCounter} ... {_newLine}");
                order.GetPackingLabel();
                Console.WriteLine(_newLine);
                order.GetShippingLabel();
                Console.WriteLine($"The total cost of the order is: {order.CalculateCost().ToString("C2")}.");
                Console.WriteLine(_newLine);  

                orderCounter++;
                
            }

        }

           
        
    }




}