using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    //Property for car speed
    public float Speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //A method for moving the cars back and forth
    private void Move()
    {
        if (transform.position.x > 860)
        {
            transform.Rotate(0, 180, 0);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 4);
        }
        else if (transform.position.x < 700)
        {
            transform.Rotate(0, 180, 0);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 4);
        }
        transform.Translate(0, 0, Speed);
    }
}
