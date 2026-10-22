using UnityEngine;

public class ClickAnim : MonoBehaviour
{
    Animator animator;
    //this script is to click to trigger an animation on the object that this script is attached to. 
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.SetBool("IsClicked", true);
    }
}
