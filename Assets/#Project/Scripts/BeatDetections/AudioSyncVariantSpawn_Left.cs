using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ShowVariant on beat - left pool 

public class AudioSyncVariantSpawn_Left : AudioSyncer
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
        left_isOnBeat = true;

        print("beat detected by me");
    }

	
    public bool left_isOnBeat;

}
