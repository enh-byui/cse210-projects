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
            Product product1 = new Product("Widget", "W001", 10.0, 2);
            Product product2 = new Product("Gizmo", "G001", 20.0, 1);
            Product product3 = new Product("Thingamajig", "T001", 15.0, 3);

            // Create orders
            Order order1 = new Order(new Product[] { product1, product2 }, customer1);
            Order order2 = new Order(new Product[] { product2, product3, product1 }, customer2);

            // Display packing labels, shipping labels, and total price of orders
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total price: {order1.GetTotalPrice():C}");

            Console.WriteLine();

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total price: {order2.GetTotalPrice():C}");
        }
    }