using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CalcClass
    {
        public void DetermineOperator(string userOperator, int userFirstNumber, int userSecondNumber)
        {

            if (userOperator == "+")
            {
                Add(userFirstNumber, userSecondNumber);
            }
            if (userOperator == "-")
            {
                Subtract(userFirstNumber, userSecondNumber);
            }

            //switch (userOperator)
            //{
            //    case "+":
            //        Add(userFirstNumber, userSecondNumber);
            //        break;
            //    case "-":
            //        Subtract(userFirstNumber, userSecondNumber);
            //        break;
            //}
        }

            private void Subtract(int subFirstNumber, int subSecondNumber)
        {
            int answer = subFirstNumber - subSecondNumber;
            Console.WriteLine("The answer is " + answer);
            Console.ReadKey();

        }

        private void Add (int addFirstNumber, int addSecondNumber)
        {
            int answer = addFirstNumber + addSecondNumber;
            Console.WriteLine("The answer is " + answer);
            Console.ReadKey();
        }
    }
}
