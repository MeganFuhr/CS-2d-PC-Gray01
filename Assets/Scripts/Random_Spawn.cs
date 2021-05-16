using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3;
    public int whatToSpawn;




    private void Start()
    {    
        whatToSpawn = Random.Range(1, 4);
        randomSpawn();
    }

    public void randomSpawn()
    {
        whatToSpawn = Random.Range(1, 4);

        switch (whatToSpawn)
        {
           
            case 1:
                Instantiate(prefab1, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler (0,0,Random.Range(0,360)));
                break;
            case 2:
                Instantiate(prefab2, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
            case 3:
                Instantiate(prefab3, this.gameObject.transform.localPosition = new Vector3(0, 4, 0), Quaternion.Euler(0, 0, Random.Range(0, 360)));
                break;
        }

    }

}
