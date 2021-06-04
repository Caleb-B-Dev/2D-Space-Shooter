using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _laserSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_laserSpeed * Vector3.up * Time.deltaTime);

        //If the position of the laser exceeds the screen's edge, destroy it.

        if(transform.position.y > 8.0f)
        {
            Destroy(gameObject);
        }


    }
}
