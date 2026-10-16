using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInputsTest : MonoBehaviour
{
public float rotationSpeed;

    void Update()
    {
        if (Input.GetAxis("Mouse X")<0){
            Debug.Log("Mouse Moving Left");
        }

        if (Input.GetAxis("Mouse X")==0){
            Debug.Log("Mouse Not Moving");
        }
        
        if (Input.GetAxis("Mouse X")>0){
            Debug.Log("Mouse Moving Right");
        }
    }
}
