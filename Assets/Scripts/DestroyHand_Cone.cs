using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class DestroyHand_Cone : MonoBehaviour
{
    public GameObject Cone_hand;
    public GameObject Cone_Cauld;
    public GameObject InHandChecker;

  Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

   
   void OnMouseDown()
    {
        if(InHandChecker.activeInHierarchy == true)
        {
            if (Cone_hand.activeInHierarchy == true ) 
                {
                Cone_hand.SetActive(false);
                Cone_Cauld.SetActive(true);
                InHandChecker.SetActive(false);
                animator.SetBool("IsClicked", true);
                }
        }
    }
}
