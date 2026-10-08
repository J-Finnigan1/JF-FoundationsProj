using UnityEngine;

public class ClicktoDestroy : MonoBehaviour
{
    public GameObject ClickObjToDestroy;
    
    void OnMouseDown()
    {
        Debug.Log("object was clicked");
        // Debug.LogError("Object was clicked"); // this log error will stop play mode in the editor    
        // Debug.LogWarning("Object was clicked");
        Destroy(ClickObjToDestroy);
    }
}
