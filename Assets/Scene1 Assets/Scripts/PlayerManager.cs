using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerManager : MonoBehaviour
{
    public GameObject boatCamera;
    public GameObject mainCamera;
    public bool boatInControl;
    public bool isInsidePlayerDataTrigger;
    void Start()
    {
        boatCamera.SetActive(false);
        mainCamera.SetActive(true);
        boatInControl = false;
        isInsidePlayerDataTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        // give control to boat
        if (Input.GetKeyDown(KeyCode.F) && !boatInControl && !isInsidePlayerDataTrigger)
        {
            GetComponent<FirstPersonController>().isInControl = false;
            mainCamera.SetActive(false);
            boatCamera.SetActive(true);
            boatInControl = true;
            
        }
    }
}
