using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ShowVariant on beat - right pool 

public class AudioSyncVariantSpawn_Right: AudioSyncer
{

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (m_isBeat) return;


		print("m_isBeat is false");
    

    }

    public override void OnBeat()
    {

        base.OnBeat();
        right_isOnBeat = true;

        print("beat detected by me");
    }

	
    public bool right_isOnBeat;

}
