using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Editor Variables
    [SerializeField]
    string editorString = "Yoomers";
    [SerializeField]
    float targetScale = 1.0f;
    [SerializeField]
    SpriteRenderer playerSprite = null;
    [SerializeField]
    Color spriteColor = Color.white;


    // Private Variables
    string combinedString;
    string firstString = "You shall not";
    string secondString = "PASS";

    Vector3 changingScale = new Vector3(1.0f, 1.0f, 1.0f);

    

    

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
        playerSprite.color = spriteColor;

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("I love Yoomers");
        // transform.Translate(0, 0, 0);
        combinedString = firstString + " " + secondString;
        Debug.Log(combinedString);

        targetScale = targetScale + 0.1f;
        Debug.Log(targetScale);

        changingScale.x = targetScale;
        changingScale.y = targetScale;
        changingScale.z = targetScale;

        transform.localScale = changingScale;
    }
}
