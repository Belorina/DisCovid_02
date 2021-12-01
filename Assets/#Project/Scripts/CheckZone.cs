using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// near secu && not masked  - if space then plus punt (score) / if no space minus point (score)
// near secu && masked - if space then then minus point (score) / if no space plus punt (score)

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
            if (!check)
            {
                // means it's a masked client 

                // score - 

                // deang sound? 

                print("Space key detected on masked client");
            }
        }

        if (nearSecurity && check && Input.GetKeyUp(KeyCode.Space))
        {
            // means it's a not masked client (or hald ynwim) 

            // score + 

            // positive visual and sound? 

            // change targetpoint to TP2 streets 

            print("Space key detected on NOT masked!");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Masked"))
        {
            nearSecurity = true;
            check = true;
        }
        else
        {
            nearSecurity = true ;
            check = false;
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
