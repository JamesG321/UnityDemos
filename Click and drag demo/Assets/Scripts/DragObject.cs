using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class DragObject : MonoBehaviour

{
    //mouse coordinate offset
    private Vector3 mOffset;
    //position of object last frame, for calculating release velocity 
    Vector3 prevPos;
    //mouse z coordinates
    private float mZCoord;



    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(

        gameObject.transform.position).z;
        Rigidbody  rb = GetComponent<Rigidbody>();
           

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

    //calculate speed on mouse release
    void OnMouseUp()
    {
        //rigid body of gameobject
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;

        //velocity vector based on change in position
        Vector3 throwVelocity = transform.position - prevPos;
        //normalize magnitude of velocity vector by factoring in the change in time between frames
        float speed = throwVelocity.magnitude / Time.deltaTime;
        Vector3 throwVelocityFinal = speed * throwVelocity.normalized;
        rb.velocity = throwVelocityFinal;
    }

    //update object location based on mouse location
    void OnMouseDrag()

    {   //save prevPos before updating
        prevPos = transform.position;
        //update mouse location
        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

}