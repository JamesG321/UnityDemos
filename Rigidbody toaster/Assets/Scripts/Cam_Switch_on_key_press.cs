using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Switch_on_key_press : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;

    // Update is called once per frame
    void Update()
    {
        //on press of c, switch camera
        if (Input.GetKeyDown(KeyCode.C))
        {
            //if camera1 is active, switch to camera 2, else switch to camera 1
            if (camera1.activeInHierarchy)
            {
                camera1.SetActive(false);
                camera2.SetActive(true);
            }
            else
            {
                camera1.SetActive(true);
                camera2.SetActive(false);
            }
        }
    }
}
