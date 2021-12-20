using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ShowVariant on beat - right pool 

public class AudioSyncVariantSpawn_Right : AudioSyncer
{

    public void SetFalse()
    {
        m_isBeat = false;
    }
    public override void OnUpdate()
    {
        base.OnUpdate();

        if (m_isBeat) return;

        right_isOnBeat = false;

        
        if (right_isOnBeat)
        {
            keepDistanceTimer_right -= Time.deltaTime;
        }
        else
        {
            keepDistanceTimer_right = 0.5f;
        }


    }

    public override void OnBeat()
    {

        base.OnBeat();
        right_isOnBeat = true;

    }


    public bool right_isOnBeat;
    public float keepDistanceTimer_right = 0.5f;


}
