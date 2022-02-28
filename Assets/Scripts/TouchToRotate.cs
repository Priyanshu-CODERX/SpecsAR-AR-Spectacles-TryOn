using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToRotate : MonoBehaviour
{
    public float rotateSpeed = 100f;

    void OnMouseDrag() {
        float x = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, -x);
    }

}
