using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 9;


            int result= Topla(ref number1,number2);
            Console.WriteLine(result);
            

        }
        static int  Topla(ref int number1, int number2)
        {
            int result;
          number1 = 30;
            return result= number1 + number2;
        }
    }
}
