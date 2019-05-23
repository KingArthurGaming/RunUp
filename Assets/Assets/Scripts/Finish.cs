using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject win;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            win.SetActive(true);
            Time.timeScale = 0.05f;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
    }
}
