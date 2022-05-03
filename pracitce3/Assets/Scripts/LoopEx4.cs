using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEx4 : MonoBehaviour
{
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (i <= 100)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                print(i);
            }
            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
