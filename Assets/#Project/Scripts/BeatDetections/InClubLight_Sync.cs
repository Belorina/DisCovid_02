using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClubLight_Sync : AudioSyncer
{
    // Start is called before the first frame update
    public void Start()
    {
        //neon = GameObject.Find("/Neon/pink_light");

        //neonLight = neon.GetComponent<Light>();

        spotlight_1.intensity = restIntens;
        spotlight_2.intensity = restIntens;

    }

    public void SetLightsFalse()
    {
        m_isBeat = false;
        lightsIsOnBeat = false;
    }

    private IEnumerator MoveToBeatIntensity(float _target)
    {
        timer = 0;

        spotlight_1.intensity = _target;
        spotlight_2.intensity = _target;
        print("beat coroutine intensity changed");

        yield return null;
    }

    private IEnumerator MoveToRestIntensity(float _target)
    {

        spotlight_1.intensity = _target;
        spotlight_2.intensity = _target;

        print("rest co routine intens changed");
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

        print("light on beat");

        StopCoroutine("MoveToRestIntensity");
        StopCoroutine("MoveToBeatIntesity");
        StartCoroutine("MoveToBeatIntensity", beatIntens);
    }

    // public GameObject neon;
    public Light spotlight_1;
    public Light spotlight_2;


    public float beatIntens = 8;
    public float restIntens = 4;

    public bool lightsIsOnBeat;

    public float timer;

    public float changAfterSeconds;

}
