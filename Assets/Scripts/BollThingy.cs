using UnityEngine;

public class BollThingy : MonoBehaviour
{
private ObjInHand objInHand;

public bool isInHand = false;

    void OnMouseDown()
    {
        if (objInHand.EnableInHand.activeInHierarchy == false)
        {
            isInHand = true; 

        }

            
    }
}
