using UnityEngine;

public class CrateBounceBehavior : MonoBehaviour
{
    public GameObject completObject; // It is whole prefab

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(completObject);
        }
    }

    private void OnDestroy()
    {
        
    }
}
