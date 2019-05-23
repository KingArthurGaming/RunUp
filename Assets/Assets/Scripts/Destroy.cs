using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public void destroy()
    {
        Destroy(this.gameObject);
    }
    void FixedUpdate()
    {
        Invoke("destroy", 4.7f);
    }
}
