using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    [SerializeField]private Transform target;
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z - 10f);
    }
}
