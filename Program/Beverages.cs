namespace GroceryShop.Products
{
    class Beverages : Product
    {
        public double Liters { get; set; }

        public Beverages(string name, int price, string manufacturer, double liters)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Liters = liters;
        }
    }
}
