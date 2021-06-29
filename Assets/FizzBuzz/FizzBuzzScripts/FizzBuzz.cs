using UnityEngine;

namespace FizzBuzz.FizzBuzzScripts
{
    public class FizzBuzz : MonoBehaviour
    {
        public string Process(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
