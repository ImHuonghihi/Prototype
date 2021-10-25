using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Prototype
{
    public class CarBoard : MenuProgram
    {
        protected override void PrintMenu()
        {
            Console.WriteLine();
            System.Console.WriteLine("1: Add Car");
            System.Console.WriteLine("2: Show Car");
            System.Console.WriteLine("3: Delete Car");
            System.Console.WriteLine("4: Edit Car");
            System.Console.WriteLine("0: Exit");
        }

        protected override void DoTask(int option)
        {
            switch(option)
            {
                case 1: AddCar();          break;
                case 2: ShowCar();         break;
                case 3: DeleteCar();       break;
                case 4: EditCar();         break;
                case 0: Quit();                 break;
                default: ShowError();           break;
            }
        }

        private void ShowError()
        {
            System.Console.WriteLine("Invalid option!");
        }

        private void Quit()
        {
            System.Console.WriteLine("Exit program");
        }

        private void EditCar()
        {
            System.Console.WriteLine("Enter car number: ");
            int index = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter new car name: ");
            string modelName = Console.ReadLine();
            System.Console.WriteLine("Enter new car price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter car type to confirm: ");
            string type = Console.ReadLine();
            if(type=="BMW")
            {
                BMW c = (BMW)GetCar(index);
                
                c.ModelName = modelName; 
                c.Price = price;
            }
            else if(type=="Suzuki")
            {
                Suzuki c = (Suzuki)GetCar(index);
                
                c.ModelName = modelName; 
                c.Price = price;
            }
            else if(type=="Mercedes")
            {
                Mercedes c = (Mercedes)GetCar(index);
                
                c.ModelName = modelName; 
                c.Price = price;
            }
            
            //c.ModelName = modelName;
            //c.Price = price;

        }

        private void DeleteCar()
        {
            ShowCar();
            System.Console.Write("Enter car number: ");
            int index = Convert.ToInt32(Console.ReadLine());
            cars.Remove(GetCar(index));
            System.Console.WriteLine("Delete successfull!");
        }

        private List<Car> cars;

        private string modelName;
        private int price;

        private void ShowCar()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                System.Console.WriteLine("Number: " + i);
                cars[i].ShowInfo();
            }
        }

        public void copyCar(int index)
        {
            Car copyCar = cars[index].Clone();
            cars.Add(copyCar);
        }

        private void AddCar()
        {
            System.Console.WriteLine("1. Mercedes");
            System.Console.WriteLine("2. BMW");
            System.Console.WriteLine("3. Suzuki");
            System.Console.Write("Choose car type: ");
            string choice = Console.ReadLine();
            if (choice == "1" || choice == "Mercedes")
            {
                GetInfo();
                cars.Add(new Mercedes(modelName, price));
            }
            else if (choice == "2" || choice== "BMW")
            {
                GetInfo();
                cars.Add(new BMW(modelName, price));
            }
            else if (choice == "3" || choice=="Suzuki")
            {
                GetInfo();
                cars.Add(new Suzuki(modelName, price));
            }
            else
            {
                System.Console.WriteLine("Invalid type!");
            }
        }

        public Car GetCar(int index)
        {
            return cars[index];
        }

        public CarBoard()
        {
            cars = new List<Car>();
        }

        public void GetInfo()
        {
            
            System.Console.Write("Enter model name of car: ");
            modelName = Console.ReadLine();
            System.Console.Write("Enter price of car: ");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void CopyCar(int index)
        {
            Car copyCar = cars[index].Clone();
            Car.Add(copyCar);
        }
    }
}