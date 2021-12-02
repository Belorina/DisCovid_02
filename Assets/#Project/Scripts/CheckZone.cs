using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// near secu && not masked  - if space then plus punt (score) / if no space minus point (score)
// near secu && masked - if space then then minus point (score) / if no space plus punt (score)

public class CheckZone : MonoBehaviour
{
    public bool nearSecurity;

    public bool check;


    public int score;

    public KeyCode keyCodes;

    public bool keyPressed;

    public bool spacePressed;

    //public bool changeDest;

    public ClientBehaviour clientVariant;

    public List<TargetPoints> targetPoints;

    public Spawner spawner;






    // Start is called before the first frame update
    void Start()
    {
        spawner = GetComponentInParent(typeof(Spawner)) as Spawner;

        targetPoints = spawner.targetPoints;
        

    }

    // Update is called once per frame
    void Update()
    {

        spacePressed = Input.GetKeyUp(KeyCode.Space);

        if (Input.GetKeyDown(keyCodes))
        {
            keyPressed = true;
        }
        if (Input.GetKeyUp(keyCodes))
        {
            keyPressed = false;
        }




        if (nearSecurity && check && spacePressed && keyPressed)
        {
            // not masked client near security, space and arrow pressed 

            score++;

            // positive visual and sound? 

            // tell Vclient to change targetpoint to TP2 streets 
    
            clientVariant.targetPoints = targetPoints;
            clientVariant.actualDestination = targetPoints[2].GivePoint();
            clientVariant.agent.SetDestination(clientVariant.actualDestination);

            print("Not masked caught! ");
        }


        if (nearSecurity && !check && spacePressed && keyPressed)
        {
            // masked client near security, space and arrow pressed

            score--;

            // shake secu ? as negative reponse? 

            print("Oops he is masked");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        nearSecurity = true;

        check = !other.gameObject.CompareTag("Masked");

        if (check)
        {
            clientVariant = other.gameObject.GetComponent<ClientBehaviour>();

        }


    }

    private void OnTriggerExit(Collider other)
    {

        nearSecurity = false;
        //check = false;

    }




    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(2f, 2f, 2f));
    }



}
