using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights_Sync : AudioSyncer
{
    // Start is called before the first frame update
    public void Start()
    {
        
        neonLight_1.intensity = restIntens;
        // neonLight_2.intensity = restIntens;
        // neonLight_3.intensity = restIntens;

    }

    public void SetLightsFalse()
    {
        m_isBeat = false;
        lightsIsOnBeat = false;
    }

    private IEnumerator MoveToBeatIntensity(float _target)
    {
        timer = 0;

        neonLight_1.intensity = _target;
        // neonLight_2.intensity = _target;
        // neonLight_3.intensity = _target;
        // print("beat coroutine intensity changed");

        yield return null;
    }

    private IEnumerator MoveToRestIntensity(float _target)
    {

        neonLight_1.intensity = _target;
        // neonLight_2.intensity = _target;
        // neonLight_3.intensity = _target;

        // print("rest co routine intens changed");
        yield return null;


    }



    public override void OnUpdate()
    {
        base.OnUpdate();


        timer += Time.deltaTime;

        if (timer >= changAfterSeconds)
        {
            StartCoroutine("MoveToRestIntensity",restIntens);
        }


        if (m_isBeat) return;

    }

    public override void OnBeat()
    {
        base.OnBeat();

        lightsIsOnBeat = true;

        // print("light on beat");

        StopCoroutine("MoveToRestIntensity");
        StopCoroutine("MoveToBeatIntesity");
        StartCoroutine("MoveToBeatIntensity", beatIntens);
    }

    // public GameObject neon;
    public Light neonLight_1;
    // public Light neonLight_2;
    // public Light neonLight_3;


    public float beatIntens = 8;
    public float restIntens = 4;

    public bool lightsIsOnBeat;

    public float timer;

    public float changAfterSeconds;

}
