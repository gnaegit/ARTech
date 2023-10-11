using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMyScene(string sceneName)
    {
        //SceneManager.LoadScene(sceneName);
        Debug.Log("Active scene before load: " + SceneManager.GetActiveScene().name);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        CallAfterDelay.Create(0.1f, () => {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
            Debug.Log("Active scene after load: " + SceneManager.GetActiveScene().name);
        });
    }
}
