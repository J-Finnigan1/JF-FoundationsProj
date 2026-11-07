using UnityEngine;

public class StartGame : MonoBehaviour
{
public GameObject Player;
public GameObject Crosshair;
public GameObject StartMenu;
public GameObject StartCam;

public GameObject GuideBox;
public GameObject GuideText1;

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
        GuideBox.SetActive(true);
        GuideText1.SetActive(true);
    }
}
