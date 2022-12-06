using System;

namespace Practice2.System
{


#region CLASS REQUIREMENTS

/*

/// Product #

Contains the name, product id, price, and quantity of each product.
The price of this product is computed by multiplying the price and the quantity.
*/

#endregion

public class Product
{

    private string _productName;

    private string _productID;

    private double _productPrice;

    private int _productQuantity;

    
    public Product(string name, string ID, double price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _productPrice = price;
        _productQuantity = quantity;
        
    }

    ///<summary>
    /// Returns the price
    /// mulitiplied by the
    /// quantity.
    ///</summary>
    public double CalculateTotalPrice()
    {

        return (_productPrice * _productQuantity);

    }


}

}