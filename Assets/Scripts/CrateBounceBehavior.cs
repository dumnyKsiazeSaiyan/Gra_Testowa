using UnityEngine;

public class CrateBounceBehavior : MonoBehaviour
{
    public GameObject completObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(completObject);
        }
    }
}
