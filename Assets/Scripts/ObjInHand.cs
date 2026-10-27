using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class ObjInHand : MonoBehaviour
{
    public GameObject ShelfObj;

    public GameObject InHandChecker;
    //the box is used as a debugging tool - visual flag (and placeholder for script linking)

    public GameObject EnableInHand;

    
    void OnMouseDown()
    {
        if (InHandChecker.activeInHierarchy == false)
        {
            if (EnableInHand.activeInHierarchy == false )
            { 
            

            Debug.Log("object was clicked");
            Destroy(ShelfObj);
            
            EnableInHand.SetActive(true);
            InHandChecker.SetActive(true);
            }
        }

        if (InHandChecker.activeInHierarchy == true )
        {
            Debug.Log("Object is in hand");
            
        }


    }
}