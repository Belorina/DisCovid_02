using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PressButtonDetection : MonoBehaviour
{
   public UnityEvent whenKeyIsPressed;

    void Update()
    {
        if (Input.anyKeyDown){
            whenKeyIsPressed?.Invoke();
            
        }
        
    }
}
