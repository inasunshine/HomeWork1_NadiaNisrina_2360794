using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloHomeWork1 : MonoBehaviour
{
    public int speed = 10;
    public GameObject helloText;
    // Start is called before the first frame update
    void Start()
    {
        print("Hi");

    }

    // Update is called once per frame
    void Update()
    {
        print("ola");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
