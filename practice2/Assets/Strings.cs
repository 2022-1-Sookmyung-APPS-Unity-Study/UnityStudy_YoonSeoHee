using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hello my name is Seohee");
        print("hello".Length + "seohee".Length); // 5 + 6 = 11
        print("elephant".Substring(3, 4)); // "phan"
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
