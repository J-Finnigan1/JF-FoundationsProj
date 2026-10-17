using UnityEngine;

// Reference - https://www.youtube.com/watch?v=5Rq8A4H6Nzw 


public class FirstPersonCamera : MonoBehaviour
{
    public Transform playerObj;
    public float mouseSensitivity = 2f;
    float cameraverticalRotation = 0f;


    // Update is called once per frame
    void Update()
    {
    //Unity Documentation - https://docs.unity3d.com/ScriptReference/CursorLockMode.Locked.html
        Cursor.lockState = CursorLockMode.Locked; 

        //Mouse Inputs
        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        //rotate around local X

        cameraverticalRotation -= inputY;
        cameraverticalRotation=Mathf.Clamp(cameraverticalRotation, -90f, 90f);
        transform.localEulerAngles=Vector3.right*cameraverticalRotation;


        //rotate around local Y
        playerObj.Rotate(Vector3.up*inputX);



    }
}
