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
          

            List<IRules> rules = new List<IRules> { new Lucky(), new FizzBuzzChecker(), new Fizz(), new Buzz() };

            foreach (var rule in rules)
            {
                if (rule.isApplicable(number))
                {
                    return rule.Apply();
                }
            }
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
