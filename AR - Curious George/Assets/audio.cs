using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class audio : MonoBehaviour
{
    public AudioClip musicClip;
    public AudioSource musicSource;
    public Rigidbody birds;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicClip;
    }

    // Update is called once per frame
    void Update()
    {
            if (!musicSource.isPlaying)
            {
                musicSource.Play();
            }
        
    }
}
