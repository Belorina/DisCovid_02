using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// near secu && not masked  - if space then plus punt (score) / if no space minus point (score)
// near secu && masked - if space then then minus point (score) / if no space plus punt (score)

public class CheckZone : MonoBehaviour
{
    public bool nearSecurity;

    public bool check;

    public KeyCode keyCodes;

    public bool keyPressed;

    public bool spacePressed;



    public ClientBehaviour client;
    public ClientBehaviour clientVariant;


    public List<TargetPoints> targetPoints;

    public Spawner spawner;

    public ScoreSystem scoreSystem;



    // Start is called before the first frame update
    void Start()
    {

        spawner = GetComponentInParent(typeof(Spawner)) as Spawner;

        targetPoints = spawner.targetPoints;


        scoreSystem = GameObject.Find("Score_Manager").GetComponent<ScoreSystem>();


    }

    // Update is called once per frame
    void Update()
    {

        spacePressed = Input.GetKeyUp(KeyCode.Space);

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     spacePressed = true;
        // }
        // else
        // {
        //     spacePressed = false;
        // }
        

        if (Input.GetKeyDown(keyCodes))
        {
            keyPressed = true;
        }
        if (Input.GetKeyUp(keyCodes))
        {
            keyPressed = false;
        }



// Not_Masked
        if (nearSecurity && check && spacePressed && keyPressed)
        {
            // not masked client near security, space and arrow pressed 

            scoreSystem.AddScore(1);

            // positive visual and sound? 

            // tell Vclient to change targetpoint to TP2 streets 
            print("before TP " + targetPoints);
            clientVariant.targetPoints = targetPoints;
            print("after TP " + targetPoints);

            clientVariant.actualDestination = targetPoints[2].GivePoint();
            clientVariant.agent.SetDestination(clientVariant.actualDestination);


            print("Not masked caught! ");
        }

// Masked
        if (nearSecurity && !check && spacePressed && keyPressed)
        {
            // masked client near security, space and arrow pressed

            scoreSystem.SubstractScore(1);

            // go away 
            client.targetPoints = targetPoints;
            client.actualDestination = targetPoints[2].GivePoint();
            client.agent.SetDestination(client.actualDestination);

            print("Oops he is masked");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        nearSecurity = true;

        check = !other.gameObject.CompareTag("Masked");

        if (check)
        {
            nearSecurity = true;
            clientVariant = other.gameObject.GetComponent<ClientBehaviour>();
            //check = false;
        }
        else
        {
            client = other.gameObject.GetComponent<ClientBehaviour>();
        }
    }

    private void OnTriggerExit(Collider other)
    {

        nearSecurity = false;
        //check = false;


        if (check && !spacePressed && !keyPressed)
        {
            scoreSystem.SubstractScore(1);

            print("He is going in NOO");
        }

    }




    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(2f, 2f, 2f));
    }



}
