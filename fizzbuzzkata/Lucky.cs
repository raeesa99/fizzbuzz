using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzzkata
{
    public interface IRules
    {
        string Apply();
        bool isApplicable(int number);
    }

    public class Lucky : IRules
    {
        public string Apply()
        {
            return "Lucky";
        }

        public bool isApplicable(int number)
        {
            return number.ToString().Contains('3');
        }
    }

    public class FizzBuzzChecker : IRules
    {
        public string Apply()
        {
            return "FizzBuzz";
        }

        public bool isApplicable(int number)
        {
            return (number % 15 == 0);
        }
    }
}
