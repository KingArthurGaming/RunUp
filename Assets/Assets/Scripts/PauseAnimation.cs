using UnityEngine;

public class PauseAnimation : MonoBehaviour
{

    public Animator Anim;
    private void Start()
    {
        Anim.GetComponent<Animator>();
    }
    public void StopTime()
    { Time.timeScale = 0; }
    
    public void PlayIN()
    {
        Anim.Play("Pause");
        Invoke("StopTime", 0.4f);
    }
    public void Playout()
    {
        Anim.Play("Play");
        Time.timeScale = 1;
    }


}
