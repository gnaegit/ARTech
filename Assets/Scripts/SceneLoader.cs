using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMyScene(string sceneName)
    {
        //SceneManager.LoadScene(sceneName);
        Debug.Log("Active scene before load: " + SceneManager.GetActiveScene().name);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        AsyncOperation asyncOperation =  SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        asyncOperation.completed += new System.Action<AsyncOperation>(sender =>
        {
            OnLoadOperationComplete(sceneName);
        });
    }

    void OnLoadOperationComplete(string sceneName)
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        Debug.Log("Active scene after load: " + SceneManager.GetActiveScene().name);
    }
}


