using System; // Console
using System.Numerics; // Vector2
using System.Collections.Generic; // List
using Raylib_cs; // Color

namespace Movement
{
	class ParticleSystem : Node
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
		List<Particle> particles;
		private List<Color> colors;
		public Particle p2;


		// constructor + call base constructor
		public ParticleSystem(float x, float y) : base()
		{
			Position = new Vector2(x, y);

			colors = new List<Color>();
			colors.Add(Color.WHITE);
			colors.Add(Color.ORANGE);
			colors.Add(Color.RED);
			colors.Add(Color.BLUE);
			colors.Add(Color.GREEN);
			colors.Add(Color.BEIGE);
			colors.Add(Color.SKYBLUE);
			colors.Add(Color.YELLOW);

			particles = new List<Particle>();
			Random rand = new Random();
			for (int i = 0; i < 100; i++)
			{
				float randX = (float)rand.NextDouble();
				float randY = (float)rand.NextDouble();
				Vector2 pos = new Vector2(x, y);
				// pos -= new Vector2(100, 100);
				Particle p = new Particle(randX * 100, randY * 100, colors[rand.Next()%colors.Count]);
				particles.Add(p);
				// p.Rotation = (float)Math.Atan2(pos.Y, pos.X);
				AddChild(p);
			}
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			// p2= particles[0];
			// if(p2.isDead()) 
			// {
			// 	particles.Remove(p2);
			// 	particles.Add(p2);
			// 	p2.Position= new Vector2(0,0);
			// 	p2.Reset();

			// }
			// else
			// {
			// 	foreach (Particle p in particles)
			// 	{
			// 		p.Update(deltaTime);
			// 	}
			// }
		}

		


	}
}
