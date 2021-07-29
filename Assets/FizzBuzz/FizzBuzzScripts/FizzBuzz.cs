using UnityEngine;

namespace FizzBuzz.FizzBuzzScripts
{
    public class FizzBuzz : MonoBehaviour
    {
        public string Process(int number)
        {
            if (DividableBy(15, number))
            {
                return "FizzBuzz";
            }

            if (DividableBy(3, number))
            {
                return "Fizz";
            }

            if (DividableBy(5, number))
            {
                return "Buzz";
            }

            return number.ToString();
        }

        private bool DividableBy(int factor, int number)
        {
            return number % factor == 0;
        }
    }
}