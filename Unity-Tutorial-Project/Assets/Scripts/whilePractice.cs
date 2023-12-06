using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class whilePractice : MonoBehaviour
{
    //Variables
    [SerializeField]
    float Numbers = 10f;

    float Rounds = 0f;

    [SerializeField]
    float TargetRounds = 0f;

    // Start is called before the first frame update
    void Start()
    {
       

        //debug message :3
        while (Rounds < TargetRounds)
        {
            Rounds = Rounds + 1f;
            Numbers = Numbers + 2f;
            Debug.Log(Rounds);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
