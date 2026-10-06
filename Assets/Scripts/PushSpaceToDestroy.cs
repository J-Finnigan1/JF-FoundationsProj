using UnityEngine;
// this script is to destroy a game object using the spacebar

public class PushSpaceToDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
