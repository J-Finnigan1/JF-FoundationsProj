using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class ObjInHand : MonoBehaviour
{
    public BollThingy boolCheck;
    public GameObject ShelfObj;

    public GameObject EnableInHand;

    
    void OnMouseDown()
    {
        if (boolCheck.isInHand == false)
        {
            if (EnableInHand.activeInHierarchy == false )
            { 
            Debug.Log("object was clicked");

            ShelfObj.SetActive(false);
            EnableInHand.SetActive(true);
            boolCheck.isInHand = true;
        }
    }

        if (boolCheck.isInHand == true )
        {
            Debug.Log("Object is in hand");
        }
    }
}