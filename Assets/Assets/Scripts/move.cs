using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {


    public Rigidbody rb;
    public float speed = 20f;



    void FixedUpdate()
    {
        float moveAD = 0;
        Vector3 movee = new Vector3(moveAD * (speed / 1.5f), 0, speed);
        rb.AddForce(movee);
    }
}
