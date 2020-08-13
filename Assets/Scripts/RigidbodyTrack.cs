using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RigidbodyTrack : MonoBehaviour
{
    public Transform[] path;
    public Transform pathObj;
    public float maxAngle;
    public int currIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
            path = this.GetComponentsInChildren<Transform>();
            if(path.Length > 0){
                for(int i = 1; i < path.Length-1; i++){
                    Debug.DrawLine(path[i].position, path[i+1].position, Color.red);
                }
            }
        #endif
    }

    void CheckIfOnTrack(){

    }
}
