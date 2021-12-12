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


    

    }

    public override void OnBeat()
    {

        base.OnBeat();
        left_isOnBeat = true;

    }


    public bool left_isOnBeat;

}
