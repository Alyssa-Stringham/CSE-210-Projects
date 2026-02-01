// Contains the name, product id, price, and quantity of each product
// total cost of product (price per unit * quantity)
using System.ComponentModel;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;
    private double _totalCost;

    public void SetProduct(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public void DisplayProduct()
    {
        _price = Math.Round(_price,2);
        Console.WriteLine($"ID: {_productID}, {_productName} ${_price}, {_quantity}x");
    }

    public double CalculateProductTotal()
    {
        _totalCost = _quantity * _price; 
        
        return _totalCost;
    }

}