using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //Speed variable of 8
    [SerializeField]
    private float _laserSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //translate laser up
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);

        //If the laser position is off screen at Y = 8.0f, destroy laser. 
        if(transform.position.y > 8.0f)
        {
            Destroy(gameObject);
        }
    }
}
