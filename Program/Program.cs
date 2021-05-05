using System;
using GroceryShop.Products;

namespace GroceryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Александр Сергеевич",
                "Улица Уралььская, дом 59",
                10000,
                550
                );

            Console.WriteLine("Список товаров:");

            MilkProducts milk = new MilkProducts(
                "Молоко \"Савушкин\"",
                250,
                "ОАО \"Савушкин продукт\"",
                1.5
                );

            Console.WriteLine("Молочные продукты:");
            Console.WriteLine("Название: " + milk.Name);
            Console.WriteLine("Цена: " + milk.Price);
            Console.WriteLine("Производитель: " + milk.Manufacturer);
            Console.WriteLine("Жирность: " + milk.FatContent);
            Console.WriteLine(new String('-', 25));

            Beverages duchess = new Beverages(
                "Дюшес",
                200,
                " ООО \"Акваника\"",
                2.5
                );

            Console.WriteLine("Напитки:");
            Console.WriteLine("Название: " + duchess.Name);
            Console.WriteLine("Цена: " + duchess.Price);
            Console.WriteLine("Производитель: " + duchess.Manufacturer);
            Console.WriteLine("Ёмкость: " + duchess.Liters);
            Console.WriteLine(new String('-', 25));

            MeatProducts sausage = new MeatProducts(
                "Сосиски \"Докторские\"",
                500,
                "Брестский мясокомбинат"
                );

            Console.WriteLine("Мясные продукты:");
            Console.WriteLine("Название: " + sausage.Name);
            Console.WriteLine("Цена: " + sausage.Price);
            Console.WriteLine("Производитель: " + sausage.Manufacturer);
            Console.WriteLine(new String('-', 25));

            MeatProducts FriendAphrodisiacs = new MeatProducts(
                "Колбаса салями \"Боярская\"",
                700,
                "ООО \"ММПЗ\" \"Коломенское\""
                );

            Console.WriteLine("Мясные продукты:");
            Console.WriteLine("Название: " + FriendAphrodisiacs.Name);
            Console.WriteLine("Цена: " + FriendAphrodisiacs.Price);
            Console.WriteLine("Производитель: " + FriendAphrodisiacs.Manufacturer);
            Console.WriteLine(new String('-', 25));

            Sweets chocolate = new Sweets(
                "Молочный шоколад \"Michelle\" ",
                350,
                "ОАО \"Коммунарка\""
                );

            Console.WriteLine("Cладости:");
            Console.WriteLine("Название: " + chocolate.Name);
            Console.WriteLine("Цена: " + chocolate.Price);
            Console.WriteLine("Производитель: " + chocolate.Manufacturer);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[] {
                milk,
                duchess,
                sausage,
                FriendAphrodisiacs,
                chocolate
            };

            Informer informer = new Informer();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name}! Ваш баланс составляет: {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }
        }
    }
}