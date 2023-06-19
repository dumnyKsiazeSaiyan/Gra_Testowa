using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCube : MonoBehaviour
{
    [SerializeField] private GameObject myTarget;
    public void DestroyTarget()
    {
        myTarget.SetActive(false);
        Debug.Log("Dezaktywacja");
    }
}
