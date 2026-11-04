using UnityEngine;

public class PauseMenu : MonoBehaviour
{
public FirstPersonCamera CamCtrl;
public GameObject Crosshair;
public GameObject PauseUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                Debug.Log("Game Paused");
    
                CamCtrl.enabled = false;
                Crosshair.SetActive(false);
                PauseUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None; 
            }

            else
            {
                Time.timeScale = 1;
                Debug.Log("Game Unpaused");
    
                CamCtrl.enabled = true;
                Crosshair.SetActive(true);
                PauseUI.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked; 

            }



        }        

    }
    



}
