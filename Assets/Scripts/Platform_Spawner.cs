using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Spawner : MonoBehaviour
{
    public GameObject cat1, cat2, cat3;
    public int catToSpawn;
    public GameObject go;
    private Vector3 platformPosition;

    // Start is called before the first frame update
    void Start()
    {
        catToSpawn = Random.Range(1, 4);
        platformPosition = new Vector3(0.0f, -4.5f, 0.0f);
        CatRandomSpawn();

    }

    public void CatRandomSpawn()
    {
        catToSpawn = Random.Range(1, 4);

        switch (catToSpawn)
        {

            case 1:
                go = Instantiate(cat1, this.gameObject.transform.localPosition = platformPosition, Quaternion.Euler(0, 0, 0));
                Debug.Log(go.GetComponent<Collider2D>().bounds.size);

                break;
            case 2:
                go = Instantiate(cat2, this.gameObject.transform.localPosition = platformPosition, Quaternion.Euler(0, 0, 0));
                Debug.Log(go.GetComponent<Collider2D>().bounds.size);

                break;
            case 3:
                go = Instantiate(cat3, this.gameObject.transform.localPosition = platformPosition, Quaternion.Euler(0, 0, 0));
                Debug.Log(go.GetComponent<Collider2D>().bounds.size);

                break;
        }

    }
}
