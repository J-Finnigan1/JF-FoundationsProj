using UnityEngine;
// This script is for a debug log statement

public class HelloWorldDebug : MonoBehaviour
{

    void OnEnable()
    {
        Debug.Log("Hello World!");

    }

    void OnDisable()
    {
        Debug.Log("Goodbye Cruel World!");

    }

}