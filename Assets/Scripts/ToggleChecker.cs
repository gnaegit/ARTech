using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ToggleChecker : MonoBehaviour
{
    [System.Serializable] public class OnAllTogglesOn : UnityEvent { }
    [SerializeField] OnAllTogglesOn onAllTogglesOn;
    
    public Toggle[] toggles;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool allTogglesOn = true;
        foreach (var toggle in toggles) 
        {
            if(toggle.isOn == false)
            {
                allTogglesOn = false;
                break;
            }
        }

        if (allTogglesOn == true) 
        {
            onAllTogglesOn.Invoke();
        }
    }
}
