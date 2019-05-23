using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
    
    public void start(int SceneIndex)
    {
        
        SceneManager.LoadScene(SceneIndex);
    }
    
}
