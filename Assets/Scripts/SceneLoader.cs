using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        //SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
    }
}
