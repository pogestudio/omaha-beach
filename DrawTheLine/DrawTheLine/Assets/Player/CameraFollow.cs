using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

		private Transform player;
		
		private Vector3 offSet;

		// Use this for initialization
		void Start ()
		{
				player = GameObject.Find ("Player").transform;
				offSet = transform.localPosition;
		}
	
		// Update is called once per frame
		void Update ()
		{
				//only move Y, not X nor Z
				Vector3 newPos = offSet + new Vector3 (0, player.transform.localPosition.y, 0);
				transform.localPosition = newPos;
		}
}
