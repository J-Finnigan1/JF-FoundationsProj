using UnityEngine;



public class BasicMovementScript : MonoBehaviour
{ 
public float movementSpeed;  

public float rotationSpeed;
  // Update is called once per frame
    void Update()
    {
        //move forward
        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate(transform.forward*movementSpeed*Time.deltaTime,Space.World);
        }

        //Move Backwards
        if (Input.GetKey(KeyCode.S))
        {
           transform.Translate((-1)*transform.forward*movementSpeed*Time.deltaTime,Space.World);
        }
 
         //move Right
        if (Input.GetKey(KeyCode.D))
        {
           transform.Translate(transform.right*movementSpeed*Time.deltaTime,Space.World);
        }

        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
           transform.Translate((-1)*transform.right*movementSpeed*Time.deltaTime,Space.World);
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

      //examples of other movement options
      
      //if (Input.GetKey(KeyCode.UpArrow))
      //{
      //Transform.Translate(Vector3.forward, Space.World); //Moves the GameObj in a fixed direction of the Global Z
      //}


    }
}
