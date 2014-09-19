using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveController : MonoBehaviour
{
	
		//List<Touch> touchPositions = new List<Touch> ();
		//For PC
		//List<Vector3> mousePos = new List<Vector3> ();
		public Camera cameraUsedForInputs;
		public float TouchInputHeight ;
		public float maxSpeed;
		public float errorMargin;
		// Use this for initialization
		
		public float cameraSpeed;
		
		void Start ()
		{
				Debug.Log ("moveCont started");
				//cameraUsedForInputs.velocity = new Vector3 (0, cameraSpeed, 0);
		}
	
	
		void Update ()
		{
		
				if (Input.GetMouseButtonDown (0)) {
						
			
						//touchPositions.Add (Input.touches [0].position);
						//mousePos.Add (Input.mousePosition);
						//Debug.Log (Input.mousePosition);
				}
		}
		
		
		void OnGUI ()
		{
				//GUI.Box (new Rect (0, 0, Screen.width, TouchInputHeight), "Bottom-left");
		
				if (GUI.RepeatButton (new Rect (0, Screen.height - TouchInputHeight, Screen.width, TouchInputHeight), "TOUCH HERE")) {
						// This code is executed every frame that the RepeatButton remains clicked
						
						
						
						
						
						//Get the mousePos
						Vector3 mousePosInWorld = cameraUsedForInputs.ScreenToWorldPoint (Input.mousePosition);
						
						/*
						
						DELETE IF NOT USED WITHIN 22 SEPT
						
						//Get the position of the player
						float playerPos = transform.localPosition.x;
						//check if its to the left or to the right
						if (Mathf.Abs (mousePosInWorld.x - playerPos) < errorMargin) {
								stopPlayerXVelocity ();
						} else {
								//movePlayerTowardsXPosition (mousePosInWorld);
								//Debug.Log ("Mouse is left of player: " + mousePos + " with mousepos:  -" + mousePosInWorld + " and PppS:s " + transform.position);
						}
						
						DELETE IF NOT USED WITHIN 22 SEPT
						*/
						
						transform.position = new Vector3 (mousePosInWorld.x, transform.position.y, transform.position.z);
						
			
				} else {
				
				}
		}
		
		
		/*
						
						DELETE IF NOT USED WITHIN 22 SEPT
		private void movePlayerTowardsXPosition (Vector3 newTarget)
		{
		
				//check difference
				float difference = transform.localPosition.x - newTarget.x;
				
				//decide speed
		
				float correctedSpeed = maxSpeed;
				//if it is within 10 error margins, reduce speed by 1/10th each margin
				const float errorMarginLimit = 20.0f;
				Debug.Log ("should move, diff: " + difference);
				if (Mathf.Abs (difference) < errorMarginLimit * errorMargin) {
						
						float numberOfErrorMarginsFromTarget = Mathf.Abs (difference / errorMargin);
						correctedSpeed = maxSpeed * numberOfErrorMarginsFromTarget / errorMarginLimit;
						Debug.Log ("corrected speed for  " + difference + " is " + correctedSpeed);
			
				}
				//decide direction
				//if positive, we want to go right. If negtative, left
				bool shouldGoLeft = difference > 0 ? true : false;
				float speedToApply = shouldGoLeft ? -correctedSpeed : correctedSpeed;
		
				//apply
				rigidbody2D.velocity = new Vector3 (speedToApply, rigidbody2D.velocity.y, rigidbody2D.velocity.x);
		}
		
	
		private void stopPlayerXVelocity ()
		{
				rigidbody2D.velocity = new Vector3 (0, rigidbody2D.velocity.y, rigidbody2D.velocity.x);
		}
		
		
						
						DELETE IF NOT USED WITHIN 22 SEPT
	*/
	
}
