using System.Numerics; // Vector2
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
	class AcceleratingBall : MoverNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
		// Vector2 position;
		// Vector2 velocity;
		// Vector2 acceleration;
		float topspeed;
		

		// constructor + call base constructor
		public AcceleratingBall() : base("resources/ball.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
			Color = Color.RED;
			
			topspeed= 2000;
			
			
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			
			if((Velocity.Length()>topspeed))
			 {
			Acceleration = new Vector2(0,0);
			}
			Move(deltaTime);
			WrapEdges();
			Acceleration= new Vector2(5,5);
		}


		

			// if (Position.X < 0 + spr_width/2)
			// {
			// 	velocity.X*=-1;
			// }

		

			// if (Position.Y < 0 + spr_height/2)
			// {
			// 	velocity.Y*=-1;
			// }
				
		}

	}

