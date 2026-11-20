public class Address
{
    private String _address;
    private String _city;
    private String _region;
    private String _country;

    public Address(String address, String city, String region, String country)
    {
        _address = address;
        _city = city;
        _region = region;
        _country = country;
    }
    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public String GetDisplayText()
    {
        return $"{_address}\n{_city},{_region}\n{_country}";
    }
}