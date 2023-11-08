using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableReview : MonoBehaviour
{
    // Editor Variables
    [SerializeField]
    string editorString = "Yoomers";
    [SerializeField]
    int editorInt = 0; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(editorString);  
    }

    // Update is called once per frame
    void Update()
    {
        string funny = "69";
        Debug.Log(funny);

        editorInt = editorInt + 1;
        Debug.Log(editorInt);
    }
}