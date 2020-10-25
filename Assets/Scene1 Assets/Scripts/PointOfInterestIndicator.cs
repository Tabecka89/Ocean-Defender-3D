using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterestIndicator : MonoBehaviour
{

    public GameObject upperTarget;
    public GameObject lowerTarget;
    GameObject target;
    public float step;
    float distanceToUpperTarget;
    float distanceToLowerTarget;
    float targetReachedIndicator = 2;
     void Start()
    { 
        target = upperTarget;
    }
    void Update()
    {
        distanceToUpperTarget = Vector3.Distance(transform.position, upperTarget.transform.position);
        distanceToLowerTarget = Vector3.Distance(transform.position, lowerTarget.transform.position);
        if (distanceToUpperTarget < targetReachedIndicator)
        {
            target = lowerTarget;
        }
        if(distanceToLowerTarget < targetReachedIndicator)
        {
            target = upperTarget;
        }
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * step);
    }
}
