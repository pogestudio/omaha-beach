using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Responsibility:
//To deliver the coordinates for the three obstacles per line
//based on the location the obstacle should have
public class PlacementAI : MonoBehaviour
{

		public float startDistance;
		public float minimalGap;
		public float maximalGap;
		
		
		void Start ()
		{
				ObstaclePatternFactory.numberOfElementsPerLine = 5;
		}
		
		public List<ObstacleStructure> obstacleStructuresForDistance (float distance)
		{
		
				//first get a common pattern
				float difficulty = 1.0;
				ObstaclePattern patternToUse = ObstaclePatternFactory.patternForDistanceAndDifficulty (distance, difficulty);
				//then construct the three structures
				List<ObstacleStructure> structures = structuresForPattern (patternToUse);
				//then return them
		
		}
		
		private List<ObstacleStructure> structuresForPattern (ObstaclePattern pattern)
		{
		
		}
		
}
