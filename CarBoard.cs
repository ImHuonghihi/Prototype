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
            System.Console.WriteLine("3: Edit Car");
            System.Console.WriteLine("4: Delete Car");
            System.Console.WriteLine("5: Duplicate Car");
            System.Console.WriteLine("0: Exit");
        }

        protected override void DoTask(int option)
        {
            switch(option)
            {
                case 1: AddCar();               break;
                case 2: ShowCar();              break;
                case 3: EditCar();              break;
                case 4: DeleteCar();            break;
                case 5: DuplicateCar();         break;
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
            if (cars.Count == 0)
            {
                System.Console.WriteLine("List car is empty. Cannot duplicate!!!");
            }
            else
            {
                ShowCar();
                System.Console.WriteLine("Enter car number: ");
                int index = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter new car name: ");
                string modelName = Console.ReadLine();
                System.Console.Write("Enter new car price: ");
                int price = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter car type to confirm: ");
                string type = Console.ReadLine();
                if(type=="BMW")
                {
                    BMW c = (BMW)GetCar(index);

                    c.ModelName = modelName; 
                    c.Price = price;
                    System.Console.Write("Enter new color: ");
                    color = Console.ReadLine();
                    
                    c.Color = color;
                    
                }
                else if(type=="Suzuki")
                {
                    Suzuki c = (Suzuki)GetCar(index);
                    
                    c.ModelName = modelName; 
                    c.Price = price;
                    System.Console.Write("Enter new size: ");
                    size = Convert.ToInt32(Console.ReadLine());
                    
                    c.Size = size;

                }
                else if(type=="Mercedes")
                {
                    Mercedes c = (Mercedes)GetCar(index);
                    
                    c.ModelName = modelName; 
                    c.Price = price;
                    System.Console.Write("Enter new max speed: ");
                    maxSpeed = Convert.ToInt32(Console.ReadLine());
                    c.MaxSpeed = maxSpeed;
                }
            }
            System.Console.WriteLine("Edit successful!!!");
        }

        private void DeleteCar()
        {
            if(cars.Count == 0)
            {
                System.Console.WriteLine("List car is empty!");
            }
            else
            {
                ShowCar();
                System.Console.Write("Enter car number: ");
                int index = Convert.ToInt32(Console.ReadLine());
                cars.Remove(GetCar(index));
                System.Console.WriteLine("Delete successfull!");
            }
            
        }

        private List<Car> cars;

        private string modelName;
        private int price;

        private void ShowCar()
        {
            if (cars.Count == 0)
            {
                System.Console.WriteLine("Sorry. List car is empty.!!!");
            }
            else
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    System.Console.WriteLine("Number: " + i);
                    cars[i].ShowInfo();
                }
            }
            
        }

    

        private void AddCar()
        {
            System.Console.WriteLine("----------------Here is the list of type of car----------------");
            System.Console.WriteLine("1. Mercedes");
            System.Console.WriteLine("2. BMW");
            System.Console.WriteLine("3. Suzuki");
            System.Console.Write("Pls Choose type of car: ");
            string choice = Console.ReadLine();
            if (choice == "1" || choice == "Mercedes")
            {
                GetInfo();
                while (true)
                {
                    try
                    {
                        System.Console.Write("Enter max speed of car: ");
                        maxSpeed = Convert.ToInt32(Console.ReadLine());
                        cars.Add(new Mercedes(modelName, price, maxSpeed));
                        return;
                    }
                    catch (FormatException ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                    catch (DataNotCorrect ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (choice == "2" || choice== "BMW")
            {
                GetInfo();
                while (true)
                {
                    try
                    {
                        System.Console.Write("Enter color of car: ");
                        color = Console.ReadLine();
                        cars.Add(new BMW(modelName, price, color ));
                        return;
                    }
                    catch (FormatException ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                    catch (DataNotCorrect ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
            }
            else if (choice == "3" || choice=="Suzuki")
            {
                GetInfo();
            
                while (true)
                {
                    try
                    {
                        System.Console.Write("Enter size of car: ");
                        size = Convert.ToInt32(Console.ReadLine());
                        cars.Add(new Suzuki(modelName, price, size));
                        return;
                    }
                    catch (FormatException ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                    catch (DataNotCorrect ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Invalid type!");
            }
            System.Console.WriteLine("Add successful!!!");
        }

        public void copyCar(int index)
        {
            Car copyCar = cars[index].Clone();
            cars.Add(copyCar);
        }

        public Car GetCar(int index)
        {
            return cars[index];
        }

        public CarBoard()
        {
            cars = new List<Car>();
        }

        int maxSpeed;
        string color; 
        int size;


        public void GetInfo()
        {
            while (true)
            {
                try
                {
                    System.Console.Write("Enter model name of car: ");
                    modelName = Console.ReadLine();
                    while (string.IsNullOrEmpty(modelName))
                    {
                        System.Console.WriteLine("Invalid. Model name cannot be null. Pls try again!");
                        System.Console.Write("Enter model name again. Pls: ");
                        modelName = Console.ReadLine();
                    }
                    System.Console.Write("Enter price of car: ");
                    price = Convert.ToInt32(Console.ReadLine());
                    while (price < 0)
                    {
                        System.Console.WriteLine("Invalid. Price cannot less than 0. Pls try again!");
                        System.Console.Write("Enter price again. Pls: ");
                        price = Convert.ToInt32(Console.ReadLine());
                    }

                    return;
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (DataNotCorrect ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }


        public void DuplicateCar()
        {
            if (cars.Count == 0)
            {
                System.Console.WriteLine("List car is empty. Cannot duplicate!!!");
            }
            else if (cars.Count == 1)
            {
                Car copyCar = cars[0].Clone();
                cars.Add(copyCar);
            }
            else
            {
                ShowCar();
                System.Console.Write("Enter number of car you want to duplicate: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Car copyCar = cars[index].Clone();
                cars.Add(copyCar);
                System.Console.WriteLine("Duplicate successful!!");
                
            }
        }
    }
}