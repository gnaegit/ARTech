using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MakeButtonInteractableOnSceneLoad : MonoBehaviour
{
    public Button[] buttons;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Register OnSceneLoaded callback");
        SceneManager.sceneLoaded += OnSceneLoaded;

        foreach(Button button in buttons) 
        {
            button.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);

        foreach(Button button in buttons)
        {
            if(button.name == scene.name)
            {
                button.interactable = true;
            }
        }
    }
}
