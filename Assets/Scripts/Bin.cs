using UnityEngine;

public class Bin : MonoBehaviour
{
   public BollThingy boolCheck;
   public GameObject Book_Hand;
   public GameObject Bottle_Hand;
    public GameObject Cone_Hand;
    public GameObject Cube_Hand;
    public GameObject Sphere_Hand;
    public GameObject Rice_Hand;    
    public GameObject Green_Hand;

    public int Softlock = 0;

    // Update is called once per frame
    public void OnMouseDown()
    {
        if(boolCheck.isInHand == true)
        {
            
            if (Cone_Hand.activeInHierarchy == true ) 
            {
                Cone_Hand.SetActive(false);
                boolCheck.isInHand = false;
                Softlock = Softlock + 1;
            }

            if (Cube_Hand.activeInHierarchy == true ) 
            {
                Cube_Hand.SetActive(false);
                boolCheck.isInHand = false;
                Softlock = Softlock + 1;
            }

            if (Sphere_Hand.activeInHierarchy == true ) 
            {
                Sphere_Hand.SetActive(false);
                boolCheck.isInHand = false;
                Softlock = Softlock + 1;
            }

            if (Rice_Hand.activeInHierarchy == true ) 
            {
                Rice_Hand.SetActive(false);
                boolCheck.isInHand = false;
                Softlock = Softlock + 1;
            }

            if (Green_Hand.activeInHierarchy == true ) 
            {
                Green_Hand.SetActive(false);
                boolCheck.isInHand = false;
                Softlock = Softlock + 1;
            }
            
            if (Book_Hand.activeInHierarchy == true ) 
            {
                Book_Hand.SetActive(false);
                boolCheck.isInHand = false;
            }
            
            if (Bottle_Hand.activeInHierarchy == true ) 
            {
                Bottle_Hand.SetActive(false);
                boolCheck.isInHand = false;
                Softlock = Softlock + 1;
            }
            
            Debug.Log("Softlock Counter: " + Softlock);

        }   
    }
}

