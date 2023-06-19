using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent myDestroy;

    
    private void OnDestroy()
    {
        myDestroy.Invoke(); // wywo³uje trigger kiedy siê niszczy 
        Debug.Log("W momencie zniszczenia wywo³uje event");
    }
}
