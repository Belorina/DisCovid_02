using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public List<ClientBehaviour> clientList = new List<ClientBehaviour>();
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
}
