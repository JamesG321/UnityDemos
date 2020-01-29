using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;

    Vector3 prevPos;
    private float mZCoord;



    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(

            gameObject.transform.position).z;
            Rigidbody  rb = GetComponent<Rigidbody>();
            //rb.useGravity = false;

        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }

    void OnMouseUp()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

        Vector3 throwVelocity = transform.position - prevPos;
        float speed = throwVelocity.magnitude / Time.deltaTime;
        Vector3 throwVelocityFinal = speed * throwVelocity.normalized;
        rb.velocity = throwVelocityFinal;
    }

    void OnMouseDrag()

    {
        prevPos = transform.position;
        transform.position = GetMouseAsWorldPoint() + mOffset;
        

    }

}