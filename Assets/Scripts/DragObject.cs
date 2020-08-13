using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    //Instead of using Transform use Rigidbody.MovePosition()
    //That way we get collisions, and can inset objects

    [SerializeField]
    private string moveDirection = "x";
    private Vector3 point;
    public Rigidbody rigidBody;
    private Vector3 rotateVector;
    public GameObject endGoal;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        //endGoal = GameObject.Find("GoalGate");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        if (moveDirection.Equals("x"))
        {
            point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                        (transform.position.y - Camera.main.transform.position.y),
                        (transform.position.z - Camera.main.transform.position.z)));

            point.y = transform.position.y;
            point.z = transform.position.z;
            //transform.position = point;
            rigidBody.MovePosition(point);
        }
        else if (moveDirection.Equals("y"))
        {
            point = Camera.main.ScreenToWorldPoint(new Vector3((transform.position.x - Camera.main.transform.position.x),
                        (Input.mousePosition.y),
                        (transform.position.z - Camera.main.transform.position.z)));

            point.x = transform.position.x;
            point.z = transform.position.z;
            //transform.position = point;
            rigidBody.MovePosition(point);
        }
        else if (moveDirection.Equals("z"))
        {
            point = Camera.main.ScreenToWorldPoint(new Vector3((transform.position.x - Camera.main.transform.position.x),
                        (transform.position.y - Camera.main.transform.position.y),
                        (Input.mousePosition.z)));

            point.x = transform.position.x;
            point.y = transform.position.y;
            //transform.position = point;
            rigidBody.MovePosition(point);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal")
        {
            endGoal.GetComponent<BoxCollider>().isTrigger = false;
            Debug.Log("Puzzle Solved");
        }
    }
}
