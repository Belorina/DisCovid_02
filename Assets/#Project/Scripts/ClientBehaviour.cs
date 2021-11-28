using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField]
    private Pool pool;


    //public List<TargetPoints> targetPoints = new List<TargetPoints>();


    [SerializeField]
    private int indexNextDestination = 0;

    [SerializeField]
    private Vector3 actualDestination;

    public float clientSpeed = 2f;

    [SerializeField]
    public Test test;





    // Start is called before the first frame update
    public void Start()
    {


        //targetPoints = new List<TargetPoints>();


        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        agent.speed = clientSpeed;


        test = FindObjectOfType<Test>();

        //test.testTargetPoints = targetPoints;
        test.actualDestination = actualDestination;



        pool = FindObjectOfType<Pool>();

        //print("start void index; " + indexNextDestination );
        //NextDestination();



    }



    // Update is called once per frame
    void Update()
    {
        print("update index; " + indexNextDestination);


        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            print("go next destination now chage");
            NextDestination();
            agent.SetDestination(actualDestination);

        }

    }

    private void NextDestination()
    {
        // int oldIndex = indexNextDestination;
        // while (oldIndex == indexNextDestination && targetPoints.Count > 1)
        // {
        //     indexNextDestination++;
        //     print("++" + indexNextDestination);

        //     indexNextDestination = indexNextDestination % targetPoints.Count;

        //     print("after modula index; " + indexNextDestination);

        //     //indexNextDestination = Random.Range(0, targetPoints.Count);

        // }


        // actualDestination = targetPoints[indexNextDestination].GivePoint();
        // print("the actualDestination is ; " + actualDestination);

        //agent.SetDestination(actualDestination);

    }
}
