using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Object_Controller : MonoBehaviour
{
    Random_Spawn rs;

    private float startPosX;
    private float startPosY;
    private float startStart;
    private float endEnd;
    private bool isBeingHeld = false;
    private bool touchedOnce = false;
    private Vector3 end;
    private LineRenderer lr;

    private Canvas youLost;
    private GameObject go;

    private Rigidbody2D rb;
    private Collider2D col;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rs = GameObject.FindGameObjectWithTag("spawner").GetComponent<Random_Spawn>();
        lr = GameObject.Find("/Spawner").GetComponent<LineRenderer>();
        go = GameObject.Find("/UI");
        youLost = go.transform.GetChild(0).gameObject.GetComponent<Canvas>();

    }

    void Update()
    {

        if (touchedOnce == true)
        {
            return;
        }

        if (isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, 4, 0);
            rs.DrawLine(this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, 4, 0), new Vector3(mousePos.x + startPosX, end.y, 0));

        }

    }

    private void OnMouseDown()
    {
        if (youLost.enabled)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {

            if (touchedOnce == true)
            {
                return;
            }
            else
            {
                lr.enabled = true;

                end = GameObject.Find("Platform").transform.position;
                endEnd = end.x;
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);


                startPosX = mousePos.x - this.transform.localPosition.x;
                startPosY = mousePos.y - this.transform.localPosition.y;

                isBeingHeld = true;
            }
            
        }
    }

    private void OnMouseUp()
    {
        if (youLost.enabled)
        {
            return;
        }

        isBeingHeld = false;

        if (isBeingHeld == false && touchedOnce == false)
        {
            rs.RandomSpawn();
        }

        rb.isKinematic = false;
        rb.angularDrag = 2;
        touchedOnce = true;

        col = GetComponent<Collider2D>();
        col.isTrigger = false;

        lr = GameObject.Find("/Spawner").GetComponent<LineRenderer>();

        lr.enabled = false;

        WaitSeconds();


    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(1f);
        col.isTrigger = true;
    }
}
