using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ObstacleManager : MonoBehaviour
{


		public Vector3 startPosition;
		public int numberOfObjects;
		public float recycleOffset;
		private Vector3 nextPosition;
	
		public Transform prefab;
		private Queue<Transform> objectQueue;
	
		void Start ()
		{
				objectQueue = new Queue<Transform> (numberOfObjects);
				for (int i = 0; i < numberOfObjects; i++) {
						objectQueue.Enqueue ((Transform)Instantiate (prefab));
				}
				nextPosition = startPosition;
				for (int i = 0; i < numberOfObjects; i++) {
						Recycle ();
				}
		}
	
		void Update ()
		{
				if (objectQueue.Peek ().localPosition.y + recycleOffset < PlayerScript.distanceTraveled) {
						Recycle ();
				}
		}
	
		private void Recycle ()
		{
				Transform obstacle = objectQueue.Dequeue ();
				obstacle.localPosition = nextPosition;
				nextPosition.y += obstacle.localScale.y;
				objectQueue.Enqueue (obstacle);
		}
}
