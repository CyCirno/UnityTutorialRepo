using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputTest : MonoBehaviour
{
    [SerializeField]
    float Speed = 1.0f;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector2 tempVelocity = GetComponent<Rigidbody2D>().velocity;
        
        if (Input.GetButton("MoveRight"))
        {
            tempVelocity.x = Speed;

        }

        if (Input.GetButton("MoveLeft"))
        {
            tempVelocity.x = -Speed;

        }

        if (Input.GetButton("MoveUp"))
        {
            tempVelocity.y = Speed;

        }

        if (Input.GetButton("MoveDown"))
        {
            tempVelocity.y = -Speed;

        }
        
        GetComponent<Rigidbody2D>().velocity = tempVelocity;
    }
}
