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

    private List<Product> _products = new List<Product>();
    private Customer _customer;

    ///<summary>
    /// Calculate the total cost 
    /// of the order
    ///</summary>
    public double CalculateCost()
    {
        double _cost = 0.00;

        return _cost;
    }

    ///<summary>
    /// Gets the packing
    /// label for the order
    ///</summary>
    public string GetPackingLabel()
    {
        string _packingLabel = String.Empty;

        return _packingLabel;
    }

    ///<summary>
    /// Gets the shipping
    /// label for the order
    ///</summary>
    public string GetShippingLabel()
    {
        string _shippingLabel = String.Empty;

        return _shippingLabel;

    }

}


}