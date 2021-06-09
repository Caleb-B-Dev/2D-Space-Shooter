using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4.0f;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-9.46f, 9.46f), 5.94f, 0);
    }

    void Update()
    {
        transform.Translate(_enemySpeed*Vector3.down* Time.deltaTime);

        if (transform.position.y <= -5.94f) 
        {
            float randomX = Random.Range(-9.46f, 9.46f);
            transform.position = new Vector3(randomX, 5.94f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
