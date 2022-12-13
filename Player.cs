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
	class Player : MoverNode
	{
		// your private fields here (rotSpeed, thrustForce)
		private float rotSpeed;
		private float thrustForce;
        internal static Vector2 position;

        // constructor + call base constructor
        public Player() : base("resources/spaceship.png")
		{
			rotSpeed = (float)Math.PI; // rad/second
			thrustForce = 500;

			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
			Color = Color.YELLOW;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Move(deltaTime);
			WrapEdges();
		}

		// your own private methods





		public void RotateRight(float deltaTime)
		{
			Rotation += rotSpeed * deltaTime;
		}

		public void RotateLeft(float deltaTime)
		{
			Rotation -= rotSpeed * deltaTime;
		}

		public void Thrust()
		{
			// TODO implement
			Color = Color.ORANGE;
        	

			// use thrustForce somewhere here
			Acceleration.X += thrustForce * (float)Math.Cos(Rotation);
			Acceleration.Y += thrustForce * (float)Math.Sin(Rotation);
		}

		public void NoThrust()
		{
			Color = Color.YELLOW;
			
		}

        public void Shoot()
        {
        	var instance = new Plasmaround();
    		instance.Bullet();
        }
    }
}