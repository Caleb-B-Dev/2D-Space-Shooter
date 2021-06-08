using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-9.46f, 9.46f), 5.94f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Move down at 4 m/s.
        transform.Translate(_enemySpeed*Vector3.down* Time.deltaTime);

        //If at bottom of the screen
        //Respawn at the top with new random x position. 
        if (transform.position.y <= -5.94f) 
        {
            transform.position = new Vector3(Random.Range(-9.46f, 9.46f), 5.94f, 0);
        }

    }
}
