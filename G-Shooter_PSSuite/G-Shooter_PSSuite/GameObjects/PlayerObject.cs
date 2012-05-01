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

		GravitywellObject gravitywell_1;


		public PlayerObject (string spriteFilePath) : base(spriteFilePath)
		{
			gravitywell_1 =  new GravitywellObject("/Application/Resources/Sprites/gravitywellSprite.png");
			gravitywell_1.sprite.Position =  new Vector2(200,200);

		}

		
		public void AddToScene(Scene scene)
		{
			scene.AddChild(sprite); // add this player sprite
			scene.AddChild(gravitywell_1.sprite);

		}


		public void Update(GamePadData gamePadData)
		{

			//Handle player controls
			Vector2 tempPosition =  sprite.Position;
			
			tempPosition.X += gamePadData.AnalogLeftX * ananlogScale;
			tempPosition.Y += - gamePadData.AnalogLeftY * ananlogScale;
			
			tempPosition.X += gamePadData.AnalogRightX * ananlogScale;
			tempPosition.Y += - gamePadData.AnalogRightY * ananlogScale;


			sprite.Position = tempPosition;



			// handle gravity well controls


			Vector2 touchPosition = new Vector2(0,0);
			List<TouchData> touch_data_list = Touch.GetData(0);

			if(touch_data_list.Count > 0)
			{
				TouchData touchData = touch_data_list[0];
				
				touchPosition.X =  touchData.X * 960f ;
				touchPosition.Y = - touchData.Y * 544f ;
				/*
				System.Console.WriteLine( "X: {0:G}", touchPosition.X );
				System.Console.WriteLine( "Y: {0:G}", touchPosition.Y );
				*/
				if (touchData.X != 0 && touchData.Y != 0)
				{
					gravitywell_1.sprite.Position = touchPosition + new Vector2(480,272); //shift for Vita's coordinate system
				}

			}


		}






	}
}

