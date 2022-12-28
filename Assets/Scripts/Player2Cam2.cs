using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Cam2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 ofset = new Vector3(0, 2, 1);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + ofset;
    }
}
