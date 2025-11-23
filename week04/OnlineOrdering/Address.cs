public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    
    private string _country;

    public Address(string street, string city, string state, string counrty )
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = counrty;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }
}