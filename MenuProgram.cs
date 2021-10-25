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
            Console.Write("Enter your choice: ");
            int option = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();           
            return option;
        }
    }
}