namespace GroceryShop.Products
{
    class MeatProducts : Product
    {
        public MeatProducts(string name, int price, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price / 2;
        }

    }
}