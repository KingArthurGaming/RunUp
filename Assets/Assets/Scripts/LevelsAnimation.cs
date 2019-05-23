using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsAnimation : MonoBehaviour
{

    public Animator Anim;
    bool anim;
    private void Start()
    {
        Anim.GetComponent<Animator>();
    }


    public void PlayIN()
    {
        if (!anim)
        {
            Anim.Play("LevelOpen");
            anim = true;
        }
        else
        {
            Anim.Play("LevelClose");
            anim = false;
        }
    }
}
