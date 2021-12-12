using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ShowVariant on beat 

public class AudioSyncVariantSpawn : AudioSyncer
{
    public Vector3 whileBeat;
	public Vector3 whileRest;

    //coroutine 
    private IEnumerator MoveToScale(Vector3 _target)
	{
		Vector3 _curr = transform.localScale;
		Vector3 _initial = _curr;
		float _timer = 0;

		while (_curr != _target)
		{
			_curr = Vector3.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			transform.localScale = _curr;

			yield return null;
		}

		m_isBeat = false;
	}


    public override void OnUpdate()
	{
		base.OnUpdate();

		if (m_isBeat) return;

        // --> whileRest setActive false ;

		// transform.localScale = Vector3.Lerp(transform.localScale, restScale, restSmoothTime * Time.deltaTime);
	}

    public override void OnBeat()
	{
		base.OnBeat();

        // spawn show setActive true;

		StopCoroutine("MoveToScale");
		//StartCoroutine("MoveToScale", beatScale);
	}

}
