using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


public class move1 : MonoBehaviour
{


    public Rigidbody rb;
    public float speed = 20f;



    void FixedUpdate()
    {
        float moveAD = CrossPlatformInputManager.GetAxis("Horizontal");
        //float moveWS = CrossPlatformInputManager.GetAxis("Vertical");
        float moveWS = Input.GetAxis("Vertical");
        //float moveAD = Input.GetAxis("Horizontal");
        Vector3 movee = new Vector3(moveAD * speed, 0,speed);
        rb.AddForce(movee);

        if (rb.position.y < -4)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
