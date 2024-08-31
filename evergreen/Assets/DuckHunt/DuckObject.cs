using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckObject : MonoBehaviour
{
    public GameObject objDuck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int movespeed = 3;
        objDuck.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
    }
}
