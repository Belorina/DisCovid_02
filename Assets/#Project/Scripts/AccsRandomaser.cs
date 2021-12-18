using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccsRandomaser : MonoBehaviour
{

    List<GameObject> prefabList = new List<GameObject>();
    public GameObject newCPrefab;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;

    List<GameObject> maskedPrefabList = new List<GameObject>();
    public GameObject newCVPrefab;
    public GameObject maskedPrefab1;
    public GameObject maskedPrefab2;
    public GameObject maskedPrefab3;
    public GameObject maskedPrefab4;
    public GameObject maskedPrefab5;



    void Start()
    {

        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        prefabList.Add(Prefab4);
        prefabList.Add(Prefab5);

        maskedPrefabList.Add(maskedPrefab1);
        maskedPrefabList.Add(maskedPrefab2);
        maskedPrefabList.Add(maskedPrefab3);
        maskedPrefabList.Add(maskedPrefab4);
        maskedPrefabList.Add(maskedPrefab5);




    }


    public void Update()
    {

        int prefabIndex = UnityEngine.Random.Range(0, 5);
        newCPrefab = prefabList[prefabIndex];

    
        int maskedPrefabIndex = UnityEngine.Random.Range(0, 5);
        newCVPrefab = maskedPrefabList[maskedPrefabIndex];
    }
}

