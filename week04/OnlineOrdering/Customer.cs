using System.Collections.Concurrent;

public class Customer
{
    private string _customerName;
    private Address _address = new Address();
    public Address SetCustomerAddress(string customerName, string streetAddress, string city, string state, string country)
    {
        _customerName = customerName; 
        _address.InUSA();
        _address.GetAddress(streetAddress, city, state, country);
        return _address;
    }
    public void GetCustomerAddress()
    {
        Console.WriteLine(_customerName);
        _address.DisplayAddress(); 
    }
}