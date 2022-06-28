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
	class Particle : MoverNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
		Vector2 MaxSpeed;
		Vector2 gravity;


		float Lifetime;

		// constructor + call base constructor
		public Particle(float x, float y, Color color) : base("resources/spaceship.png")
		{
			gravity = new Vector2(0, 500);
			Position = new Vector2(x, y);
			Scale = new Vector2(0.25f, 0.25f);
			Color = color;
			Velocity= new Vector2(20,30);


			// Random rand = new Random();

			// float randX = (float)rand.NextDouble();
			// float randY = (float)rand.NextDouble();
			Acceleration = new Vector2(5, 6);

			// Reset();
			
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			AddForce(gravity);

			Move(deltaTime);
			WrapEdges();
			Lifetime-= 1;
		}

		// your own private methods
		public Boolean isDead() 
		{
			return false;
			if(Lifetime<=0) 
			{
				return true;
			}
			return false;
		}

		public void Reset()
		{
			Lifetime = 100;
			Velocity *= 0;
			Acceleration *= 0;
		}
		

		

	}
}
