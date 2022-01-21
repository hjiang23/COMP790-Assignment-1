using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    public BallPrefab ballPrefab;
    public bool clickEnabled;

    // Start is called before the first frame update
    void Start()
    {
        clickEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clickEnabled)
        {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
            ball.transform.localPosition = transform.position;

            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 2000);
        }
    }
}
