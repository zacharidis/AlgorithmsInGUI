using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInGUI.Classes
{
    public class FizzBuzz
    {
        FizzBuzz() { }
        
        public string Solve(int input)
        {
            StringBuilder stringBuilder= new StringBuilder();

            for(int i=1; i<=input; i++)
            {
                if (input % 3 == 0 && input % 5 == 0)
                {
                    stringBuilder.AppendLine($"{i} is a FizzBuzz !!!");
                    stringBuilder.AppendLine();

                } else if (input % 3 == 0 )
                {
                    stringBuilder.AppendLine($"{i} is a Fizz !!!");
                    stringBuilder.AppendLine();
                } else if (input % 5 == 0)
                {
                    stringBuilder.AppendLine($"{i} is a Buzz !!!");
                    stringBuilder.AppendLine();
                } else
                {
                    stringBuilder.AppendLine($"{i} is a just a number ");
                    stringBuilder.AppendLine();
                }



            }

             string returnValue = stringBuilder.ToString();



            return returnValue;

        }
    }
}
