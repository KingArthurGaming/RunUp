using UnityEngine;

public class TurotialAnimation : MonoBehaviour
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
            Anim.Play("TutorialOpen");
            anim = true;
            //Anim.Play("New State");
        }
        else
        {
            Anim.Play("TutorialClose");
            anim = false;
           // Anim.Play("New State");
        }
    }
}
