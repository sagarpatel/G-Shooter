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
	public class PlayerObject : GameObjectAbstract
	{



		float ananlogScale = 10f;


		public PlayerObject (string spriteFilePath) : base(spriteFilePath)
		{

		}

		


		public void Update(GamePadData gamePadData)
		{

			Vector2 tempPosition =  sprite.Position;
			
			tempPosition.X += gamePadData.AnalogLeftX * ananlogScale;
			tempPosition.Y += - gamePadData.AnalogLeftY * ananlogScale;
			
			tempPosition.X += gamePadData.AnalogRightX * ananlogScale;
			tempPosition.Y += - gamePadData.AnalogRightY * ananlogScale;


			sprite.Position = tempPosition;

		}






	}
}

