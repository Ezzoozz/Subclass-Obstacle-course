using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollForward : Movers
{
    Transform transform;


    public RollForward (Transform transform)
    {
        this.transform = transform;


    }
    public override void Activate()
    {
        move(transform,0.3f);
        Animate(transform,30f);
        //PlaySound(rollingSound);

    }


}
