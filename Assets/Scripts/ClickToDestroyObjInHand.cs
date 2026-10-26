using UnityEngine;

public class ClickToDestroyObjInHand : MonoBehaviour
{

       public GameObject Cone_Hand;
       public GameObject Cube_Hand;
       public GameObject Sphere_Hand;
       public GameObject Book_Hand;
    


    void OnMouseDown()
    {
        Debug.Log("object was clicked");
        
    if (Cone_Hand.activeInHierarchy == true )
        Destroy(Cone_Hand);

    if (Cube_Hand.activeInHierarchy == true )
        Destroy(Cube_Hand);

    if (Sphere_Hand.activeInHierarchy == true )
        Destroy(Sphere_Hand);    
    
    if (Book_Hand.activeInHierarchy == true )
        Destroy(Book_Hand);

    }
}

