using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMessage : MonoBehaviour
{
    public GameObject plane;
    public GameObject cam;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (plane.GetComponent<TargetPlane>().score == 10)
        {
            cam.GetComponent<ButtonClick>().clickEnabled = false;
            text.enabled = true;
        }
    }
}
