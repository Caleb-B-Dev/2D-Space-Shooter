using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private reference
    //data types (int, float, bool, string)
    //every value has a name
    //optional value assigned
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private GameObject _laserPrefab;
    [SerializeField]
    private GameObject _instantiateLaserPrefab;
    [SerializeField]
    private float _laserTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Take the current position = new position (0,0,0)
        transform.position = new UnityEngine.Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        //When player hits the space key
        //Spawn gameObject


        if(Input.GetKeyDown(KeyCode.Space))
        {
            _instantiateLaserPrefab = (GameObject) Instantiate(_laserPrefab,transform.position,Quaternion.identity);
            //Destroy(_instantiateLaserPrefab, _laserTime);
        }
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);

        if (transform.position.x >= 11.3f)
        {
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.3f)
        {
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }
    }
}
