using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject enemyBall;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int random = Random.Range(1,1000);

        if (random == 9)
            Instantiate(enemyBall,transform.position,Quaternion.identity);



    }
}
