using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string Process(int number)
    {
        if (number == 3 || number == 6 || number == 9)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}
