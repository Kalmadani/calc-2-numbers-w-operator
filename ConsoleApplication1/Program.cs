using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose any number");
            int userFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operator");
            string userOperator = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Choose a second number");
            int userSecondNumber = Convert.ToInt32(Console.ReadLine());

            CalcClass calcClass = new CalcClass();
            calcClass.DetermineOperator(userOperator, userFirstNumber, userSecondNumber);
        }
    }
}
