using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public float Delay = 0f;
    public bool pc = true;
    public void CompleteLevel()
    {

        Debug.Log("level won");
    }
    private void Start()
    {
        //if (pc)
        //{
        //    int width = 900/2;
        //    int height = 1600/2; // or something else
        //    bool isFullScreen = false; // should be windowed to run in arbitrary resolution
        //    int desiredFPS = 60; // or something else

        //    Screen.SetResolution(width, height, isFullScreen, desiredFPS);
        //}
        Time.timeScale = 1f;
        Time.timeScale += (0.5f) * Time.unscaledDeltaTime;
    }
    public void restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //private void Update()
    //{
    //    if (end == true)
    //    {
    //        Time.timeScale += (0.5f) * Time.unscaledDeltaTime;
    //        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    //    }
    //}
    public void EndGame()
    {
        //FindObjectOfType<LevelChanger>().FadeToLevel(SceneManager.GetActiveScene().name);
        Time.timeScale = 0.05f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
       // Debug.Log("GAME OVER");
        Invoke("restart", Delay);
    }
}
