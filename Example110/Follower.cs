using System; // Console
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
			
	class Follower : SpriteNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
<<<<<<< HEAD
		Vector2 Velocity;
		Vector2 Acceleration;	
		private float topspeed= 1000;									
=======
											
>>>>>>> a8970e9357551cae13e61de64c8f285133732124

		// constructor + call base constructor
		public Follower() : base("resources/ball.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
			Color = Color.GREEN;
			
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Follow(deltaTime);
			BounceEdges();
<<<<<<< HEAD

			if((Velocity.Length()>topspeed))
			 {
			Velocity= Vector2.Normalize(Velocity)* topspeed;
			}
			
=======
>>>>>>> a8970e9357551cae13e61de64c8f285133732124
			
		}

		// your own private methods
		private void Follow(float deltaTime)
		{
			Vector2 mouse = Raylib.GetMousePosition();
			// Console.WriteLine(mouse);
<<<<<<< HEAD
			Acceleration= mouse - Position;
			Acceleration= Vector2.Normalize(Acceleration);
			
			Velocity+= Acceleration;

		
			

			
			//Position = mouse; // incorrect!!

			// TODO implement
			// Position += Velocity * deltaTime;
			Position+= Velocity* deltaTime;
=======
			
			Position = mouse; // incorrect!!

			// TODO implement
			// Position += Velocity * deltaTime;
>>>>>>> a8970e9357551cae13e61de64c8f285133732124
		}

		private void BounceEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_height = TextureSize.Y;

			// TODO implement...
			if (Position.X > scr_width)
			{
				// ...
			}
		}

	}
}
