using System.Threading;
using UnityEngine;

public class WinCounter : MonoBehaviour
{

    public DepositObjInHand ObjDepo;

    public int CorrectObj = 0;
    //-----------------
    public GameObject Depo0;
    public GameObject Depo1;
    public GameObject Depo2;
    public GameObject Depo3;
    public GameObject Depo4;
    //-----------------

    void OnMouseDown()
    {
        if (ObjDepo.ObjDeposited == 0)
        {
            if (Depo0.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }
        }
        
        if (ObjDepo.ObjDeposited == 1)
        {
            if (Depo1.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1; 
            }        
        }

        if (ObjDepo.ObjDeposited == 2)
        {
            if (Depo2.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }        
        }

        if (ObjDepo.ObjDeposited == 3)
        {
            if (Depo3.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }        
        }

        if (ObjDepo.ObjDeposited == 4)
        {
            if (Depo4.activeInHierarchy == true)
            {
                CorrectObj = CorrectObj + 1;
            }  

           /* if (ObjDepo = CorrectObj)
            {
                

            }*/

        } 

        Debug.Log("ObjDepo " + ObjDepo.ObjDeposited);
        Debug.Log("correctObj " + CorrectObj);

        
    }
}
