using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    public NavMeshAgent agent;

    public int indexNextDestination = -1;

    public float clientSpeed;

    public Vector3 actualDestination;

    [SerializeField]
    public List<TargetPoints> targetPoints = new List<TargetPoints>(0);

    //public ClientBehaviour clientVariant;


    // Start is called before the first frame update
    public void Start()
    {

        //spawner = gameObject.GetComponentInParent(typeof(Spawner)) as Spawner;
        //checkZone = transform.parent.GetComponentInChildren(typeof(CheckZone)) as CheckZone;


        //agent = spawner.client.agent;       // to determine if Left or right


        agent = GetComponent<NavMeshAgent>();


        agent.autoBraking = true;       // if false then doesnt detect stopping distance ?? 
        clientSpeed = 3f;
        agent.speed = clientSpeed;


    }



    // Update is called once per frame
    void Update()
    {

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            NextDestination();
        }
    }


    public void NextDestination()
    {
        int oldIndex = indexNextDestination;

        while (oldIndex == indexNextDestination && targetPoints.Count > 1)
        {
            indexNextDestination++;

            if (indexNextDestination == 2)
            {
                indexNextDestination = 0;
            }

            indexNextDestination = indexNextDestination % targetPoints.Count;

        }

        actualDestination = targetPoints[indexNextDestination].GivePoint();

        agent.SetDestination(actualDestination);
    }
}
