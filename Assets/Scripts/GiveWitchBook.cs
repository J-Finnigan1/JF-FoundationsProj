using UnityEngine;

public class GiveWitchBook : MonoBehaviour
{
Animator animator;    
public BollThingy InHandCheck;
public BollThingy BookCheck;

public GameObject BookInHand;
public GameObject WitchBook;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void OnMouseDown()
    {
        if (InHandCheck.isInHand == true)
        {
            if(BookInHand.activeInHierarchy == true)
            {
                Debug.Log("Book Deposited");
                BookInHand.SetActive(false);
                InHandCheck.isInHand = false;
                BookCheck.isBookActive = true;
                animator.SetTrigger("GivenBook");
            }
        }
    }
}
