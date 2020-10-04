using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    [SerializeField]private Material stackMaterial; 
    private Rigidbody rigidbody;
    private float X = 0;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        X = 0;
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Moved)
            {
                X = Input.GetAxisRaw("Mouse X");
            }
        }
        rigidbody.velocity = new Vector3(X * 10f, 0f, 5f);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Cube")
        {
            SetParent(other.gameObject);
            other.gameObject.GetComponent<MeshRenderer>().material = stackMaterial; 
        }
    }

    public void SetParent(GameObject cube)
    {
        cube.transform.parent = transform;
    }
}
