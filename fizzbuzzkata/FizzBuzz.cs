using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzzkata
{
    public class FizzBuzz
    {
        public string Check(int number)
        {

            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();

            }
        }

        internal object Check(int[] input)
        {
            var results = new List<string>();
            for (int i = 0; i < input.Count(); i++)
            {
                Check(input[i]);
                results.Add(Check(input[i]));
                
            }
            return string.Join(", ", results);
        }
    }
}
