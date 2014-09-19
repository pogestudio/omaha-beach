using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//an ObstaclePattern is a simple class which represents the the next three levels using a simple pattern

public class ObstaclePattern
{
	
		private bool hasComputed;
		public List<Float> bottomLine;
		public List<Float> middleLine;
		public List<Float> topLine; 
		
		override void init ()
		{
				bottomLine = new List<Float> ();
				middleLine = new List<Float> ();
				topLine = new List<Float> ();
		}

}

