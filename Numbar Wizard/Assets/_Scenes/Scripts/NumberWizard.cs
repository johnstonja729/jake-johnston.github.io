using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;

    int guess = 500;

    // Start is called before the first frame update
    void Start() 
    {
        print("welcome to Number Wizard");
        print("Think of a number, but dont tell me what it is");

        print("The highest number you can choose is" + max);
        print("The lowest number you can choose is " + min);

        print("is your number higher or equal to " + guess + "?");
        print("Up = higher, Down = lower, return = equal");

        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKeyDown("KeyCode.UpArrow")) {
            min = guess;
            guess = (max + min) / 2;
            print ("is your number higher or equal to " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = (max + min) / 2;
            print("is your number higher or equal to " + guess + "?")        }
        else if (Input.GetKeyDown(KeyCode.Return)) { 
            print("I won!");
        }
    }
}
