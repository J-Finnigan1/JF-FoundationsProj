using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //Forward
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate (0,0,10);
            Debug.Log("S Key Pressed");
        }
        //Backwards
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate (0,0,-10);
            Debug.Log("W Key Pressed");
        }
        //Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate (10,0,0);
            Debug.Log("D Key Pressed");
        }
        //Left
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate (-10,0,0);
            Debug.Log("A Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate (0,10,0);
            Debug.Log("Space Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.Translate (0,-10,0);
            Debug.Log("Left Control Key Pressed");
        }
    }
}
