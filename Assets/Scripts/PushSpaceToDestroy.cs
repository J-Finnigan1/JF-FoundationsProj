using UnityEngine;
// this script is to destroy a game object using the spacebar

public class PushSpaceToDestroy : MonoBehaviour
{

    public GameObject gameObjectToDestroy; //this is a reference to the game object that we want to destroy
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject); //this destroys the object that the script is attatched to
            //Destroy(this); //this destroys the script attathed to the game object
            //Destroy(this.gameObject); 
            Destroy(gameObjectToDestroy); //this destroys the game object that we have referenced in the inspector

        }
    }
}
