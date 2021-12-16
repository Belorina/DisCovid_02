using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Parameters", menuName = "Scriptable Objects/Game Parameters", order = 10)]
public class GameParameters : ScriptableObject
{
    public bool enableDayAndNightCycle;
    public float dayLengtInSeconds;
    public float dayInitialRatio;   // allows us to define the initial positions of the "strats" 



    // a ratio of 0 means that we start at dusk time
    // a ratio of 0.5 means that we start at dawn time
    // noon corresponds to a ratio of 0.25
    // and midnight corresponds to a ratio of 0.75
}
