using System;

namespace Prototype
{
    public class DataNotCorrect : Exception
    {
        public DataNotCorrect() : base("Error: Data not correct!!!")
        {}

        public DataNotCorrect(string message) : base(message)
        {}
            
        
    }
}