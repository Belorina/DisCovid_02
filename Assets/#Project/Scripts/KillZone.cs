using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KillZone : MonoBehaviour
{
    public Pool pool;

    public ClientBehaviour client;

    public ClientBehaviour clientVariant;


    void Start()
    {
    }


    public void OnTriggerEnter(Collider other)
    {
        client = other.GetComponent<ClientBehaviour>();
        clientVariant = other.GetComponent<ClientBehaviour>();


        if (client != null && client.CompareTag("Masked"))
        {
            pool.Kill(client);
        }

        if (clientVariant != null && clientVariant.CompareTag("Not_Masked"))
        {
            pool.KillVariant(clientVariant);

        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(2f, 2f, 2f));
    }


    // Update is called once per frame
    void Update()
    {

    }
}
