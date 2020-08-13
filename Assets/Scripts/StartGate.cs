using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGate : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //transform.position = new Vector3(0, 0, 0);
        this.animator.SetBool("DoAnimate", true);
    }
}
