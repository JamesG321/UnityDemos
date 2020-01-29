using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(9, 9);
        Physics.IgnoreLayerCollision(10, 9);
        Physics.IgnoreLayerCollision(10, 9);
        Physics.IgnoreLayerCollision(10, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}   
