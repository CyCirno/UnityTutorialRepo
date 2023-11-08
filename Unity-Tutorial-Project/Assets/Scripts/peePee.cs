using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class peePee : MonoBehaviour
{
    //EditorVariabls
    [SerializeField]
    int messageChoice =0;

    [SerializeField]
    bool Decision = false;

    // Start is called before the first frame update
    void Start()
    {
        if (Decision)
        {
            Debug.Log("That is True :D");   
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
