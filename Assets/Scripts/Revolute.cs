using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolute : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.forward * speed * Time.deltaTime);        
    }
}
