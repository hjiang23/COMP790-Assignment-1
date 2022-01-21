using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject plane;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (plane.GetComponent<TargetPlane>().score <= 10)
        {

            text.text = "SCORE: " + plane.GetComponent<TargetPlane>().score;
        }
        else
        {
            text.text = "SCORE: 10";
        }
    }
}
