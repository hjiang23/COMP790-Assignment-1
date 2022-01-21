using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlane : MonoBehaviour
{

    public double score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        score += 0.5;
    }
}
