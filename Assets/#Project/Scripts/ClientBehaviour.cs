using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    public NavMeshAgent agent;

    // public Spawner spawner;

    public CheckZone checkZone; 


    
    public int indexNextDestination = -1;

    [SerializeField]
    private float clientSpeed = 2f;

    private Vector3 actualDestination;

    [SerializeField]
    public List<TargetPoints> targetPoints = new List<TargetPoints>(0);








    // Start is called before the first frame update
    public void Start()
    {

        //spawner = gameObject.GetComponentInParent(typeof(Spawner)) as Spawner;
        checkZone = transform.parent.GetComponentInChildren(typeof(CheckZone)) as CheckZone;

        //agent = spawner.client.agent;       // to determine if Left or right


        agent = GetComponent<NavMeshAgent>();


        agent.autoBraking = true;       // if false then doesnt detect stopping distance ?? 
        clientSpeed = agent.speed;
        clientSpeed = 2f;

        //print("in start " + indexNextDestination);
        //NextDestination();



    }



    // Update is called once per frame
    void Update()
    {

        // if (spawner.client.agent.remainingDistance <= spawner.client.agent.stoppingDistance)
        // {
        //     print("got close play next Destination");
        //     NextDestination();

        // }

        if (checkZone.changeDest)
        {
            indexNextDestination = 2;
        }
        // else
        // {
        //     indexNextDestination = 1;
        // }

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            //print("got close now play nextdest again");
            NextDestination();
        }



    }


    public void NextDestination()
    {
        int oldIndex = indexNextDestination;
        while (oldIndex == indexNextDestination && targetPoints.Count > 1)
        {

            //print("old index == indexNextDest");
            //print(indexNextDestination);

            indexNextDestination++;

            if (indexNextDestination == 3)
            {
                indexNextDestination = 0;
            }
            //print("index should be +1");
            //print(indexNextDestination);
            indexNextDestination = indexNextDestination % targetPoints.Count; 

        }

        actualDestination = targetPoints[indexNextDestination].GivePoint();

        //print("the actualDestination is ; " + actualDestination);

        agent.SetDestination(actualDestination);        //spawner.client.
                                                        // spawner.clientVariant.

    }
}
