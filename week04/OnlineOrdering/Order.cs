// contains a list of products and a customer
// calculate the total cost of the order (sum of total cost of each product + shipping)
// Shipping: 
// USA: $5
// Not USA: $35
// Return a string for packing label (list name and product id of each product in order)
// return string for shipping label (name and address of customer)
using System.Net.NetworkInformation;
using System.Reflection;

public class Order
{
    public List<Product> _customerProducts = new List<Product>(); 
    public Customer _customer = new Customer(); 
    private double _orderTotal;
    private int _shippingCost;

    public int CalculateShipping(bool InUSA)
    {    
        _shippingCost = 35;
        if (InUSA == true)
        {
            _shippingCost = 5;
        }
        return _shippingCost;
    }    
    public double CalculateOrderTotal()
    {
        
        foreach (Product product in _customerProducts)
        {
            double itemTotal = product.CalculateProductTotal();
            _orderTotal += itemTotal;
        }
        
        _orderTotal += _shippingCost;
        _orderTotal = Math.Round(_orderTotal,2);        
        return _orderTotal;
    }

    public void GetPackingLabel()
    {
       Console.WriteLine("Packing Label");
       //int itemCount = 0;
       foreach(Product product in _customerProducts)
        {
           product.DisplayProduct();
           //itemCount += 1;
        }
    }

    public void GetShippingLabel()
    {
       Console.WriteLine("Shipping Label:");
        _customer.GetCustomerAddress();      
    }
}