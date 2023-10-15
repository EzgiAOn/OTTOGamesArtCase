using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
public Transform pointA;
    public Transform pointB;
    public float speed;

    private bool isMovingToB = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);

                if (transform.position == pointB.position)
                {
                    isMovingToB = false;
                }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);

                if (transform.position == pointA.position)
                {
                    isMovingToB = true;
                }
        }
    }
}
