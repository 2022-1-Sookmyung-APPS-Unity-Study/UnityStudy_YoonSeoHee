using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsExercise : MonoBehaviour
{
    [Range(0, 100)]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if (score > 90)
        {
            print("You got an A.");
        } else if (score > 80)
        {
            print("You got a B.");
        } else if (score > 70)
        {
            print("You got a C.");
        } else if (score > 65)
        {
            print("You got a D.");
        }
        else
        {
            print("You got a E.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
