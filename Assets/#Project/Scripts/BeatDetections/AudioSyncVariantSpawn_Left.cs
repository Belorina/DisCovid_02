using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ShowVariant on beat - left pool 

public class AudioSyncVariantSpawn_Left : AudioSyncer
{



    public void SetFalse()
    {
        m_isBeat = false;
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (m_isBeat) return;

        left_isOnBeat = false;


        if (left_isOnBeat)
        {
            keepDistanceTimer_left -= Time.deltaTime;
        }
        else
        {
            keepDistanceTimer_left = 1f;
        }


    }

    public override void OnBeat()
    {

        base.OnBeat();
        left_isOnBeat = true;

    }

    public bool left_isOnBeat;

    public float keepDistanceTimer_left = 1f;


}
