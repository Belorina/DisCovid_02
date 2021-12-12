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



    }

    public override void OnBeat()
    {

        base.OnBeat();
        right_isOnBeat = true;

        print("beat detected by me");
    }


    public bool right_isOnBeat;

}
