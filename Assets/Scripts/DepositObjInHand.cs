using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


public class DepositObjInHand : MonoBehaviour
{  
    Animator animator;
    public BollThingy boolCheck;
    public GameObject Cone_Hand;
    public GameObject Cube_Hand;
    public GameObject Sphere_Hand;
    public GameObject Rice_Hand;    
    public GameObject Green_Hand;

    public int ObjDeposited = 0;
    public bool AnimLock = false;

    void Start()
    {
        animator=GetComponent<Animator>();
    }


   
   void OnMouseDown()
    {
       

        if(boolCheck.isInHand == true && AnimLock == false) // if there is an "object in hand" then...
        {
            if (Cone_Hand.activeInHierarchy == true ) 
            {
                Cone_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("ConePotion");
                ObjDeposited = ObjDeposited + 1;
            }

            if (Cube_Hand.activeInHierarchy == true ) 
            {
                Cube_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("CubePotion");
                ObjDeposited = ObjDeposited + 1;
            }

            if (Sphere_Hand.activeInHierarchy == true ) 
            {
                Sphere_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("SpherePotion");
                ObjDeposited = ObjDeposited + 1;
            }

            if (Rice_Hand.activeInHierarchy == true ) 
            {
                Rice_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("RicePlate");
                ObjDeposited = ObjDeposited + 1;
            }

            if (Green_Hand.activeInHierarchy == true ) 
            {
                Green_Hand.SetActive(false);
                boolCheck.isInHand = false;
                animator.SetTrigger("GreenPlate");
                ObjDeposited = ObjDeposited + 1;
            }
        }
        if(AnimLock == true)
        {
            Debug.Log("Patience, young padawan. there is an animation playing");
        }
    }
}

