using UnityEngine;



public class BodyRotation : MonoBehaviour
{
  void Start ()
{
    

}

    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
         //Unity Documentation - https://docs.unity3d.com/ScriptReference/CursorLockMode.Locked.html
        Cursor.lockState = CursorLockMode.Locked;

        if (Input.GetAxis("Mouse X")<0)
        {
             transform.Rotate((-1)*transform.up*rotationSpeed*Time.deltaTime);
        }

        if (Input.GetAxis("Mouse X")>0)
        {
            transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);
        }
    //lock rotation along Z axis while still allowing rotation on the Y
    

    }
}
