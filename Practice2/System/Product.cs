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
    /// Sets the product name
    ///</summary>
    public void SetProductName(string inputProductName)
    {
        _productName = inputProductName;

    }

    ///<summary>
    /// Get the product name
    ///</summary>
    public string GetProductName()
    {
        return _productName;
    }

    ///<summary>
    /// Set product ID
    ///</summary>
    public void SetProductID(string inputProductID)
    {
        _productID = inputProductID;
    }

    ///<summary>
    /// Get the product ID
    ///</summary>
    public string GetProductID()
    {
        return _productID;
    }
    ///<summary>
    /// Set the product price
    ///</summary>
    public void SetProductPrice(double inputProductPrice)
    {
        _productPrice = inputProductPrice;
    }

    ///<summary>
    /// Get the product price
    ///</summary>
    public double GetProductPrice()
    {
        return _productPrice;
    }


    ///<summary>
    /// Set the product quantity
    ///</summary>
    public void SetProductQuantity(int inputProductQuantity)
    {
        _productQuantity = inputProductQuantity;
    }
    ///<summary>
    /// Get the product quantity
    ///</summary>               
    public int GetProductQuantity()
    {
        return _productQuantity;
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