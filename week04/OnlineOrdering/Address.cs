// contains a string for street address, city, state/ province, country
// method that can return if in USA or not
// method to return string of all its fields together in one string (newline characters where appropriate)
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string GetAddress(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = state;
        _country = country;
        string completeAddress = $"{streetAddress} \n {city}, {state} \n {country}";
        
        return completeAddress;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress} \n {_city}, {_stateProvince} \n {_country}");
    }
    public bool InUSA()
    {
        if (_country != "USA" && _country !="United States of America")
        {
            return false;
        }
        return true;
    }

}