using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEx2 : MonoBehaviour
{
    void PrintReverse (string[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            PrintReverse(arr[i]);
        }
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
