using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    // public bool spawn_Left;
    // public bool spawn_right;

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
    private List<ClientBehaviour> clientVariantList;



    // Start is called before the first frame update
    void Start()
    {

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

    // Update is called once per frame
    void Update()
    {
        if (audioSyncVariantSpawn_Left.left_isOnBeat)
        //if (spawn_Left)
        {
            l_Pool.clientVariantGo.transform.parent = l_Transform;

            clientVariant = l_Pool.clientVariant;
            clientVariantList = l_Pool.clientVariantList;

            ShowVariant();
        }
        //audioSyncVariantSpawn_Left.left_isOnBeat = false;

        if (audioSyncVariantSpawn_Right.right_isOnBeat)
        //if (spawn_right)
        {
            r_Pool.clientVariantGo.transform.parent = r_Transform;

            clientVariant = r_Pool.clientVariant;
            clientVariantList = r_Pool.clientVariantList;

            ShowVariant();
        }

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
}
