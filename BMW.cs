using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Prototype
{
    public class BMW : Car
    {
        public BMW()
        {
            modelName = "Suzuki";
            price = 500000;
            color = "White";
        }

        public BMW(string modelName, int price, string color)
        {
            ModelName = modelName;
            Price = price;
            Color = color;
        }

        private string color;
        public string Color 
        {
            get{ return color;}
            set
            {   
                if (value.Length <= 0) throw new DataNotCorrect("Error: Color must is not null. Pls enter the color again!!!");
                else color = value;
            }
        }

        public override Car Clone()
        {
            BMW copyBMW = new BMW(ModelName, Price, Color);
            return copyBMW; 
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Model Name of car: " + ModelName);
            System.Console.WriteLine("Price of car: " + Price);
            System.Console.WriteLine("Color of car: " + Color);
            System.Console.WriteLine();
        }
    }
}