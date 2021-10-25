using System;

namespace Prototype
{
    public abstract class Car
    {
        public string modelName;

        public int price; 

        public string ModelName { get; set; }

        public int Price { get; set; }

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