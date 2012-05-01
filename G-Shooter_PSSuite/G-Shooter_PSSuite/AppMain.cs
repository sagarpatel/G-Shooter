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
	
	
	public class AppMain
	{

		static Scene scene_Main;
		
		static PlayScreenObject testScreen;
		static PlayerObject player;

		
		public static void Main (string[] args)
		{

			Sce.Pss.Core.Graphics.GraphicsContext context = new Sce.Pss.Core.Graphics.GraphicsContext();
			uint sprites_capacity = 500;
			uint draw_helpers_capacity = 400;
			Director.Initialize(sprites_capacity, draw_helpers_capacity, context);



			Initialize ();

			while (true) {
				SystemEvents.CheckEvents ();
				Update ();
				Render ();
			}


		}



		public static void Initialize ()
		{
			Director.Instance.GL.Context.SetClearColor(Colors.Grey20);

			scene_Main = new Scene();
			scene_Main.Camera.SetViewFromViewport();

			testScreen =  new PlayScreenObject();
			testScreen.scene.Camera.SetViewFromViewport();
			player = new PlayerObject("/Application/Resources/Sprites/playerSprite.png");
			testScreen.scene.AddChild(player.sprite);


			Director.Instance.RunWithScene( testScreen.scene, true );


		}



		public static void Update ()
		{
			// Query gamepad for current state
			var gamePadData = GamePad.GetData (0);
			Director.Instance.Update();

		}




		public static void Render ()
		{
			Director.Instance.Render();

			Director.Instance.GL.Context.SwapBuffers();
			Director.Instance.PostSwap(); // you must call this after SwapBuffers
		}





	}
}
