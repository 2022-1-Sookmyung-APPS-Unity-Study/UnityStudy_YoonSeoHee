using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEx1 : MonoBehaviour
{
    int SummArray(int[] arr)
    {
        int result = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
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
