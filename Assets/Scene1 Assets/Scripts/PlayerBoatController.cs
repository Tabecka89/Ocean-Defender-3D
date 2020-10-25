using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerBoatController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float turboSpeed = 40f;
    public float turningSpeed = 60f;
    public bool isBoatInTurboMode = false;
    public GameObject player;
    public GameObject mainCamera;
    public GameObject boatCamera;
  
    private void Update()
    {
        if (player.GetComponent<PlayerManager>().boatInControl)
        {
            // boat steering
            float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * turningSpeed;
            transform.Rotate(0, horizontal, 0);
            if (Input.GetKey(KeyCode.LeftShift) && !isBoatInTurboMode)
            {
                isBoatInTurboMode = true;
                movementSpeed = turboSpeed;
            }
            else
            {
                isBoatInTurboMode = false;
                movementSpeed = 10;
            }
            float vertical = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
            transform.Translate(0, 0, vertical);

            // return control to player
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.GetComponent<FirstPersonController>().isInControl = true;
                mainCamera.SetActive(true);
                boatCamera.SetActive(false);
                player.GetComponent<PlayerManager>().boatInControl = false;
            }
        }
    }
}
