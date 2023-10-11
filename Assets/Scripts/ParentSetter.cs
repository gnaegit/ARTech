using UnityEngine;

public class ParentSetter : MonoBehaviour
{
    public GameObject parent;

    void Start()
    {
        GameObject child = gameObject;

        // Same as above, except worldPositionStays set to false
        // makes the child keep its local orientation rather than
        // its global orientation.
        child.transform.SetParent(parent.transform, false);
    }
}
