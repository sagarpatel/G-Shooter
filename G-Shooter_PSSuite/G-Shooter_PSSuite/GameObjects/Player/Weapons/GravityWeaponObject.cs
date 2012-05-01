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
	

	public class GravityWeaponObject : WeaponObjectAbstract
	{


		public float bulletMaxVelocity;


		public GravityWeaponObject (int maxBullets) : base(maxBullets)
		{
			bulletsArray =  new SimpleBulletObject[maxBullets];

			for (int i=0; i < maxBullets; ++i)
			{
				bulletsArray[i] = new SimpleBulletObject("/Application/Resources/Sprites/pokeball_color1_ss.png");
			}

		}








	}

}

