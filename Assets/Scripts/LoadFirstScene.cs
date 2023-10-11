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
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        CallAfterDelay.Create(0.1f, () => {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
            Debug.Log("Active scene: " + SceneManager.GetActiveScene().name);
        });
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
