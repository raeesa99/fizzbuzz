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
            var rule = new Lucky();

            if (rule.isApplicable(number))
            {
                return rule.Apply();
            }

            var rule1 = new FizzBuzzChecker();

            if (rule1.isApplicable(number))
                {
                return rule1.Apply();
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
