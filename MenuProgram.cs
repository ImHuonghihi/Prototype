using System;
namespace Prototype
{
    public abstract class MenuProgram
    {
        public void Run()
        {
            bool running = true;
            while(running)
            {
                System.Console.WriteLine("**************Welcome to Luxury Car Factory**************");
                System.Console.WriteLine("                     Here is the Menu                    ");
                PrintMenu();
                int option = ChooseOption();
                DoTask(option);
                if(option == 0) running = false;
            }
        }

        protected abstract void PrintMenu();

        protected abstract void DoTask(int option);

        protected virtual int ChooseOption()
        {
            int option = CheckInput.CheckInteger("Enter your choice: ");
            System.Console.WriteLine();           
            return option;
        }
    }
}