using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGrip : MonoBehaviour
{

    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){ //Left Mouse
            Grab();
        }
    }

    void Grab(){

    }
}
