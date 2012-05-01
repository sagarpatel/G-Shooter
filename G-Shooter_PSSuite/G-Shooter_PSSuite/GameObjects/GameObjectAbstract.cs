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
	public abstract class GameObjectAbstract
	{


		public SpriteUV sprite;

		public Vector2 velocity;
		public float mass;


		public GameObjectAbstract (string spriteFilePath)
		{

			TextureInfo texture_info = new TextureInfo(new Texture2D(spriteFilePath, false) );
			sprite = new SpriteUV() {TextureInfo = texture_info};
			sprite.Quad.S = texture_info.TextureSizef;
			sprite.CenterSprite();
			sprite.Position = new Vector2(100,100);

			velocity =  new Vector2(0,0);
			mass = 10.0f;

		}


		public virtual void Update()
		{



		}




	}
}

