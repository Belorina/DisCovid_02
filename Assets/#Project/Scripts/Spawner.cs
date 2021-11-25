using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Spawner : MonoBehaviour
{
    public Pool pool;
    public float delay = 1f;

    //public Vector3 clientDestination;

    


    public ClientBehaviour clientVariant;
    public ClientBehaviour client;


    public VariantSpawnTimeline variantScript;





    // Start is called before the first frame update
    void Start()
    {
        
    


        StartCoroutine(SpawnVariant());     // have to start coroutine in start method otherwhise spawn multiple at once

        StartCoroutine(Spawn());





    }




    private IEnumerator Spawn()
    {
        while (true)
        {
            //print("spawning client create method caled");

            client = pool.Create(transform.position, transform.rotation);
            //client.destination = clientDestination;

            yield return new WaitForSeconds(delay);
        }
    }

    public IEnumerator SpawnVariant()
    {
        while (true)
        {
            clientVariant = pool.VariantCreate(transform.position, transform.rotation);

            //clientVariant.destination = clientDestination;

            yield return new WaitForSeconds(delay);

        }


    }

    void Update()
    {
        // if (variantScript.timeCheck())
        // {

        //     print("it's true!");

        //     clientVariant.gameObject.SetActive(true);
        //     print(clientVariant.gameObject.activeInHierarchy);

        // }
        // else
        // {

        //     clientVariant.gameObject.SetActive(false);
        // }



    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(1f, 1f, 1f));
    }


}
