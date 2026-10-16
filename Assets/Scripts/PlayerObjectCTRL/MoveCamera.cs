using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    void Update()
    {}
        public Transform cameraPosition;

        private void update()
        {
        Trnsform.position = cameraPosition.position;
        }
}

