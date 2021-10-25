using System;

namespace Prototype
{
    public class Mercedes : Car
    {
        private string modelName;
        public string ModelName
        {
            get 
            { return modelName; }
            set
            {
                modelName = value;
            }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value;}
        }

        public Mercedes()
        {
            modelName = "Mercedes";
            price = 20000;
        }

        public Mercedes ( string modelName, int price ) 
        {
            ModelName = modelName;
            Price = price;
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Model Name of car: " + ModelName);
            System.Console.WriteLine("Price of car: " + Price);
            System.Console.WriteLine();
        }
        public override Car Clone()
        {
            Mercedes copyMercedes = new Mercedes(ModelName, Price);
            return copyMercedes;
        }

        
    }
}