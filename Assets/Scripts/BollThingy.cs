using UnityEngine;

public class BollThingy : MonoBehaviour
{
private ObjInHand objInHand;
private GiveWitchBook BookInHand;

public bool isInHand = false;
public bool isBookActive = false;

    void OnMouseDown()
    {
        if (objInHand.EnableInHand.activeInHierarchy == false)
        {
            isInHand = true; 
            Debug.Log("OBJ in hand is true");
        }

        if (BookInHand.BookInHand.activeInHierarchy == false)
        {
           isBookActive = true;
        }
    }
}
