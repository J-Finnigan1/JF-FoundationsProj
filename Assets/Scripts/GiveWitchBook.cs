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
    public GameObject Crosshair;
    public GameObject CutsceneCam;



//---------

    void Start()
    {
        animator = GetComponent<Animator>();
        CauldronAnimator=GetComponent<Animator>();
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

        if (ObjDepo.ObjDeposited == 5)
        {
            if (ObjDepo.ObjDeposited == 5 && CorrectObj.CorrectObj == 5)
            {
                Player.SetActive(false); 
                Crosshair.SetActive(false); 
                CutsceneCam.SetActive(true);
                animator.SetTrigger("BadEnd");
            }
            else 
            {
                Player.SetActive(false); 
                Crosshair.SetActive(false); 
                CutsceneCam.SetActive(true);
                animator.SetTrigger("GoodEnd");
            }
        }
    }
}
