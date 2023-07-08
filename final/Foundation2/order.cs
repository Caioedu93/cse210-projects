class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (customer.IsUSACustomer())
        {
            totalCost += 5; // Shipping cost for USA customers
        }
        else
        {
            totalCost += 35; // Shipping cost for non-USA customers
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string customerName = customer.GetName();
        string customerAddress = customer.GetAddress().GetFullAddress();
        string shippingLabel = $"Customer: {customerName}\nAddress:\n{customerAddress}";

        return shippingLabel;
    }
}