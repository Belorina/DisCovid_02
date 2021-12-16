using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// in charge of rotation "stars"
//add to "GAME" object

public class DayAndNightCycler : MonoBehaviour
{
    public GameParameters gameParameters;
    public Transform starsTransform;

    private float _starsRefreshRate;
    private float _rotationAngleStep;
    private Vector3 _rotationAxis;

    private void Awake()
    {
        
        //apply initial rotation on stars
        starsTransform.rotation = Quaternion.Euler(gameParameters.dayInitialRatio *-23f, 45f, 0f);



        // compute relevant calculation parameters
        _starsRefreshRate = 0.1f; 
        _rotationAxis = starsTransform.right;
        _rotationAngleStep = 360f * _starsRefreshRate / gameParameters.dayLengtInSeconds;
    }

    void Start()
    {
        StartCoroutine("_UpdateStars");
        
    }

    private IEnumerator _UpdateStars()
    {
        while (true)
        {
            starsTransform.Rotate(_rotationAxis, _rotationAngleStep, Space.World);
            yield return new WaitForSeconds(_starsRefreshRate);
        }
    }
}
