class Program
    {
        static void Main(string[] args)
        {
            // Create customers
            Address customer1Address = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer1 = new Customer("John Doe", customer1Address);

            Address customer2Address = new Address("456 First St", "Othertown", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", customer2Address);

            // Create products
            Product product_1 = new Product("Widget", "W001", 10.0, 2);
            Product product_2 = new Product("Gizmo", "G001", 20.0, 1);
            Product product_3 = new Product("Thingamajig", "T001", 15.0, 3);

            // Create orders
            Order order_1 = new Order(new Product[] { product_1, product_2 }, customer1);
            Order order_2 = new Order(new Product[] { product_2, product_3, product_1 }, customer2);

            // Display packing labels, shipping labels, and total price of orders
            Console.WriteLine(order_1.GetPackingLabel());
            Console.WriteLine(order_1.GetShippingLabel());
            Console.WriteLine($"Total price: {order_1.GetTotalPrice():C}");

            Console.WriteLine();

            Console.WriteLine(order_2.GetPackingLabel());
            Console.WriteLine(order_2.GetShippingLabel());
            Console.WriteLine($"Total price: {order_2.GetTotalPrice():C}");
        }
    }