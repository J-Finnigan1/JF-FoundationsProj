using UnityEngine;

// Reference - https://www.youtube.com/watch?v=5Rq8A4H6Nzw 


public class FirstPersonCamera : MonoBehaviour
{
    public Transform PlayerObj;
    public float mouseSensitivity = 2f;
    float cameraverticalRotation = 0f;


    // Update is called once per frame
    void Update()
    {
    //Unity Documentation - https://docs.unity3d.com/ScriptReference/CursorLockMode.Locked.html
        Cursor.lockState = CursorLockMode.Locked; 







    }
}
