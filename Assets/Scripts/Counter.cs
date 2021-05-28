using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{

    private float startTime = 15;
    public float currentTime = 0;
    private Canvas youLost;
    private GameObject go;

    [SerializeField] TextMeshProUGUI countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        go = GameObject.Find("/UI");
        youLost = go.transform.GetChild(0).gameObject.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        
        if (currentTime < 10 )
        {
            countdownText.color = Color.red;
        }
        if (currentTime <= 0 || youLost.enabled)
        {
            currentTime = 0;
            WaitSeconds();
            youLost.enabled = true;
            
        }

    }
    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(1f);
    }
}
