using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SceneChangerManager : MonoBehaviour
{
    [Range(0f, 5f)]
    public float timeBeforeReset = 1f;

    public UnityEvent whenPlayerWins;

    //public Conductor conductor;

    public float songPosition;

    public float changeAt = 340f;




    // Start is called before the first frame update
    void Start()
    {

        //conductor = GameObject.Find("Audio").GetComponent<Conductor>();
        //songPosition = conductor.songPosition;

        
    }

    // Update is called once per frame
    void Update()
    {

        songPosition += Time.deltaTime;

        // end song means start win() to change scene
        if (songPosition >= changeAt)
        {
            StartCoroutine(Win());

        }
        
    }



    
    private IEnumerator Win()
    {
        yield return new WaitForSeconds(timeBeforeReset);
        whenPlayerWins?.Invoke();
    }

}
