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
		public Vector2 acceleration;
		public float mass;
		public bool isAlive;

		public float lifeTime;


		public GameObjectAbstract (string spriteFilePath)
		{

			TextureInfo texture_info = new TextureInfo(new Texture2D(spriteFilePath, false) );
			sprite = new SpriteUV() {TextureInfo = texture_info};
			sprite.Quad.S = texture_info.TextureSizef;
			sprite.CenterSprite();
			sprite.Position = new Vector2(100,100);

			velocity =  new Vector2(0,0);
			mass = 10.0f;

			isAlive = false;

			lifeTime = 0;

		}


		public virtual void Update(float dt)
		{

			Vector2 tempPosition =  sprite.Position;

			velocity += acceleration * dt;
			tempPosition += velocity * dt;
			sprite.Position = tempPosition;
			acceleration = new Vector2(0,0);

			lifeTime += dt;

			if(Vector2.Length(sprite.Position) > 2000)
			{
				KillSelf();
			}


		}


		public virtual void KillSelf()
		{

			isAlive = false;
			velocity =  new Vector2(0,0);
			sprite.Position =  new Vector2(100,100);
			lifeTime = 0;

		}




	}
}

