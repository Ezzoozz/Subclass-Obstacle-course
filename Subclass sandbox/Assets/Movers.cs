using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movers
{
    AudioSource audiosource;

    Rigidbody rb;
        
   public abstract void Activate();
        
    protected void move(Transform transform,float distance)
    {
        transform.Translate(distance, 0, 0);

        
    }

    protected void Animate(Transform transform,float angle)
    {
        transform.Rotate(angle, 0, 0);

    }

    protected void PlaySound(AudioClip audio)
    {
        if(!audiosource.isPlaying)
        audiosource.PlayOneShot(audio);

    }
        
   
}
