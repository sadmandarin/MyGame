using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 20f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player input
        verticalInput = Input.GetAxis("AlternativeVertical");
        horizontalInput = Input.GetAxis("AlternativeHorizontal");

        //Move venicle forward and backward
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * verticalInput);

        //rotate venicle
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
