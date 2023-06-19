using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAppear : MonoBehaviour
{
    [SerializeField] private GameObject myCube;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject zmniejszLiczbe;
    public void ActivateCube()
    {
        myCube.SetActive(false);
    }
    public void EventCoZmniejszaLiczbe()
    {
        gameManager.numbOfTargets -= 1;
        Debug.Log("Zmniejsz liczbe o 1");
    }

}
