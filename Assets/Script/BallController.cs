using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public float maxSpeed;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(rb.velocity.magnitude > maxSpeed){
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
