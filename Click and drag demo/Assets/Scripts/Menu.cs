using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Menu : MonoBehaviour
{
    public void backToMenus()
    {
        SceneManager.LoadScene("Menu");
    }

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
