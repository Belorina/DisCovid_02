using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    public NavMeshAgent agent;

    //public Test test;

    public Spawner spawner;
    public Test test;




    [SerializeField]
    private int indexNextDestination = -1;

    [SerializeField]
    private Vector3 actualDestination;


    public List<TargetPoints> targetPoints = new List<TargetPoints>();

    private float clientSpeed = 2f;








    // Start is called before the first frame update
    public void Start()
    {

        spawner = gameObject.GetComponentInParent(typeof(Spawner)) as Spawner;
        test = gameObject.GetComponentInParent(typeof(Test)) as Test;


        agent = GetComponent<NavMeshAgent>();
        agent = spawner.client.agent;       // to determine if Left or right (?) 


        agent.autoBraking = false;
        clientSpeed = agent.speed;

        NextDestination();



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
        print("I am in next destination!");


        int oldIndex = indexNextDestination;
        while (oldIndex == indexNextDestination && targetPoints.Count > 1)
        {
            indexNextDestination++;

          //  indexNextDestination = indexNextDestination % targetPoints.Count;
            
        }

        actualDestination = targetPoints[indexNextDestination].GivePoint();

        print("the actualDestination is ; " + actualDestination);

        agent.SetDestination(actualDestination);


    }





}
