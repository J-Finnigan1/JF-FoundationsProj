using System.Collections.Generic;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class ObjInHand : MonoBehaviour
{
    public BollThingy InHandCheck;
    public BollThingy BookCheck;
    public DepositObjInHand DepositCheck;
    public GameObject ShelfObj;
    public GameObject EnableInHand;
    public GameObject MainDialog;
    public GameObject Drink;
    void Start()
    {
       
    }

    void OnMouseDown()
    {
        if (InHandCheck.isInHand == false && BookCheck.isBookActive == true && DepositCheck.ObjDeposited < 5)
        {
            
            if (EnableInHand.activeInHierarchy == false && ShelfObj.tag != "Book" )
            { 
                Debug.Log("object was clicked");

                ShelfObj.SetActive(false);
                EnableInHand.SetActive(true);
                InHandCheck.isInHand = true;
            }

            if(ShelfObj.tag == "Book")
            {
                Debug.Log("no more books");
            }
        }

        if (InHandCheck.isInHand == true )
        {
            Debug.Log("Object is in hand");
        }

        // https://docs.unity.com/en-us/engine/6000.3/script-reference/unityengine/gameobject/tag
        if (BookCheck.isBookActive == false && InHandCheck.isInHand == false)
        {
            if (ShelfObj.tag == "Book")
            {
                Debug.Log("Picked up book"); 
                ShelfObj.SetActive(false);
                EnableInHand.SetActive(true);
                InHandCheck.isInHand = true; 
            }
        }
        
        if (ShelfObj.tag == "SecretEndingBottle" && InHandCheck.isInHand == false)
        {
            Debug.Log("Picked up Bottle"); 
            ShelfObj.SetActive(false);
            EnableInHand.SetActive(true);
            InHandCheck.isInHand = true; 

            Drink.SetActive(true);
            MainDialog.SetActive(false);
        }
    }
}