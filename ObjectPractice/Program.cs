using System;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program's job (now that we know objects) is to call, test, create, and run other objects
            //Heavy lifting for specific things should be shifted into objects/classes whenever possible

            ProductDB Inventory = new ProductDB();
            Inventory.DisplayItems();
            
            //testing our HasItem method with a false, then true
            Console.WriteLine(Inventory.HasItem("pancakes"));
            Console.WriteLine(Inventory.HasItem("pencils"));

            Console.WriteLine();

            //Testing randomness in batch allows you to make sure no patterns exist
            //Using i<20 to get enough of a sample to prove it is random
            //for (int i = 0; i < 20; i++)
            //{

            //    Product p = Inventory.BuyRandom();
            //    Console.WriteLine(p);
            //    Console.WriteLine();

            //}
            string bulkResult = Inventory.BuyInBulk("Pencils", 10);
            Console.WriteLine(bulkResult);

            string bulkFailure = Inventory.BuyInBulk("Fake Item", 10);
            Console.WriteLine(bulkFailure);
        }
    }
}
