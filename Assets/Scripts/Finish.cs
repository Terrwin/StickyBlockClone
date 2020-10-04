using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]private GameObject ballPrefab;
    private Vector3 spawn;
    private Quaternion rotation;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Cube")
        {
            spawn = other.contacts[0].otherCollider.transform.gameObject.transform.position;
            rotation = other.contacts[0].otherCollider.transform.gameObject.transform.rotation;
            Destroy(other.contacts[0].otherCollider.transform.gameObject);
            GameObject ball = Instantiate(ballPrefab, spawn, rotation) as GameObject;
            ball.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100f);
        }
    }
}
