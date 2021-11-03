using System;

namespace Prototype
{
    public abstract class Car
    {
        public string modelName;

        public int price; 

        public string ModelName
        {
            get { return modelName; }
            set 
            {
                if (value.Length <= 0) throw new DataNotCorrect("Error: Model name must is not null!!!");
                else modelName = value; 
            }
        }

        public int Price
        {
            get { return price; }
            set 
            {
                //price = value;
                if (value <= 0) throw new DataNotCorrect("Error: Price is not less than 0!!!");
                else price = value;
            }
        }

        public abstract Car Clone ();

        public abstract void ShowInfo();

        public Car()
        {}

        internal static void Add(Car copyCar)
        {
            throw new NotImplementedException();
        }
    }
}