using System;

namespace Practice2.System

{

    #region CLASS REQUIREMENTS
/*

Order #

Contains a list of products and a customer. Can calculate the total cost of the order, 
and can return a string for the packing label, and can return a string for the shipping label.
The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
If the customer does not live in the USA, then the shipping cost is $35.
A packing label should list the name and product id of each product in the order.
A shipping label should list the name and address of the customer

*/
#endregion

public class Order
{

    private static string _newLine = Environment.NewLine;
    private static string _dividingLine = "###########################";
    private static double _localShippingCost = 5.00;

    private static double _internationalShippingCost = 35.00;

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(string customerName, string customerStreetAddress, string customerCity, string customerStateOrProvince, string customerCountry)
    {
        _customer = new Customer(customerName, customerStreetAddress, customerCity, customerStateOrProvince, customerCountry);
        
    }

    ///<summary>
    /// Add a product
    ///<param name="inputProduct"> An input product instance</param>
    ///</summary>
    public void AddProduct(Product inputProduct)
    {

        _products.Add(inputProduct);

    }

    ///<summary>
    /// Calculate the total cost 
    /// of the order
    ///</summary>
    public double CalculateCost()
    {
        double _cost = 0.00;


        // Get the total cost of all prodcuts
        foreach (Product product in _products)
        {
            _cost += product.CalculateTotalPrice();
        }

        // Add the shipping cost based on the
        // customer's country
        if (_customer.LivesInUSA()) 
        {
            _cost += _localShippingCost;
        }
        else
        {
            _cost += _internationalShippingCost;
        }



        return _cost;
    }

    ///<summary>
    /// Gets the packing
    /// label for the order
    ///</summary>
    public void GetPackingLabel()
    {
        string _packingLabel = String.Empty;

        _packingLabel = $"Packing Label: {_newLine}{_dividingLine}";

        foreach (Product product in _products)
        {
            _packingLabel += $"Product Name: {product.GetProductName()} {_newLine} Product ID: {product.GetProductID()} {_dividingLine} {_newLine}";
            
        }
        

        Console.WriteLine(_packingLabel);
    }

    ///<summary>
    /// Gets the shipping
    /// label for the order
    ///</summary>
    public void GetShippingLabel()
    {
        string _shippingLabel = String.Empty;

         _shippingLabel = $"Shipping Label: {_newLine}{_dividingLine}";


        _shippingLabel += $"{_customer.GetCustomerName()} {_newLine} {_customer.GetCustomerAddress()} {_newLine} {_dividingLine} {_newLine}";
        

        Console.WriteLine(_shippingLabel);

    }

}


}