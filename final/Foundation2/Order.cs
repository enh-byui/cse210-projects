class Order
    {
        private Product[] _products;
        private Customer _customer;

        public Order(Product[] products, Customer customer)
        {
            _products = products;
            _customer = customer;
            }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
        }

        if (_customer.IsInUSA())
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Packing label for {_customer.GetName()}:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} ({product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping label for {_customer.GetName()}:\n";
        shippingLabel += $"{_customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }
    }