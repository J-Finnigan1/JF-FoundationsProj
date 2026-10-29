using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;


public class DestroyHand_Cone : MonoBehaviour
{
    public BollThingy boolCheck;

    public GameObject Cone_hand;
    public GameObject Cone_Cauld;

    public GameObject Cube_hand;
    public GameObject Cube_Cauld;

  Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

   
   void OnMouseDown()
    {
        if(boolCheck.isInHand == true)
        {
            if (Cone_hand.activeInHierarchy == true ) 
                {
                Cone_hand.SetActive(false);

                Cone_Cauld.SetActive(true);

                boolCheck.isInHand = false;

                animator.SetBool("IsClicked", true);
                }

            if (Cube_hand.activeInHierarchy == true ) 
                {
                Cube_hand.SetActive(false);

                Cube_Cauld.SetActive(true);

                boolCheck.isInHand = false;

                animator.SetBool("IsClicked", true);
                }
            











        }
    }
}
