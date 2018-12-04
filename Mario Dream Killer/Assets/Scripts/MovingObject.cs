﻿using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	public GameObject objectToMove;   //platformer

	public Transform startPoint; //start point
	public Transform endPoint; //end point

	public float moveSpeed; 

	private Vector3 currentTarget;

    public Transform bug;

   

    // Use this for initialization
    void Start () {

		currentTarget = endPoint.position;

        bug = GetComponent<Transform>();



    }

	// Update is called once per frame
	void Update () {
		
		objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, currentTarget, moveSpeed * Time.deltaTime);

		if(objectToMove.transform.position == endPoint.position)
		{
			currentTarget = startPoint.position;   //jump to start point
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

		if(objectToMove.transform.position == startPoint.position)
		{
			currentTarget = endPoint.position;
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }
	
	}
}
