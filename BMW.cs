using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Prototype
{
    public class BMW : Car
    {
        //private string type;
        private string modelName;
        private int price;
        
        //public string Type { get { return type; } }
        

        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }

        
        public int Price
        {
            get { return price; }
            set { price = value;}
        }

        public BMW()
        {
            modelName = "Suzuki";
            price = 500000;
        }

        public BMW(string modelName, int price)
        {
            ModelName = modelName;
            Price = price;
        }

        public override Car Clone()
        {
            BMW copyBMW = new BMW(ModelName, Price);
            return copyBMW; 
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Model Name of car: " + ModelName);
            System.Console.WriteLine("Price of car: " + Price);
            System.Console.WriteLine();
        }
    }
}