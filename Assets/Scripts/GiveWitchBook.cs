using UnityEngine;

public class GiveWitchBook : MonoBehaviour
{
Animator animator;    
public Animator CauldronAnimator;
public BollThingy InHandCheck;
public BollThingy BookCheck;

public GameObject BookInHand;
public GameObject WitchBook;

//---------
public DepositObjInHand ObjDepo;
public WinCounter CorrectObj;
public GameObject Player;
//---------
public GameObject GuideText1;
public GameObject GuideText2;
public GameObject IngredientList;
//---------

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

                GuideText1.SetActive(false);
                GuideText2.SetActive(true);
                IngredientList.SetActive(true);

            }
        }

        
    }
}
