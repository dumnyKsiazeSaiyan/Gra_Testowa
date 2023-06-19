using UnityEngine;

public class TriggerAera : MonoBehaviour
{
    // Need the door ID from my prefab
    [SerializeField] private DoorController doorController;

    private void OnTriggerEnter(Collider other) 
    {
        // If it detects player entering the trigger area, then start event with the door ID
        if (other.gameObject.tag == "Player")
            DoorEvent.current.DoorwayTriggerEnter(doorController.gameObject.GetInstanceID());//1
    }

    private void OnTriggerExit(Collider other) 
    {
        // If it detects player leaving the trigger area, then start event with the door ID
        if (other.gameObject.tag == "Player")
            DoorEvent.current.DoorwayTriggerExit(doorController.gameObject.GetInstanceID());
    }
}
