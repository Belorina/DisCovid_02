using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoints : MonoBehaviour
{
    public Vector3 position;

    public Vector3 point; 

    public Vector3 GivePoint()
    {
        //qprint("giving point");
        point = Vector3.zero;

        //point = 

        point.z = point.y;
        point.y = 0;

        point += transform.position;
        return point;
    }



    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position;
        //print(point);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 0.5f, 0.9f, 0.4f);
        Gizmos.DrawSphere(transform.position, 1f);
    }
    
}
