using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] float speed = 1f;

    Movers rollForward;

    Movers rollBackward;

    AudioClip ballSound = null;

   

    // Start is called before the first frame update
    void Start()
    {
        rollForward = new RollForward(transform);

        rollBackward = new RollBackward(transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            rollForward.Activate();
        }

        if(Input.GetKey(KeyCode.S))
        {
            rollBackward.Activate();
        }
    }
}
