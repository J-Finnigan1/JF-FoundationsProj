using System.Threading;
using UnityEngine;

public class WinCounter : MonoBehaviour
{
//---------------------------------------------------
    public DepositObjInHand AnimLock;
    public DepositObjInHand ObjDepo;
    public int CorrectObj = 0;
//---------------------------------------------------
    public GameObject Player;
    public GameObject Crosshair;
    public GameObject CutsceneCam;
//---------------------------------------------------
    public GameObject GuideBox;
    public GameObject GuideText2;
    public GameObject GuideText3;
    public GameObject IngredientList;
//---------------------------------------------------

    public GameObject Depo0;
    public GameObject Depo1;
    public GameObject Depo2;
    public GameObject Depo3;
    public GameObject Depo4;
//---------------------------------------------------
    public Animator animator;
    public Animator WitchAnimator;

    void Start()
    {
        animator=GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (ObjDepo.ObjDeposited == 0 && AnimLock.AnimLock == false)
        {
            if (Depo0.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }
        }
        
        if (ObjDepo.ObjDeposited == 1 && AnimLock.AnimLock == false)
        {
            if (Depo1.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1; 
            }        
        }

        if (ObjDepo.ObjDeposited == 2 && AnimLock.AnimLock == false)
        {
            if (Depo2.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }        
        }

        if (ObjDepo.ObjDeposited == 3 && AnimLock.AnimLock == false)
        {
            if (Depo3.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }        
        }

        if (ObjDepo.ObjDeposited == 4 && AnimLock.AnimLock == false)
        {
            if (Depo4.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
                GuideText2.SetActive(false);
                GuideText3.SetActive(true);
                IngredientList.SetActive(false);
            }  
            
            else
            {
                GuideText2.SetActive(false);
                GuideText3.SetActive(true);
                IngredientList.SetActive(false);
            }
        } 

        if (ObjDepo.ObjDeposited == 5 && AnimLock.AnimLock == false)
        {
            if (ObjDepo.ObjDeposited == 5 && CorrectObj == 5)
            {
                Player.SetActive(false); 
                Crosshair.SetActive(false); 
                CutsceneCam.SetActive(true);
                GuideText3.SetActive(false);
                GuideBox.SetActive(false);

                animator.SetBool("BadEnd", true);
                WitchAnimator.SetTrigger("Ending");

            }
            else 
            {
                Player.SetActive(false); 
                Crosshair.SetActive(false); 
                CutsceneCam.SetActive(true);
                GuideText3.SetActive(false);
                GuideBox.SetActive(false);

                animator.SetBool("GoodEnd", true);
                WitchAnimator.SetTrigger("Ending");

            }
        }
    }
}
