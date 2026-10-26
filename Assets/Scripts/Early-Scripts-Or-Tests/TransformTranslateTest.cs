using System.Numerics;
using UnityEngine;

public class TransformTranslateTest : MonoBehaviour
{
    void Update()
    {
    transform.Translate(0, 0, Time.deltaTime);

    transform.Translate (0, Time.deltaTime, 0, Space.World);
    }
}
