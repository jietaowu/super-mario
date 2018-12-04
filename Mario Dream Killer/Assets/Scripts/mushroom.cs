using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour {

    public GameObject objectToMove;   //platformer

    public Transform startPoint; //start point
    public Transform endPoint; //end point


    private Vector3 currentTarget;

    // Use this for initialization
    void Start()
    {

        currentTarget = startPoint.position;

    }

    // Update is called once per frame
    void Update()
    {



        if (objectToMove.transform.position == startPoint.position)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(2, 2, 2);

        }



        if (objectToMove.transform.position == endPoint.position)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        else
        {
            transform.localScale = new Vector3(2, 2, 2);
        }



    }
}
