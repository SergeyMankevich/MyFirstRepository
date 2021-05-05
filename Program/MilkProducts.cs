namespace GroceryShop.Products
{
    class MilkProducts : Product
    {
        public double FatContent { get; private set; }

        public MilkProducts(string name, int price, string manufacturer, double fatContent)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            FatContent = fatContent;
        }
    }
}
