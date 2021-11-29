using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    public NavMeshAgent agent;

    [SerializeField]
    private Pool pool;


    //public List<TargetPoints> targetPoints = new List<TargetPoints>();


    [SerializeField]
    private int indexNextDestination = 0;

    
    //private Vector3 actualDestination;

    public float clientSpeed = 2f;

    [SerializeField]
    public Test test;





    // Start is called before the first frame update
    public void Start()
    {
        test = GetComponent<Test>();
        


        //targetPoints = new List<TargetPoints>();


        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        clientSpeed = agent.speed;


        //if (CompareTag(""))
        
        //test = FindObjectOfType<Test>();
        //pool = FindObjectOfType<Pool>();

        //actualDestination = test.actualDestination;



    }



    // Update is called once per frame
    void Update()
    {
        print("update index; " + indexNextDestination);


        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            print("I am getting close!");
            print("I had to change now " + test.actualDestination);
            test.NextDestination();
            //agent.SetDestination(actualDestination);

        }

    }
}
