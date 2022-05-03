using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEx2 : MonoBehaviour
{
    int i = 10;

    // Start is called before the first frame update
    void Start()
    {
        while (i <= 50)
        {
            print(i);
            i += 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
