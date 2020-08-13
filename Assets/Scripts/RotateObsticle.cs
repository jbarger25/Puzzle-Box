using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObsticle : MonoBehaviour
{

    Rigidbody rigid;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Quaternion newRot = this.transform.rotation * Quaternion.Euler(0, speed * Time.deltaTime, 0);
        rigid.MoveRotation(newRot);
    }
}
