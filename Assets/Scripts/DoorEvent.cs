using System;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    public static DoorEvent current;

    public event Action<int> onDoorwayTriggerEnter;
    public event Action<int> onDoorwayTriggerExit;

    private void Awake()
    {
        current = this;
    }

    public void DoorwayTriggerEnter(int id)
    {
        if (onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter(id); 
        }
    }

    public void DoorwayTriggerExit(int id)
    {
        if (onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit(id);
        }
    }
}
