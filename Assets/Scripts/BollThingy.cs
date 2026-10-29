using UnityEngine;

public class BollThingy : MonoBehaviour
{
public ObjInHand objInHand;

public bool isInHand = false;

    void OnMouseDown()
    {
        if (objInHand.EnableInHand.activeInHierarchy == false)
        {
            isInHand = true; 

        }

            
    }
}
