using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayEx4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool IsUniform(string[] arr)
        {
            bool result = true;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[0] != arr[i])
                {
                    result = false;
                }
            }
            return result;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
