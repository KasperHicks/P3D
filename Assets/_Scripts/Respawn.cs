using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] Transform respawnPoint;
    [SerializeField] float respawnValue;

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.y < respawnValue)
        {
            Respawny();
        }
    }

    void Respawny()
    {
        transform.position = respawnPoint.position;
    }
}
