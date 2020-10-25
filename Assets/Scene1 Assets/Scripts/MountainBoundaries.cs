using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainBoundaries : MonoBehaviour
{
    public GameObject boat;
    public GameObject boatTarget;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dsadda");
        if (other.gameObject.name == "Player")
        {
            boat.transform.LookAt(boatTarget.transform.position);
            boat.transform.localPosition = new Vector3(2313, -2.5f, -2405);
        }
    }
}
