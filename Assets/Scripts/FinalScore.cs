using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    private int endScore;
    private GameObject[] endGO;

    private ParticleSystem ps;
    private ParticleSystem.EmissionModule emission;
    [SerializeField] TextMeshProUGUI ScoreText;
    private Canvas ScoreCanvas;


    // Start is called before the first frame update
    void Start()
    {
        ScoreText = this.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountFinalScore()
    {
        Vector2 checkVelocity;
        Vector2 zeroVelocity = new Vector2(0f, 0f);
        endGO = GameObject.FindGameObjectsWithTag("object");
        int i = 0;
        //endScore = 0;
        Debug.Log(endGO.Length);


        foreach (GameObject obj in endGO)
        {
            endScore += endGO[i].GetComponent<Object_Controller>().value;
            ps = endGO[i].GetComponentInChildren<ParticleSystem>();
            emission = ps.emission;
            emission.enabled = true;
            ps.Play();

            checkVelocity = endGO[i].GetComponent<Rigidbody2D>().velocity;

            if (checkVelocity == zeroVelocity)
            {
                endGO[i].GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }
            i++;
            if (i == endGO.Length - 1)
            {
                endScore -= endGO[i].GetComponent<Object_Controller>().value;
            }
        }

        ScoreText.text = endScore.ToString();

        this.GetComponent<Canvas>().enabled = true;

        Debug.Log("Your Score is: " + (ScoreCanvas));

    }
}
