using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;


public class DestroyHand_Cone : MonoBehaviour
{  
    Animator animator;

    public BollThingy boolCheck;
    public GameObject Cone_Hand;
    public GameObject Cube_Hand;
    public GameObject Sphere_Hand;
    public GameObject Rice_Hand;    
    public GameObject Green_Hand;

    void Start()
    {
        animator=GetComponent<Animator>();
    }

   
   void OnMouseDown()
    {
        if(boolCheck.isInHand == true) // if there is an "object in hand" then...
        {
            if (Cone_Hand.activeInHierarchy == true ) 
            {
                Cone_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("ConePotion");

            }

            if (Cube_Hand.activeInHierarchy == true ) 
            {
                Cube_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("CubePotion");

            }

            if (Sphere_Hand.activeInHierarchy == true ) 
            {
                Sphere_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("SpherePotion");
            }

            if (Rice_Hand.activeInHierarchy == true ) 
            {
                Rice_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("RicePlate");
            }
            if (Green_Hand.activeInHierarchy == true ) 
            {
                Green_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("GreenPlate");
            }

        }
    }
}
