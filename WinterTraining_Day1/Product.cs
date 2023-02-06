using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterTraining_Day1;

namespace WinterTraining_Day1
{
    // OOP Concepts
    // Encapsulation : 
    internal class Product
    {
        public string Category { get; set; }

        private string name;
        public string Name { get { return name; }
            set { 
                name = value;
            } 
        }

        private int price;
        public int Price { 
            get { return price; } 
            set {
                if (value < 0)
                    throw new InvalidPriceException("From inside the class Invalid value for the price");
                 else if(value == 20)
                    throw new Exception("Invalid price");
                else price = value;
            } }
        public string Print()
        {
            return $"name = {name}, category = {Category}, price = {price}";
        }
    }
}
