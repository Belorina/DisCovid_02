using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IN KILL VARIANT - condision to get all variants poped and not back in list 



public class Pool : MonoBehaviour
{
    public List<ClientBehaviour> clientList = new List<ClientBehaviour>();

    public List<ClientBehaviour> clientVariantList = new List<ClientBehaviour>();

    public GameObject clientPrefab;
    public GameObject clientVariantPrefab;

    


    public ClientBehaviour Create(Vector3 position, Quaternion rotation)
    {
        ClientBehaviour client = null;

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
            client = clientGo.GetComponent<ClientBehaviour>();
        }
        return client;
    }

    public void Kill(ClientBehaviour client)
    {
        client.gameObject.SetActive(false);
        clientList.Add(client);

    }


    public ClientBehaviour VariantCreate(Vector3 position, Quaternion rotation)
    {
        ClientBehaviour clientVariant = null;

        if (clientVariantList.Count > 0)
        {
            clientVariant = clientVariantList[0];
            clientVariantList.RemoveAt(0);
            clientVariant.transform.position = position;
            clientVariant.transform.rotation = rotation;
            clientVariant.gameObject.SetActive(false);           // was true 

        }
        else
        {
            GameObject clientVariantGo = Instantiate(clientVariantPrefab, position, rotation);
            clientVariant = clientVariantGo.GetComponent<ClientBehaviour>();

        }
        return clientVariant;
    }

    public void KillVariant(ClientBehaviour clientVariant)
    {

        clientVariant.gameObject.SetActive(false);
        clientVariantList.Remove(clientVariant);

        

    }
}
