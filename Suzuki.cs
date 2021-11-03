namespace Prototype
{
    public class Suzuki : Car
    {
        
        public Suzuki()
        {
            modelName = "Suzuki";
            price = 500000;
            size = 5;
        }

        public Suzuki ( string modelName, int price, int size ) 
        {
            ModelName = modelName;
            Price = price;
            Size = size;
        }

        private int size;
        public int Size 
        {
            get { return size;}
            set
            {
                if (value <=0) throw new DataNotCorrect("Error: Size is not less than 0!!!");
                else size = value;
            }
        }

        public override void ShowInfo()
        {
            System.Console.WriteLine("Model Name of car: " + ModelName);
            System.Console.WriteLine("Price of car: " + Price);
            System.Console.WriteLine("Size of car: " + Size);
            System.Console.WriteLine();
        }
        public override Car Clone()
        {
            Suzuki copySuzuki = new Suzuki(ModelName, Price, Size);
            return copySuzuki;
        }
    }
}   
