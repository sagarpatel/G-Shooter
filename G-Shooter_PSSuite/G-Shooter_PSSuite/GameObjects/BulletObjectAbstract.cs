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

	public class BulletObjectAbstract : GameObjectAbstract
	{

		public int damagePoints;

		public BulletObjectAbstract (string spriteFilePath) : base(spriteFilePath)
		{

			damagePoints = 10;
		}

		public virtual void Update()
		{
			
		}



	}


}

