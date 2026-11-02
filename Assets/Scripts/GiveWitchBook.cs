using UnityEngine;

public class GiveWitchBook : MonoBehaviour
{
Animator animator;    
public BollThingy BoolCheck;
public GameObject BookInHand;
public GameObject WitchBook;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void OnMouseDown()
    {
        if (BoolCheck.isInHand == true)
        {
            if(BookInHand.activeInHierarchy == true)
            {
                Debug.Log("Book Deposited");
                BookInHand.SetActive(false);
                BoolCheck.isInHand = false;
                animator.SetTrigger("GivenBook");
            }
        }
    }
}
