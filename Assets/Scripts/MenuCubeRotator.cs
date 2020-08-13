using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCubeRotator : MonoBehaviour
{
    private Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.transform.Rotate(Time.deltaTime+1f, 0, 0);
        rigidBody.transform.Rotate(0, Time.deltaTime+1f, 0, Space.World);
        
    }
}
