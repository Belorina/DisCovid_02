using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    public NavMeshAgent agent;

    public Spawner spawner;


    [SerializeField]
    private int indexNextDestination = -1;

    [SerializeField]
    private float clientSpeed = 2f;

    private Vector3 actualDestination;

    [SerializeField]
    public List<TargetPoints> targetPoints = new List<TargetPoints>();








    // Start is called before the first frame update
    public void Start()
    {

        spawner = gameObject.GetComponentInParent(typeof(Spawner)) as Spawner;

        //agent = spawner.client.agent;       // to determine if Left or right


        agent = GetComponent<NavMeshAgent>();


        agent.autoBraking = false;
        clientSpeed = agent.speed;

        print("in start " + indexNextDestination);
        NextDestination();



    }



    // Update is called once per frame
    void Update()
    {

        if (spawner.client.agent.remainingDistance <= spawner.client.agent.stoppingDistance)
        {
            print("got close play next Destination");
            NextDestination();

        }

    }


    public void NextDestination()
    {
        int oldIndex = indexNextDestination;
        while (oldIndex == indexNextDestination && spawner.targetPoints.Count > 1)
        {
            print("old index == indexNextDest");
            print(indexNextDestination);

            
            indexNextDestination++;
            print("index should be +1");
            print(indexNextDestination);
            indexNextDestination = indexNextDestination % spawner.targetPoints.Count; 
            
        }

        actualDestination = spawner.targetPoints[indexNextDestination].GivePoint();

        print("the actualDestination is ; " + actualDestination);

        spawner.client.agent.SetDestination(actualDestination);
        spawner.clientVariant.agent.SetDestination(actualDestination);


    }





}
