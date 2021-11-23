using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariantSpawnTimeline : MonoBehaviour
{
    public Conductor conductor;

    public Spawner clientVariantSpawner;

    public float spawnBetween = 20f;

    public float andBetween = 21f;

    //public bool myBool;




    // Start is called before the first frame update
    private void Start()
    {

    }

    public bool timeCheck()
    {
        if (conductor.songPositionInBeats >= spawnBetween && conductor.songPositionInBeats <= andBetween)
        {

            //myBool = true;

            return true;


        }
        else
        {
            //myBool = false;
            return false;
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        timeCheck();


    }

}
