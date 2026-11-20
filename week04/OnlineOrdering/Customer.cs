
public class Customer
{
    private String _name;
    private Address _address;

    public Customer(String name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsUsa()
    {
        return _address.IsUsa();
    }

    public String GetName()
    {
        return _name;
    }
    public String GetAddress()
    {
        return _address.GetDisplayText();
    }
}