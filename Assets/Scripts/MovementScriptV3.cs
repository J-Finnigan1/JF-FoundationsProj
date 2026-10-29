using UnityEngine;

public class MovementScriptV3 : MonoBehaviour
{
    public float rotationspeed = 10f;
    Vector3 _movement;
    Rigidbody _rb;
    public float movementSpeed = 5f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        _movement = (forward * Input.GetAxis("Vertical") + right * Input.GetAxis("Horizontal"));

    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * movementSpeed * Time.fixedDeltaTime);
    }
}
