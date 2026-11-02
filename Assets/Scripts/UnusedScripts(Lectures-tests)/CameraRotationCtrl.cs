using UnityEngine;

public class CameraRotationCtrl : MonoBehaviour
{
    public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
                //Rotate Up
        if (Input.GetAxis("Mouse Y")<0)
        {
            transform.Rotate((-1)*transform.right*rotationSpeed*Time.deltaTime);
        }

        if (Input.GetAxis("Mouse Y")>0)
        {
            transform.Rotate(transform.right*rotationSpeed*Time.deltaTime);
        }


    }
}
