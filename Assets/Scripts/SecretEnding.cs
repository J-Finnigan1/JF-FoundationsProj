using UnityEngine;
using UnityEngine.SceneManagement;


public class SecretEnding : MonoBehaviour
{
    public Animator Hand;
    public GameObject Bottle;
    public bool AnimEnd = false;
    void Start()
    {
        Hand=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Bottle.activeInHierarchy == true)
        {
            Hand.SetTrigger("SecretEnding");
        }
        
        if (AnimEnd == true)
        {
            AnimEnd = false;
            if (Bottle.activeInHierarchy == true)
            {
                Debug.Log("Secret Ending");
                SceneManager.LoadScene("04_SecretEndingScreen", LoadSceneMode.Single);
                AnimEnd = false;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
