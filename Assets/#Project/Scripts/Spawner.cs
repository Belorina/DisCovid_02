using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Pool pool;
    public float delay = 1f;
    public Vector3 clientDestination;



    public Conductor conductor;
    public float spawnAt = 20f;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());


        StartCoroutine(SpawnVariant());

    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            print("spawning client create method caled");

            ClientBehaviour client = pool.Create(transform.position, transform.rotation);
            client.destination = clientDestination;

            yield return new WaitForSeconds(delay);
        }
    }

    public IEnumerator SpawnVariant()
    {
        while (true)
        {

            print("VARIANT SPAWNED  ");

            ClientBehaviour clientVariant = pool.VariantCreate(transform.position, transform.rotation);
            clientVariant.destination = clientDestination;


            yield return new WaitUntil(VariantLetsGoNow);   // pause until true 
        }

    }

    bool VariantLetsGoNow()
    {
        if (conductor.songPositionInBeats == spawnAt)
        {
            print("song position in beats its egual to spawnAt");
            return true;
        }
        else
        {
            return false;
        }

    }


}
