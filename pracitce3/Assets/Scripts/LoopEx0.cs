using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEx0 : MonoBehaviour
{
    int i = -5;
    // Start is called before the first frame update
    void Start()
    {
        while (i <= 5)
        {
            print(i);
            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
