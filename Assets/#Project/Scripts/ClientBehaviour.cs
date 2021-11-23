using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



[RequireComponent(typeof(NavMeshAgent))]

public class ClientBehaviour : MonoBehaviour
{

    [SerializeField]
    private NavMeshAgent agent; 

    public Vector3 destination;

    public Pool pool;


    // Start is called before the first frame update
    public void Start()
    {
        pool = FindObjectOfType<Pool>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
}
