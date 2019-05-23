﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Jump>().grounded();
        }
    }
}
