using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractice : MonoBehaviour
{
    //variables
    [SerializeField]
    int target = 50;

    [SerializeField]
    int startPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int count = startPoint; count <= target; count += 2)
        {
            Debug.Log(count);
           
        }
        //Debug.Log("Blast Off (this is cringe)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
