using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5;
    public int whatToSpawn;
    public GameObject go;

    private LineRenderer lineRenderer;
    private float dist;

    private Vector3 start;
    private Vector3 end;


    private void Start()
    {
        RandomSpawn();
    }


    public void RandomSpawn()
    {
        whatToSpawn = Random.Range(1, 6);

        switch (whatToSpawn)
        {

            case 1:
                go = Instantiate(prefab1, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
            case 2:
                go = Instantiate(prefab2, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
            case 3:
                go = Instantiate(prefab3, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
            case 4:
                go = Instantiate(prefab4, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
            case 5:
                go = Instantiate(prefab5, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
        }

    }

    public void DrawLine(Vector3 start, Vector3 end)
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, start);
        end.x = start.x;
        lineRenderer.SetPosition(1, end);
    }

}
