using UnityEngine;

public class ClickToAddGravity : MonoBehaviour
{
    void OnMouseDown()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
