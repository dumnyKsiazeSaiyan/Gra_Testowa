using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Fields for door's Y position
    private float closePos;
    [SerializeField] private float openPos = 9;

    void Start()
    {
        // The default position of the prefavs is clos door 
        // Then we need to save the door closing Y value
        closePos = transform.position.y;

        DoorEvent.current.onDoorwayTriggerEnter += OpenDoor; 
        DoorEvent.current.onDoorwayTriggerExit += CloseDoor;
    }

    private void OpenDoor(int id)  
    {
        if (gameObject.GetInstanceID() == id)
        { //LeanTween
            transform.position = new(
                                    transform.position.x,
                                    openPos,
                                    transform.position.z);
        }
    }

    private void CloseDoor(int id)
    {
        if (gameObject.GetInstanceID() == id)
        {
            transform.position = new(
                                transform.position.x,
                                closePos,
                                transform.position.z);
        }
    }

    private void OnDestroy()
    {
        DoorEvent.current.onDoorwayTriggerEnter -= OpenDoor;
        DoorEvent.current.onDoorwayTriggerExit -= CloseDoor;
    }
}
