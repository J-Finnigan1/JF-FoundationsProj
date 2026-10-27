using UnityEngine;

public class HandObjCount : MonoBehaviour
{
public int count = 0;
public GameObject HandCone;


    // Update is called once per frame
    void OnMouseDown()
    {
        if (HandCone.activeInHierarchy == true)
        {
            count = 1;
            Debug.Log(count);
        }

        if (HandCone.activeInHierarchy == false)
        {
            count = 0;
            Debug.Log(count);

        }
        

    }
}
