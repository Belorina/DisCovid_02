using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Pool pool;

    private void OnTriggerEnter(Collider other)
    {
        ClientBehaviour client = other.GetComponent<ClientBehaviour>();

        if (client != null)
        {
            pool.Kill(client);
            pool.KillVariant(client);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
