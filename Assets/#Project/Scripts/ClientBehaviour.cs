using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    [SerializeField]
    private NavMeshAgent agent;

    private Pool pool;


    public List<TargetPoints> targetPoints = new List<TargetPoints>();


    [SerializeField]
    private int indexNextDestination;

    [SerializeField]
    private Vector3 actualDestination;

    public float clientSpeed = 2f;




    // Start is called before the first frame update
    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        agent.speed = clientSpeed;

        indexNextDestination = -1;


        pool = FindObjectOfType<Pool>();



    }



    // Update is called once per frame
    void Update()
    {
        print("update" + indexNextDestination);


        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            NextDestination();
        }
    }

    private void NextDestination()
    {
        indexNextDestination++;

        print("++" + indexNextDestination);

        indexNextDestination = indexNextDestination % targetPoints.Count;

        print(indexNextDestination);

        actualDestination = targetPoints[indexNextDestination].GivePoint();

        agent.SetDestination(actualDestination);
        
    }
}
