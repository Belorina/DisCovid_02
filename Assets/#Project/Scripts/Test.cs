using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private int indexNextDestination = -1;

    public Vector3 actualDestination;

    public List<TargetPoints> targetPoints = new List<TargetPoints>();




    // Start is called before the first frame update
    void Start()
    {

        NextDestination();

    }

    // Update is called once per frame
    void Update()
    {

    }




    private void NextDestination()
    {
        int oldIndex = indexNextDestination;
        while (oldIndex == indexNextDestination && targetPoints.Count > 1)
        {
            indexNextDestination++;
            print("++" + indexNextDestination);

            indexNextDestination = indexNextDestination % targetPoints.Count;

            print("after modula index; " + indexNextDestination);

            //indexNextDestination = Random.Range(0, targetPoints.Count);

        }

        actualDestination = targetPoints[indexNextDestination].GivePoint();
        print("the actualDestination is ; " + actualDestination);
        
        //agent.SetDestination(actualDestination);
    }

}
