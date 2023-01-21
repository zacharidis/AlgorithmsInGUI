using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInGUI.Classes
{
    public class FizzBuzz
    {
       
        
        public StringBuilder Solve(int input)
        {
            StringBuilder stringBuilder= new StringBuilder();

            for(int i=1; i<=input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    stringBuilder.AppendLine($"{i} is a FizzBuzz !!!");
                    

                } else if (i % 3 == 0 )
                {
                    stringBuilder.AppendLine($"{i} is a Fizz !!!");
                    
                } else if (i % 5 == 0)
                {
                    stringBuilder.AppendLine($"{i} is a Buzz !!!");
                    
                } else
                {
                    stringBuilder.AppendLine($"{i} is a just a number ");
                    
                }



            }





            return stringBuilder;
        }
    }
}
