using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Pool pool;
    public float delay = 1f;
    public Vector3 clientDestination;

    public ClientBehaviour clientVariant;


    //public bool VariantLetsGoNow;





    // Start is called before the first frame update
    void Start()
    {
        clientVariant = pool.VariantCreate(transform.position, transform.rotation);
        clientVariant.gameObject.SetActive(false);
        





        StartCoroutine(Spawn());
        StartCoroutine(SpawnVariant());





    }



    void Update()
    {


    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            //print("spawning client create method caled");

            ClientBehaviour client = pool.Create(transform.position, transform.rotation);
            client.destination = clientDestination;

            yield return new WaitForSeconds(delay);
        }
    }

    public IEnumerator SpawnVariant()
    {
        while (true)
        {

            print("Variant Spawn");
            clientVariant.destination = clientDestination;





            yield return new WaitForSeconds(delay);

        }


    }


    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 0, 1, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(1f, 1f, 1f));
    }


}
