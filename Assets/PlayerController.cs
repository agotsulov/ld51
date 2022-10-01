using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public Rigidbody body;

    void Start()
    {

    }

    void Update()
    {
        body.velocity = transform.forward * speed;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position, Vector3.up, 10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position, Vector3.up, -10);
        }
    }
}
