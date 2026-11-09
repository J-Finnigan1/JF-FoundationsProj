using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerEndScreen : MonoBehaviour
{
    public bool AnimComplete = false;
    public DepositObjInHand ObjDepo;
    public SecretEnding AnimEnd;
    public WinCounter CorObj;
    public GameObject Bottle;
    public Bin SoftLock;


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

        if (AnimEnd == true)
        {
            if (Bottle.activeInHierarchy == true)
            {
                Debug.Log("Secret Ending");
                SceneManager.LoadScene("04_SecretEndingScreen", LoadSceneMode.Single);
                AnimComplete = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        if (SoftLock.Softlock == 6)
        {
            Debug.Log("Softlock");
            SceneManager.LoadScene("05_SoftlockScreen", LoadSceneMode.Single);
            Cursor.lockState = CursorLockMode.None;
        }





    }
}
