using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objTestMan;
    void Start()
    {
        objTestMan.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
