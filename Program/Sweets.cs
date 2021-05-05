namespace GroceryShop.Products
{
    class Sweets : Product
    {
        public Sweets(string name, int price, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }
    }
}