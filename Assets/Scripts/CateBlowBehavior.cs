using UnityEngine;

public class CateBlowBehavior : MonoBehaviour
{
    private float shotPower = 20000;
    public GameObject completObject;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.AddForce(Time.fixedDeltaTime * shotPower * collision.gameObject.transform.up);
            Destroy(completObject);
        }
    }
}
