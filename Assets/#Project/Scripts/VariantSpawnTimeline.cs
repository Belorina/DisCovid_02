using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariantSpawnTimeline : MonoBehaviour
{
    public Conductor conductor;

    public Spawner clientVariantSpawner;

    public float spawnBetween = 20f;

    public float andBetween = 21f;

    public bool myBool;




    // Start is called before the first frame update
    private void Start()
    {

    }
    public void timeCheck()
    {
        if (conductor.songPositionInBeats >= spawnBetween && conductor.songPositionInBeats <= andBetween)
        {

            myBool = true;

            //           print("it's 20!");
            //StartCoroutine(clientVariantSpawner.SpawnVariant());
            //          print("it's past 21!");

        }
        else
        {
            myBool = false;
            //            print("it's not 20 or past 21 ");

            //StopCoroutine(clientVariantSpawner.SpawnVariant());
        }

    }

    // Update is called once per frame
    void Update()
    {
        timeCheck();

        if (myBool)
        {
            //clientVariantSpawner
            // make setactive true again 

        }
        else
        {
            StopCoroutine(clientVariantSpawner.SpawnVariant());

        }


    }

}
