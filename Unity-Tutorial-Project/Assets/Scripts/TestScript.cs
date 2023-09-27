using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Editor Variables
    [SerializeField]
    string editorString = "Yoomers";

    // Private Variables
    string combinedString;
    string firstString = "You shall not";
    string secondString = "PASS";

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("Ever on and on");
        Debug.Log("I continue circling");
        Debug.Log("With nothing but my hate");
        Debug.Log("In a carousel of agony");

        transform.Translate(0, 0, 0);
        */

        // Declare a variable called firstString

        Debug.Log(editorString);
       
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("I love Yoomers");
        // transform.Translate(0, 0, 0);
        combinedString = firstString + " " + secondString;
        Debug.Log(combinedString);
    }
}
