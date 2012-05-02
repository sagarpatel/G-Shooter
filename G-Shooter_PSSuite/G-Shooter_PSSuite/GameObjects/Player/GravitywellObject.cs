using System;
using System.Collections.Generic;

using Sce.Pss.Core;
using Sce.Pss.Core.Environment;
using Sce.Pss.Core.Graphics;
using Sce.Pss.Core.Input;

using Sce.Pss.HighLevel.GameEngine2D;
using Sce.Pss.HighLevel.GameEngine2D.Base;


namespace GShooter_PSSuite
{

	public class GravitywellObject : GameObjectAbstract
	{




		float gValue;
		float gMValue;
		float cachedMass;
		float cachedForceNumerator;

		float minDistanceEPS;

		public GravitywellObject (string spriteFilePath) : base(spriteFilePath)
		{
			gValue = 10.0f;
			mass = 100000f;
			minDistanceEPS = 2f;

			gMValue = gValue * mass;

		}




		public void ApplyGravityToObjectArray(GameObjectAbstract[] objectArray)
		{
			cachedMass = objectArray[0].mass;
			cachedForceNumerator = gMValue * cachedMass;

			foreach(GameObjectAbstract gameObject in objectArray)
			{

				if(gameObject.isAlive == true)
				{

					ApplyGravityToSingleObject(gameObject);
				}
			}

		}


		private void ApplyGravityToSingleObject(GameObjectAbstract gameObject)
		{

			Vector2 gameObjectPosition = gameObject.sprite.Position;
			Vector2 distanceVector = sprite.Position - gameObjectPosition;
			Vector2 unitVector =  Vector2.Normalize(distanceVector);

			
			float forceMagnitude = cachedForceNumerator / Vector2.LengthSquared(distanceVector + minDistanceEPS);
			
			float accelerationOnObject = forceMagnitude / mass;
			
			Vector2 accelerationVector = accelerationOnObject * unitVector;

			gameObject.acceleration += accelerationVector;
			
			

		}







	}






}

