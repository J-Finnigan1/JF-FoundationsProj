using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class DestroyHand_Cone : MonoBehaviour
{
    public GameObject Cone_hand;
    public GameObject Cone_Cauld;

  Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

   
   void OnMouseDown()
    {
         if (Cone_hand.activeInHierarchy == true ) 
            {
            Cone_hand.SetActive(false);
            Cone_Cauld.SetActive(true);
            animator.SetBool("IsClicked", true);
            }
    }
}
