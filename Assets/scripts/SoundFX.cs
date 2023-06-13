using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    AudioSource src;
     
    // Start is called before the first frame update
    void Start()
    {
      src = GetComponent<AudioSource>();   
    }
    

    public void PlaySound()
    {
        src.Play();
    }
}
