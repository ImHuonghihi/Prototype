namespace Prototype
{
    public class Suzuki : Car
    {
        private string modelName;
        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value;}
        }

        public Suzuki()
        {
            modelName = "Suzuki";
            price = 500000;
        }

        public Suzuki ( string modelName, int price ) 
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
            Suzuki copySuzuki = new Suzuki(ModelName, Price);
            return copySuzuki;
        }
    }
}   
