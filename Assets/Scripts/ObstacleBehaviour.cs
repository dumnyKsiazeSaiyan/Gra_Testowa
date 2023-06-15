using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField] private float shotPower = 40000;
    public GameObject completObject;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            //rb.AddExplosionForce(shotPower, collision.gameObject.transform.up, 5);
            rb.velocity = Vector3.zero;
            rb.AddForce(Time.fixedDeltaTime * shotPower * collision.gameObject.transform.up);
            Destroy(completObject);
        }
    }
}
