using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights_Sync : AudioSyncer
{
    // Start is called before the first frame update
    public void Start()
    {
        neon = GameObject.Find("/Neon/pink_light");

        neonLight = neon.GetComponent<Light>();

        neonLight.intensity = restIntens;

    }

    public void SetLightsFalse()
    {
        m_isBeat = false;
        lightsIsOnBeat = false;
    }

    private IEnumerator MoveToBeatIntensity(float _target)
    {
        timer = 0;



        neonLight.intensity = _target;
        print("beat coroutine intensity changed");

        yield return null;
    }

    private IEnumerator MoveToRestIntensity(float _target)
    {

        neonLight.intensity = _target;
        print("rest co routine intens changed");
        yield return null;


    }



    public override void OnUpdate()
    {
        base.OnUpdate();

        // if (neonLight.intensity == restIntens && lightsIsOnBeat)
        // {
        //     neonLight.intensity = beatIntens;
        //     SetLightsFalse();
        // }

        // if (neonLight.intensity == beatIntens && lightsIsOnBeat)
        // {
        //     neonLight.intensity = restIntens;
        //     print("get back");
        //     SetLightsFalse();
        // }

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

        print("light on beat");

        StopCoroutine("MoveToRestIntensity");
        StopCoroutine("MoveToBeatIntesity");
        StartCoroutine("MoveToBeatIntensity", beatIntens);
    }

    public float beatIntens = 8;
    public float restIntens = 4;
    public GameObject neon;
    public Light neonLight;

    public bool lightsIsOnBeat;

    public float timer;

    public float changAfterSeconds;

}
