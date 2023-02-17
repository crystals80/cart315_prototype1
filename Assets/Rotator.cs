using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Any variable made public → is visible in the settings of Unity
    public float rotationSpeed = 0.3f;
    // Any variable made private → is NOT visible in the settings of Unity
    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate guarantees a regular interval and input
    void FixedUpdate()
    {  
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
    }
}

