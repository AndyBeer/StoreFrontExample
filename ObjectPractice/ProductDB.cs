using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPractice
{
    class ProductDB
    {
        //This class is to manage selling product objects
        //Think of this as what the user is interacting with (if in person)
        public List<Product> Inventory = new List<Product>();
        public ProductDB()
        {
            Inventory.Add(new Product("Notebook", 4.99));
            Inventory.Add(new Product("Pencils", 0.49));
            Inventory.Add(new Product("Ruler", 2.99));
            Inventory.Add(new Product("Calculator", 34.99));

        }
        public void DisplayItems()
        {
            foreach (var p in Inventory)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
        }
        /*
         * public void DisplayProducts()
         * for ()int i = 0; i <Inventory.Count; i++)
         * {
         * Product p = Products[i];
         * 
         * 
         * 
         */
        public bool HasItem(string product)

            //Crude linear search
        {
            for (int i = 0; i < Inventory.Count; i++)
            {
              //Grabbing our product from the list
                Product p = Inventory[i];
                string prodName = p.Name;

                if (product.ToLower().Trim() == prodName.ToLower().Trim())
                {
                        return true;
                }
            }
            return false;

        }
        public Product BuyRandom()
        //Generating a random number between 0 and size of our list
        //Returning a single Product data type
        {
            Random r = new Random();

            //we need to use the Next() method - 1st value (min) is inclusive, 2nd value (max) is exclusive
            int pick = r.Next(0, Inventory.Count);

            return Inventory[pick];
        }
        public string BuyInBulk(string prodName, int amount)
        {
            //need to first makes sure the item is in our list - reuse HasItem!!
            if (HasItem(prodName))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    Product p = Inventory[i];
                    
                    //we found our product
                    if (p.Name == prodName)
                    {
                        //Need to calc total price and rerturn a receipt as a string
                        double total = p.Price * amount;
                        string output = $"Name: {p.Name}\nPrice: {p.Price} x desired amount: {amount}\nTotal: {total}\n";
                        return output;

                    }
                    
                }
                //This case wont ever really happen, but this makes the compiler happy
                return "Item not found";
            }
            else
            {
                return $"{prodName} is not currently available.\n";
            }
        
        }

    }
}
