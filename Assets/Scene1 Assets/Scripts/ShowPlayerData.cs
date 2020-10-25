using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPlayerData : MonoBehaviour
{
    public GameObject playerData;
    public GameObject PlayerDataPrompt;
    public GameObject player;

    private void Update()
    {
        if(player.GetComponent<PlayerManager>().isInsidePlayerDataTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerDataPrompt.SetActive(false);
                playerData.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            player.GetComponent<PlayerManager>().isInsidePlayerDataTrigger = true;
            PlayerDataPrompt.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            player.GetComponent<PlayerManager>().isInsidePlayerDataTrigger = false;
            PlayerDataPrompt.SetActive(false);
            playerData.SetActive(false);
        }
    }
}
