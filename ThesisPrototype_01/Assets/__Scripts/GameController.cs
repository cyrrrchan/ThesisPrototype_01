using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public AudioSource _bass;
    public AudioSource _fx;
    public AudioSource _hiHat;
    public AudioSource _kick;
    public AudioSource _liveInstruments;
    public AudioSource _loop;
    public AudioSource _snare;
    public AudioSource _strings;
    public AudioSource _synth;
    public AudioSource _voice;

    private bool _hitSomething = false;
    private string _starTag;

    // Use this for initialization
    void Start () {
        /*AkSoundEngine.SetRTPCValue("Bass", 50.0f);
        AkSoundEngine.SetRTPCValue("FX", 50.0f);
        AkSoundEngine.SetRTPCValue("HiHat", 50.0f);
        AkSoundEngine.SetRTPCValue("Kick", 50.0f);
        AkSoundEngine.SetRTPCValue("LiveInstruments", 50.0f);
        AkSoundEngine.SetRTPCValue("Loop", 50.0f);
        AkSoundEngine.SetRTPCValue("Snare", 50.0f);
        AkSoundEngine.SetRTPCValue("Strings", 50.0f);
        AkSoundEngine.SetRTPCValue("Synth", 50.0f);
        AkSoundEngine.SetRTPCValue("Voice", 50.0f);*/
    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Untagged")
                _hitSomething = false;

            else if (hit.collider.tag != "Untagged")
            {
                _starTag = hit.collider.tag;
                _hitSomething = true;
            }
        }

        if (_hitSomething)
            ChangeSound();
    }

    void ChangeSound()
    {
        if (_starTag == "Bass")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) //if you press the left mouse button
            {
                _bass.volume += 0.1f;

            }

            else if (Input.GetKeyDown(KeyCode.Mouse1)) //if you press the left mouse button
            {
                _bass.volume -= 0.1f;
            }
        }

        else if (_starTag == "FX")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) //if you press the left mouse button
            {
                _fx.volume += 0.1f;

            }

            else if (Input.GetKeyDown(KeyCode.Mouse1)) //if you press the left mouse button
            {
                _fx.volume -= 0.1f;
            }
        }

        else if (_starTag == "HiHat")
        {
            if (Input.GetKeyDown(KeyCode.Q)) //if you press the left mouse button
            {
                _hiHat.volume = 0.1f;
            }

            else if (Input.GetKeyDown(KeyCode.E)) //if you press the left mouse button
            {
                _hiHat.volume -= 0.1f;
            }
        }
    }
}
