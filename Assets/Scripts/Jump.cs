using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    bool ground = true;
    public bool jump;
    [Range(1, 10)]
    public float jumpVelocity;
    public void jumpSk()
    {
        jump = true;
    }
    public void grounded()
    {
        ground = true;
    }
    private void Update()
    {

        if (Input.GetKeyDown("space") )
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        if (jump && ground)
        {
            //GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpVelocity,ForceMode.Impulse);
            ground = false;
            jump = false;
        }
    }
}
