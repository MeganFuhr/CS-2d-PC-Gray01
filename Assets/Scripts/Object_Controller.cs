using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Controller : MonoBehaviour
{

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    private bool touchedOnce = false;


    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (touchedOnce == true)
        {
            Debug.Log("Touched Once.  Exiting.");
            return;
        }

        if (isBeingHeld == true )
        {

                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, 4, 0);
                //this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);

        }
        //rb.AddForce(-transform.forward * 500f);
        //rb.velocity = rb.velocity * .03f;

        
    }

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            

            Vector3 mousePos;


            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
           
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
        rb.isKinematic = false;
        rb.angularDrag = 2;

        //rb.mass = 1000;
        touchedOnce = true;

    }
}
