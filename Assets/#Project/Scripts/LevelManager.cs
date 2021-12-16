using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    

    // public bool spawn_Left;
    // public bool spawn_right;

    // public GameObject leftGameObject;
    // public GameObject rightGameObject;

    public GameObject l_Stuff;
    public GameObject r_Stuff;

    public Pool l_Pool;
    public Pool r_Pool;


    public Transform l_Transform;
    public Transform r_Transform;

    //public VariantSpawnTimeStamps variantScriptTimeStamp;
    public AudioSyncVariantSpawn_Left audioSyncVariantSpawn_Left;
    public AudioSyncVariantSpawn_Right audioSyncVariantSpawn_Right;



    private ClientBehaviour clientVariant;
    private ClientBehaviour client;
    private List<ClientBehaviour> clientVariantList;





    // Start is called before the first frame update
    void Start()
    {
        // leftGameObject = GameObject.Find("/Left");
        // rightGameObject = GameObject.Find("/Right");

        l_Stuff = GameObject.Find("/Left/L_Stuff");
        r_Stuff = GameObject.Find("/Right/R_Stuff");

        l_Pool = l_Stuff.GetComponent<Pool>();
        r_Pool = r_Stuff.GetComponent<Pool>();



        l_Transform = l_Stuff.transform;
        r_Transform = r_Stuff.transform;

        //variantScriptTimeStamp = FindObjectOfType<VariantSpawnTimeStamps>() as VariantSpawnTimeStamps;

        audioSyncVariantSpawn_Left = FindObjectOfType<AudioSyncVariantSpawn_Left>() as AudioSyncVariantSpawn_Left;

        audioSyncVariantSpawn_Right = FindObjectOfType<AudioSyncVariantSpawn_Right>() as AudioSyncVariantSpawn_Right;

    }

    void Update()
    {
        if (audioSyncVariantSpawn_Left.left_isOnBeat)
        //if (spawn_Left)
        {
            l_Pool.clientVariantGo.transform.parent = l_Transform;

            clientVariant = l_Pool.clientVariant;
            clientVariantList = l_Pool.clientVariantList;

            ShowVariant();




            l_Pool.clientGo.transform.parent = l_Transform;
            client = l_Pool.client;

            KeepDistance_Left();



        }
        audioSyncVariantSpawn_Left.SetFalse();

        if (audioSyncVariantSpawn_Right.right_isOnBeat)
        //if (spawn_right)
        {
            r_Pool.clientVariantGo.transform.parent = r_Transform;

            clientVariant = r_Pool.clientVariant;
            clientVariantList = r_Pool.clientVariantList;

            ShowVariant();



            r_Pool.clientGo.transform.parent = r_Transform;
            client = r_Pool.client;

            KeepDistance_Right();



        }
        audioSyncVariantSpawn_Right.SetFalse();



    }


    public void ShowVariant()
    {
        //if (variantScriptTimeStamp.timeCheck())
        //show Variant if time is true 
        //{
        if (clientVariantList.Count > 0)
        {
            clientVariantList.RemoveAt(0);

        }

        clientVariant.gameObject.SetActive(true);

        //}
    }

    public void KeepDistance_Left()
    {

        if (audioSyncVariantSpawn_Left.keepDistanceTimer_left > 0)
        {
            client.gameObject.SetActive(false);
        }
        else
        {
            client.gameObject.SetActive(true);
        }
    }

    public void KeepDistance_Right()
    {

        if (audioSyncVariantSpawn_Right.keepDistanceTimer_right > 0)
        {
            client.gameObject.SetActive(false);
        }
        else
        {
            client.gameObject.SetActive(true);
        }
    }









}
