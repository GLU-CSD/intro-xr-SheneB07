using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Vind de NavMeshAgent component
        agent = GetComponent<NavMeshAgent>();

        // Zoek de XR Rig met de tag "Player"
        GameObject player = GameObject.FindGameObjectWithTag("Base");
        if (player != null)
        {
            playerTransform = player.transform;
        }
 }




// Update is called once per frame
void Update()
    {
        // Beweeg naar de positie van de speler als deze is gevonden
        if (playerTransform != null)
        {
            agent.SetDestination(playerTransform.position);
        }

    }
}
