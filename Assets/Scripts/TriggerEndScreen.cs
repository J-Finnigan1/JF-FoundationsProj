using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerEndScreen : MonoBehaviour
{
    public bool AnimComplete = false;
     public DepositObjInHand ObjDepo;
     public WinCounter CorObj;

    public void Update()
    {
        if (AnimComplete == true)
        {
            if (ObjDepo.ObjDeposited == 5 && CorObj.CorrectObj == 5)
            {
                Debug.Log("Bad Ending");
                SceneManager.LoadScene("03_BadEndScreen", LoadSceneMode.Single);
                AnimComplete = false;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Debug.Log("Good Ending");
                SceneManager.LoadScene("02_GoodEndScreen", LoadSceneMode.Single);
                AnimComplete = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
