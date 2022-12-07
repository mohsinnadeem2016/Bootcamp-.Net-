using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Calculator
    {
        // Complained type polymorphism
       public int Addition(int x, int y)
      {
        return x + y;
        }
  
        public int Addition(string x , string y)
        {
            
            return Convert.ToInt32(x) + Convert.ToInt32 (y);
        }

        public int Subract(int x, int y)
        {
            return x - y;
        }


        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }


    }
}