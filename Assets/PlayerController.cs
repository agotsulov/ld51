using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public Rigidbody body;

    public Vector3 ass;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // body.AddForce(transform.forward * speed, ForceMode.VelocityChange);
        body.velocity = transform.forward * speed;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(transform.position - ass, Vector3.up, 1);
        }
        Debug.Log(transform.rotation.y);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(transform.position - ass, Vector3.up, -1);
        }
        if (transform.rotation.y <= 0.5 && transform.rotation.y >= -0.5) { }
        if (transform.rotation.y <= 0.5 && transform.rotation.y >= -0.5) { };
    }
}
