using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariantSpawnTimeline : MonoBehaviour
{
    public Conductor conductor;

    public Spawner clientVariantSpawner;

    public float spawnAt = 20f;


// Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (conductor.songPositionInBeats == spawnAt)
        {
            //StartCoroutine(clientVariantSpawner.SpawnVariant());

            //clientVariantSpawner.SpawnVariant();
            print("gotta spawn Variant now!");
        }
    }
}
