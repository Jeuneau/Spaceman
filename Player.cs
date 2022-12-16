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

        public Vector2 velocity { get; private set; }
		public Vector2 direction;

		public Vector2 direction_normal;

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

		public Plasmaround Shoot() {
			//var instance = new Plasmaround();
    		//instance.Plasmaspawn();
			Plasmaround p= new Plasmaround();
			p.Position.X = this.Position.X + (float)Math.Cos(Rotation);
			p.Position.Y = this.Position.Y +  (float)Math.Sin(Rotation);
			
			p.Velocity = new Vector2(thrustForce * (float)Math.Cos(Rotation), thrustForce * (float)Math.Sin(Rotation));
			
			//new Vector2 direction -> normalize -> multiply met afstand middelpunt-neus
			direction= new Vector2((this.Position.X + (float)Math.Cos(Rotation)), (this.Position.Y +  (float)Math.Sin(Rotation)));
			direction_normal = Vector2.Normalize(direction);
			direction= direction_normal *32;
			//new Vector2( Position.X, Position.Y );
			return p;
	
			
		}

        
    }

    
}
