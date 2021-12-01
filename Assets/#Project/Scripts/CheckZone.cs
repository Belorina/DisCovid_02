using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckZone : MonoBehaviour
{
    private bool nearSecurity;

    private bool check;

    //public int score; 



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (nearSecurity && Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released - on time- .");
        }

        if (nearSecurity && check && Input.GetKeyUp(KeyCode.Space))
        {
            // score + 

            print("Space key detected! HA not masked! ");

            // change targetpoint to TP2 streets 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Masked"))
        {
            nearSecurity = true;
            check = false;
        }
        else
        {
            nearSecurity = false;
            check = true;
        }

        // score ? 
    }

    private void OnTriggerExit (Collider other)
    {
        if (!other.gameObject.CompareTag("Masked"))
        {
            nearSecurity = false;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(4f, 4f, 4f));
    }



}
