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


    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(2f, 2f, 2f));
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
