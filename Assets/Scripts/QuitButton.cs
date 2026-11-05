using UnityEngine;

public class QuitButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnClick()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
