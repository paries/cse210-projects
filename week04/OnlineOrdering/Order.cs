using System.Globalization;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProductToOrder(Product product)
    {
        _products.Add(product);
    }

    public String GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.IsUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total.ToString("C", CultureInfo.GetCultureInfo("en-US")); ;
    }
    public String GetPackingLabel()
    {
        String label = "";
        for (int x=0; x < _products.Count; x++)
        {
            label += $"{x+1}. {_products[x].GetProductName()} {_products[x].GetProductId()}\n";
        }

        return label;
    }
    public String GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

}