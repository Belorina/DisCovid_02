using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    //Song beats per minute 
    public float songBpm;

    //number of seconds for each song beat 
    public float secPerBeat;

    //Current song position, sec 
    public float songPosition;

    //Current song position, beats 
    public float songPositionInBeats;

    //How many sec have passed since the song started
    public float dspSongTime;

    // an AudioSource attached to this GameObject that will play music 
    public AudioSource musicSource;




    // Start is called before the first frame update
    void Start()
    {
        //Load the AudioSource attached to the Conductor GameObject
        musicSource = GetComponent<AudioSource>();

        //Calculate the number of seconds in each beat
        secPerBeat = 60f / songBpm;

        //Record the time when the music starts
        dspSongTime = (float)AudioSettings.dspTime;

        //Start the music
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //determine how many seconds since the song started
        songPosition = (float)(AudioSettings.dspTime - dspSongTime);

        //determine how many beats since the song started
        songPositionInBeats = songPosition / secPerBeat;
    }
}
