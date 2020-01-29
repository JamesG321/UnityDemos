using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAndEjectToast : MonoBehaviour
{
    public GameObject toastPrefab;


    // Start is called before the first frame update
    [SerializeField] private Vector3 leftToast;       
    //public Vector3 leftToast;
    public Vector3 rightToast;
    public float ejectForce;
    private Vector3 localTransform;
    private Quaternion localQuaternion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        localTransform = gameObject.transform.position;
        localQuaternion = gameObject.transform.rotation;
        //spawn toast without eject
        if (Input.GetKeyDown("space"))
        {

            GameObject toast1 = Instantiate(toastPrefab, leftToast + localTransform, localQuaternion * Quaternion.Euler(90,0,0));
            GameObject toast2 = Instantiate(toastPrefab, rightToast + localTransform, localQuaternion * Quaternion.Euler(90, 0, 0));
            toast1.GetComponent<Rigidbody>().AddForce(-transform.forward * ejectForce);
            toast2.GetComponent<Rigidbody>().AddForce(-transform.forward * ejectForce);


        }

        //shoot toast
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject toast1 = Instantiate(toastPrefab, leftToast + localTransform, localQuaternion * Quaternion.Euler(90, 0, 0));
            toast1.GetComponent<Rigidbody>().AddForce(-transform.forward * ejectForce);

        }

        //shoot toast
        if (Input.GetKeyDown(KeyCode.H))
        {

            GameObject toast2 = Instantiate(toastPrefab, rightToast + localTransform, localQuaternion * Quaternion.Euler(90, 0, 0));
            toast2.GetComponent<Rigidbody>().AddForce(-transform.forward * ejectForce);

        }

    }
}
