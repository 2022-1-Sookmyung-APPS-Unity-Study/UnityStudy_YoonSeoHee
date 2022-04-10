using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanLogic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        bool complexStement1 = 5 < 10 && 5 != 5; // true + false -> false because &&
        print(complexStement1);

        bool complexStement2 = 5 < 10 || 5 != 5; // true + false -> true because ||
        print(complexStement2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
