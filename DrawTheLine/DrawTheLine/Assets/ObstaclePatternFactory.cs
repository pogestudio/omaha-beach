using UnityEngine;
using System.Collections;

public class ObstaclePatternFactory
{

		public static int numberOfElementsPerLine;
		public static ObstaclePattern patternForDistanceAndDifficulty (float distance, float difficulty)
		{
		
				ObstaclePattern pattern = new ObstaclePattern ();
				computeWithDistanceAndDifficulty (pattern, distance, difficulty);
				return pattern;
		}
		private void computeWithDistanceAndDifficulty (ObstaclePattern pattern, float distance, float difficulty)
		{
				//decide how wide walls are going to be
				//decide where the gap is going to be located
		
		
				//		float random1 = Random.Range (0.0f, 0.5f);
				//		float random2 = Random.Range (random1, 1.0f);
		
		
				
				pattern.bottomLine.Add (0.3);
				pattern.bottomLine.Add (0.3);
				pattern.bottomLine.Add (0.3);
		
				
				pattern.middleLine.Add (0.3);
				pattern.middleLine.Add (0.3);
				pattern.middleLine.Add (0.3);
		
				
				pattern.topLine.Add (0.3);
				pattern.topLine.Add (0.3);
				pattern.topLine.Add (0.3);
		}
}

