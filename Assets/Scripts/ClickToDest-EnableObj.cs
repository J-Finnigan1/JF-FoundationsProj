using NUnit.Framework.Constraints;
using UnityEngine;

public class ClicktoDest_EnableObj : MonoBehaviour
{
    public GameObject ClickObjToDestroy;
    public GameObject EnableInHand;
    
    void OnMouseDown()
    {
        if (EnableInHand.activeInHierarchy == false )
        {

        Debug.Log("object was clicked");
        // Debug.LogError("Object was clicked"); // this log error will stop play mode in the editor    
        // Debug.LogWarning("Object was clicked");
        Destroy(ClickObjToDestroy);
        
        EnableInHand.SetActive(true);
    }

        else
        {
            Debug.Log("You already have an object in your hand");
        }
    }
}