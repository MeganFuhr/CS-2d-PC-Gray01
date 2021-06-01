using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom_Barrier : MonoBehaviour
{

    private Canvas youLost;
    private GameObject go;


    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.Find("/UI");
        youLost = go.transform.GetChild(0).gameObject.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        youLost.enabled = true;
    }

}
