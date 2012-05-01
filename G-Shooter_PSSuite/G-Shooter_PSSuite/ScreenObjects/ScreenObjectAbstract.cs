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

	public abstract class ScreenObjectAbstract
	{

		public Scene scene;

		public ScreenObjectAbstract ()
		{

			scene =  new Scene();

		}


		public virtual void Update()
		{


		}


		public virtual void Render()
		{

			
		}








	}


}

