using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKey(KeyCode.L))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }

        if (Input.GetKey(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }

        if (Input.GetKey(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
