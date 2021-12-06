using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IN KILL VARIANT - condision to get all variants poped and not back in list 


// how to make 2 instances of variant to put in two pools ?? not only right 



public class Pool : MonoBehaviour
{
    public List<ClientBehaviour> clientList = new List<ClientBehaviour>();

    public List<ClientBehaviour> clientVariantList = new List<ClientBehaviour>();

    public GameObject clientPrefab;
    public GameObject clientVariantPrefab;

    public VariantSpawnTimeStamps variantScriptTimeStamp;

    public ClientBehaviour clientVariant;

    public GameObject clientVariantGo;


    private ClientBehaviour client;



    public ClientBehaviour Create(Vector3 position, Quaternion rotation)
    {
        client = null;

        if (clientList.Count > 0)
        {
            client = clientList[0];
            clientList.RemoveAt(0);
            client.transform.position = position;
            client.transform.rotation = rotation;
            client.gameObject.SetActive(true);

        }
        else
        {
            GameObject clientGo = Instantiate(clientPrefab, position, rotation);
            clientGo.transform.parent = transform;      // to make it a child 

            client = clientGo.GetComponent<ClientBehaviour>();
        }
        return client;
    }

    public void Kill(ClientBehaviour client)
    {

        client.gameObject.SetActive(false);
        clientList.Add(client);
        //print("Kill");

    }


    public ClientBehaviour VariantCreate(Vector3 position, Quaternion rotation)
    {
        clientVariant = null;



        if (clientVariantList.Count > 0)
        {
            clientVariant = clientVariantList[0];
            clientVariant.transform.position = position;
            clientVariant.transform.rotation = rotation;
            clientVariant.gameObject.SetActive(false);
        }
        else
        {
            if (clientVariantList.Count < 1)
            {
                clientVariantGo = Instantiate(clientVariantPrefab, position, rotation);

                //clientVariantGo.transform.parent = transform;       // to make it a child 
            }

            clientVariant = clientVariantGo.GetComponent<ClientBehaviour>();

            clientVariantList.Add(clientVariant);

        }
        return clientVariant;
    }


    // public void ShowVariant()       // showVariant on left pool / spawner or right pool/spawner 
    // {
    //     if (variantScriptTimeStamp.timeCheck())      // show Variant if time is true 
    //     {
    //         if (clientVariantList.Count > 0)
    //         {
    //             clientVariantList.RemoveAt(0);

    //         }



    //         clientVariant.gameObject.SetActive(true);

    //     }
    // }




    public void KillVariant(ClientBehaviour clientVariant)
    {

        //print("KillVariant");

        clientVariant.gameObject.SetActive(false);
        clientVariantList.Add(clientVariant);
    }


    // void Update()
    // {
    //     ShowVariant();
    // }

    // public void OnDrawGizmos()
    // {
    //     Gizmos.color = new Color(0f, 1f, 0f, 0.4f);
    //     Gizmos.DrawSphere(transform.position, 1f);
    // }




}
