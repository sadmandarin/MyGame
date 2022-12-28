using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    float countPlayer1;
    float countPlayer2;
    // Start is called before the first frame update
    void Start()
    {

        this.countPlayer1 = 0;
        this.countPlayer2 = 0;
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = true;
        camera4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            countPlayer1++;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            countPlayer2++;
        }

        if (countPlayer1 % 2 == 1)
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
        else
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }

        if (countPlayer2 % 2 == 1)
        {
            camera3.enabled = false;

            camera4.enabled = true;
        }
        else
        {
            camera3.enabled = true;
            camera4.enabled = false;
        }
    }
}
