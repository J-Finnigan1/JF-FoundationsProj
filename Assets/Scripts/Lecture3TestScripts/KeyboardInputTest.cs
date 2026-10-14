using UnityEngine;

public class KeyboardInputTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            Debug.Log("User Pressed A");
        }

        if (Input.GetKey(KeyCode.A)){
            Debug.Log("User is holding A");
        }

        if (Input.GetKeyUp(KeyCode.A)){
            Debug.Log("User released A");
        }
    }
}
