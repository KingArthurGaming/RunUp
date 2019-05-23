using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class move1 : MonoBehaviour
{


    public Rigidbody rb;
    public float speed = 20f;



    void FixedUpdate()
    {
        float moveAD = CrossPlatformInputManager.GetAxis("Horizontal");
        //float moveWS = CrossPlatformInputManager.GetAxis("Vertical");
        //float moveWS = Input.GetAxis("Vertical");
        //float moveAD = Input.GetAxis("Horizontal");
        Vector3 movee = new Vector3(moveAD * speed, 0, speed);//(speed/1.5f)
        rb.AddForce(movee);
        if (rb.position.y < -2)
        {
            FindObjectOfType<GameManager>().restart();//.EndGame()

        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collider"))
        {
            FindObjectOfType<GameManager>().restart();//.EndGame()
        }
    }

}
