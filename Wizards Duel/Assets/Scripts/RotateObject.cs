using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float RotateSpeed;
    public void FixedUpdate()
    {
        float angle = transform.eulerAngles.z;
        transform.Rotate(0, 0, RotateSpeed * 1f * Time.deltaTime);
    }
}
