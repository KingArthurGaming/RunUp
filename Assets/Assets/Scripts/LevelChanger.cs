using UnityEngine;

public class LevelChanger : MonoBehaviour
{

    public Animator animator;
    public void FadeToLevel(string levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }
}
