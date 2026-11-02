using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    Animator myanimator;
    //this script is to click to trigger an animation on the object that this script is attached to. 
    void Start()
    {
        myanimator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        myanimator.SetBool("IsClicked", true);
    } 
}
