public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private string _id;

    public Product(string name, String id, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_id}  x{_quantity})";
    }
}