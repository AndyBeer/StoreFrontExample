using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPractice
{
    //The job if this is to be a blueprint for a Product item - stores data for each product item type
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        //Allows us to print the object directly and allows us to customize the output
        public override string ToString()
        {
            //return base.ToString();

            string output = $"Item: {Name}\nPrice: {Price}";
            return output;
        }
    }
}
