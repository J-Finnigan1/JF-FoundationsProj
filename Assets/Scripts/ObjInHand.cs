using System.Collections.Generic;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class ObjInHand : MonoBehaviour
{
    public BollThingy InHandCheck;
    public BollThingy BookCheck;
    public GameObject ShelfObj;
    public GameObject EnableInHand;

    void Start()
    {
       
    }

    void OnMouseDown()
    {
        if (InHandCheck.isInHand == false && BookCheck.isBookActive == true)
        {
            if (EnableInHand.activeInHierarchy == false )
            { 
            Debug.Log("object was clicked");

            ShelfObj.SetActive(false);
            EnableInHand.SetActive(true);
            InHandCheck.isInHand = true;
        }
    }

        if (InHandCheck.isInHand == true )
        {
            Debug.Log("Object is in hand");
        }

        // https://docs.unity.com/en-us/engine/6000.3/script-reference/unityengine/gameobject/tag
        if (BookCheck.isBookActive == false)
        {
            if (ShelfObj.tag == "Book")
            {
                Debug.Log("Picked up book"); 
                ShelfObj.SetActive(false);
                EnableInHand.SetActive(true);
                InHandCheck.isInHand = true; 
            }
            
            else
            {
                Debug.Log("Witch doesnt have a Book");
            }
        }
    }
}