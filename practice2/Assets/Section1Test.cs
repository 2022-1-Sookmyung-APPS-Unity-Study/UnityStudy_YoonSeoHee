using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section1Test : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public int birthYear;

    // Start is called before the first frame update
    void Start()
    {
        // Problem 1
        print("Your name is: " + firstName + " " + lastName);

        // Problem 2
        print("Your initials are: " + firstName[0] + lastName[0]);

        // Problem 3
        print("The length of your full name is: " + (firstName + lastName).Length);

        // Problem 4
        int randomNumber = Random.Range(0, firstName.Length);
        print("Here is a random number from your first name: " + firstName[randomNumber]);

        // Problem 5
        int age = 2022 - birthYear;
        print("You were born in " + birthYear + " which means that you are " + age.ToString() + " years old");

        // Problem 6
        int daysAlive = age + 365;
        print("You have been alive for " + daysAlive.ToString() + " days");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
