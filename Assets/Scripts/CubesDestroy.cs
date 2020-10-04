using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Cube")
        {
            Destroy(other.contacts[0].otherCollider.transform.gameObject);
        }
    }
}
