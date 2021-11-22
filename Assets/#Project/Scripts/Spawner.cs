using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    public Pool pool; 
    public float delay = 1f;
    public Vector3 clientDestination;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            ClientBehaviour client = pool.Create(transform.position, transform.rotation);
            client.destination = clientDestination;

            yield return new WaitForSeconds(delay);
        }
    }
}
