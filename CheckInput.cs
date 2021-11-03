using System;
namespace Prototype
{
    public class CheckInput
    {
        public static int CheckInteger(string tempt)
        {
            bool wrong = true;
            int i = 0;

            while (wrong)
            {
                System.Console.Write(tempt);
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    wrong = false;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Input number is wrong. Please try again!!!");
                }
            }
            return i;
        }
    }
}