using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _laserSpeed = 8.0f;

    void Update()
    {
        transform.Translate(_laserSpeed * Vector3.up * Time.deltaTime);

        if(transform.position.y > 8.0f)
        {
            Destroy(gameObject);
        }
    }
}
