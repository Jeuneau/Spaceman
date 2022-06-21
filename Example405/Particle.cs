using System; // Console
using System.Numerics; // Vector2
using System.Collections.Generic; // List
using Raylib_cs; // Color

/*
In this class, we have the properties:

- Vector2  Position
- float    Rotation
- Vector2  Scale

- Vector2 TextureSize
- Vector2 Pivot
- Color Color

Methods:

- AddChild(Node child)
- RemoveChild(Node child, bool keepAlive = false)
*/

namespace Movement
{
	class Particle : SpriteNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
		Vector2 Velocity;
		Vector2 Acceleration;
		Vector2 MaxSpeed;
		int xx;
		int yy;


		float Lifetime;
		Vector2 startVelocity;

		// constructor + call base constructor
		public Particle(float x, float y, Color color) : base("resources/spaceship.png")
		{
			Position = new Vector2(x, y);
			Scale = new Vector2(0.25f, 0.25f);
			Color = color;
			xx= 300;
			yy= 300;
			startVelocity= new Vector2(xx,yy);
			Reset();
			
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Move(deltaTime);
			WrapEdges();
			Lifetime-= 1;
		}

		// your own private methods
		public void Move(float deltaTime)
		{
			// TODO implement
			Position += Velocity * deltaTime;
		}

		private void WrapEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_heigth = TextureSize.Y;

			// TODO implement...
			if (Position.X > scr_width)
			{
				// ...
			}
		}
		public Boolean isDead() 
		{
			if(Lifetime<=0) 
			{
				return true;
			}
			return false;
		}

		public void Reset()
		{
			Lifetime = 100;
			Velocity = startVelocity;
		}
		

		

	}
}
