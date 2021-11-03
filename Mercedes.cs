using System;

namespace Prototype
{
    public class Mercedes : Car
    {
        public Mercedes()
        {
            modelName = "Mercedes";
            price = 20000;
            maxSpeed = 400;
            
        }

        public Mercedes ( string modelName, int price, int maxSpeed ) 
        {
            ModelName = modelName;
            Price = price;
            MaxSpeed = maxSpeed;
        }

        private int maxSpeed;
        public int MaxSpeed 
        {
            get{ return maxSpeed;}
            set
            { 
                if (value <= 0) throw new DataNotCorrect("ERROR: Max speed is not less than 0. Please try again!!!");
                else maxSpeed = value;
            }
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Model Name of car: " + ModelName);
            System.Console.WriteLine("Price of car: " + Price);
            System.Console.WriteLine("Max speed of car: " + MaxSpeed + "km/h");
            System.Console.WriteLine();
        }
        public override Car Clone()
        {
            Mercedes copyMercedes = new Mercedes(ModelName, Price, MaxSpeed);
            return copyMercedes;
        }
    }
}