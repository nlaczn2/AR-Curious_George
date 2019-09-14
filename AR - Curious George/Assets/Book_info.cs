using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Book_info : MonoBehaviour, IVirtualButtonEventHandler, ITrackableEventHandler
{

    public GameObject vbObj;
    public Animator cubeAni;

    public AudioClip musicClip;
    public AudioSource musicSource;
    public Rigidbody birds;
    private TrackableBehaviour mTrackableBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        } 


        vbObj = GameObject.Find("lacy_button");
        vbObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("Cube");
        Debug.Log("Button presses");
          //  throw new System.NotImplementedException();
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("Cube");
        Debug.Log("Button presses");
       // throw new NotImplementedException();
    }


    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            if (!musicSource.isPlaying)
            {
                Debug.Log("play music");
                musicSource.Play();
            }
        }
        else
        {
            // Stop audio when target is lost
            musicSource.Stop();
        }
    }

 
}
