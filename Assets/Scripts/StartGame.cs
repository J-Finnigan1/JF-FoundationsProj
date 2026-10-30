using UnityEngine;

public class StartGame : MonoBehaviour
{
public GameObject Player;
public GameObject Crosshair;
public GameObject StartMenu;
public GameObject StartCam;


    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnClick()
    {

       Player.SetActive(true); 
       Crosshair.SetActive(true); 
       StartMenu.SetActive(false); 
       StartCam.SetActive(false);
    }
}
