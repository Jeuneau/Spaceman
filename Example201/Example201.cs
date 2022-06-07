using System;
using Raylib_cs;

namespace Movement
{
	class Example201 : SceneNode
	{
		// private fields
		private BouncingBall ball;
		float x = 100;
		float y = 100;
		float xspeed = 5;
		float yspeed = 3.3f;

		

		private int size;
		private int background;

		// constructor + call base constructor
		public Example201(String t) : base(t)
		{
			ball = new BouncingBall();
			AddChild(ball);
			
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			base.Update(deltaTime);
		}

		void setup() {
  		

		

  		

  		x = x + xspeed;
  		y = y + yspeed;

	
}

	} // class

} // namespace
