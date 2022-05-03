using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEx3 : MonoBehaviour
{
    int Max(int[] arr)
    {
        int max = arr[0];

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
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
