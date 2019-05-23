using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject win;
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.06f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            win.SetActive(true);
        }
    }
}
