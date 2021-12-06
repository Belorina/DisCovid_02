using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


// how to determine left or right spawn for variant 


public class Spawner : MonoBehaviour
{
    public Pool pool;
    public float delay = 1f;

    public ClientBehaviour clientVariant;
    public ClientBehaviour client;

    public List<TargetPoints> targetPoints;







    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnVariant());     // have to start coroutine in start method otherwhise spawn multiple at once

        StartCoroutine(Spawn());


    }




    public IEnumerator Spawn()
    {
        while (true)
        {
            client = pool.Create(transform.position, transform.rotation);
            
            client.targetPoints = targetPoints;
            yield return new WaitForSeconds(delay);
        }
    }

    public IEnumerator SpawnVariant()
    {

        while (true)
        {
            clientVariant = pool.VariantCreate(transform.position, transform.rotation);

            clientVariant.targetPoints = targetPoints;


            yield return new WaitForSeconds(delay);

        }


    }

    void Update()
    {
        

    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(1f, 1f, 1f));
    }


}
