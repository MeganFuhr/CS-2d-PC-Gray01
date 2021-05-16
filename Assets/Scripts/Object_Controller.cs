using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Controller : MonoBehaviour
{
    Random_Spawn rs;

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    private bool touchedOnce = false;


    private Rigidbody2D rb;
    private Collider2D col;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rs = GameObject.FindGameObjectWithTag("spawner").GetComponent<Random_Spawn>();

    }

    void Update()
    {

        if (touchedOnce == true)
        {
            return;
        }

        if (isBeingHeld == true )
        {

                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, 4, 0);

        }
        

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

        if (isBeingHeld == false && touchedOnce == false)
        {
            rs.randomSpawn();
        }

        rb.isKinematic = false;
        rb.angularDrag = 2;
        touchedOnce = true;

        col = GetComponent<Collider2D>();
        col.isTrigger = false;

        WaitSeconds();


    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(1f);
        col.isTrigger = true;
    }
}
