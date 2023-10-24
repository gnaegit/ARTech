using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LoadFirstScene : MonoBehaviour
{
    public string sceneName;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active scene: " + SceneManager.GetActiveScene().name);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        asyncOperation.completed += new System.Action<AsyncOperation>(sender =>
        {
            OnLoadOperationComplete(sceneName);
        });

        panel.SetActive(false);
    }

    void OnLoadOperationComplete(string sceneName)
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        Debug.Log("Active scene after load: " + SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
