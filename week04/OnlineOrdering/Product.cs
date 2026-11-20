using System.Runtime.Intrinsics.X86;

public class Product
{
    private String _name;
    private String _productId;
    private double _price;
    private int _quantity;

    public Product(String name, String productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public String GetProductName()
    {
        return _name;
    }
    public String GetProductId()
    {
        return _productId;
    }

}