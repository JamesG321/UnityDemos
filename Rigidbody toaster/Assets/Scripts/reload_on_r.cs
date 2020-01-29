using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//for reloading scenes
using UnityEngine.SceneManagement;
public class reload_on_r : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Main Scene");
        }
    }
}
