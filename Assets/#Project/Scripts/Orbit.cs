using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// determine suns angle on conductor song position 


public class Orbit : MonoBehaviour
{
    public float timeElapsed;
    public float lerpDuration = 10f;


    public float startValue = 20f;

    public float endValue = 30f;

    public float valueToLerp;




    // public float angle = 0.1f;


    // public Conductor conductor;

    // public float songPositionSec;

    // public Transform begin;
    // public Transform end;

    //public Transform target;
    //public float newAngle;

    void Start()
    {


        this.transform.Rotate(startValue, 80, 0, Space.Self);


        // conductor = GameObject.Find("Audio").GetComponent<Conductor>();


    }

    // Update is called once per frame
    void Update()
    {


        if (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);

            timeElapsed += Time.deltaTime;
        }

        

        this.transform.Rotate(valueToLerp, 80, 0, Space.Self);




        //newAngle = Quaternion.Angle(this.transform.rotation, target.rotation);

        //songPositionSec = conductor.songPosition;

        //this.transform.Rotate(xAngle, yAngle, zAngle, Space.World);


        // if (songPositionSec == 0f)
        // {
        //     begin

        // }

        // if (songPositionSec >= 10f)
        // {
        //     print("its 10 sec");

        //     this.transform.Rotate(-200, 80, 0, Space.Self);


        // }

        // // if (songPositionSec == 330f)
        // // {
        // //     myRotation.eulerAngles = new Vector3(-200, 80, 0);

        // // }


        //this.transform.RotateAround(Vector3.zero, Vector3.right, angle);

    }


}
