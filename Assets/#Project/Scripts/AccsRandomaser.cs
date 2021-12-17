using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccsRandomaser : MonoBehaviour
{

    public LevelManager levelManager;

    public ClientBehaviour clientVariant;
    


    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;

 
    void Start()
    {
        levelManager = GameObject.Find("/LevelManager").GetComponent<LevelManager>();
        clientVariant = levelManager.clientVariant;



        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
       
        int prefabIndex = UnityEngine.Random.Range(0,3);
        Instantiate(prefabList[prefabIndex]);
 
    }
}
