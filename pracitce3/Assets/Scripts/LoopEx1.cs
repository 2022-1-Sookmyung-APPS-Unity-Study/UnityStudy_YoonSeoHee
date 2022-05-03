using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopEx1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -5; i <= 5; i += 1)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
