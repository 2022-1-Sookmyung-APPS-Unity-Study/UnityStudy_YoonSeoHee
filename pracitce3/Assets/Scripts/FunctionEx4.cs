using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionEx4 : MonoBehaviour
{
    int Factorials(int number)
    {
        int result = 1;

        for(int i = 0; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
