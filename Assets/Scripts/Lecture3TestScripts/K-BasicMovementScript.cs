using UnityEngine;



public class BasicMovementScript : MonoBehaviour
{ 
public float movementSpeed;  

public float rotationSpeed;
  // Update is called once per frame
    void Update()
    {
        //move forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(transform.forward*movementSpeed*Time.deltaTime,Space.World);
        }

        //Move Backwards
        if (Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate((-1)*transform.forward*movementSpeed*Time.deltaTime,Space.World);
        }

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
