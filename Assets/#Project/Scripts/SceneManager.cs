using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public bool spawn_Left;
    public bool spawn_right;

    public GameObject l_Stuff;
    public GameObject r_Stuff;

    public Pool l_Pool;
    public Pool r_Pool;

    public Transform l_Transform;
    public Transform r_Transform;

    

    // Start is called before the first frame update
    void Start()
    {

        l_Stuff = GameObject.Find("/Left/L_Stuff");
        r_Stuff = GameObject.Find("/Right/R_Stuff");

        l_Pool = l_Stuff.GetComponent<Pool>();
        r_Pool = r_Stuff.GetComponent<Pool>();

        l_Transform = l_Stuff.transform;
        r_Transform = r_Stuff.transform;



    }

    // Update is called once per frame
    void Update()
    {
        if (spawn_Left)
        {
            l_Pool.clientVariantGo.transform.parent = l_Transform;
        }

        if (spawn_right)
        {
            r_Pool.clientVariantGo.transform.parent = r_Transform;
        }

    }
}
