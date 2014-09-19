using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

		public Vector3 startPosition;
		public float speed;
		public static float distanceTraveled;

		// Use this for initialization
		void Start ()
		{
				transform.localPosition = startPosition;
				rigidbody2D.velocity = new Vector3 (0, speed, 0);
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				if (transform.localPosition.y > distanceTraveled) {
						distanceTraveled = transform.localPosition.y;
	
				}
		}
}