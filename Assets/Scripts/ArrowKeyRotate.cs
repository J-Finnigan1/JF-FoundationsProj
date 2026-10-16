using UnityEngine;

public class ArrowKeyRotate : MonoBehaviour
{
    public float movementSpeed;  
    public float rotationSpeed;
    void Update()
    {
        //Rotate Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
           transform.Rotate(transform.up*rotationSpeed*Time.deltaTime);
        }
        
        //Rotate Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Rotate((-1)*transform.up*rotationSpeed*Time.deltaTime);
        }

    }
}
