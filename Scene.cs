using System;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{
	class Scene : SceneNode
	{

		
		// private fields
		private Player player;
		private Plasmaround plasmaround;

		// constructor + call base constructor
		public Scene(String t) : base(t)
		{
			player = new Player();
			AddChild(player);
			
		}

        

        // Update is called every frame
        public override void Update(float deltaTime)
		{
			base.Update(deltaTime);

			HandleInput(deltaTime);
		}

		private void HandleInput(float deltaTime)
		{
			if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
				player.RotateLeft(deltaTime);
			}
			if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
				player.RotateRight(deltaTime);
			}
			if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
				player.Thrust();
			}
			if (Raylib.IsKeyReleased(KeyboardKey.KEY_UP)) {
				player.NoThrust();
			}
			if(Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) {
				var instance = new Plasmaround();
    			instance.Bullet();
			}
		}

		  

		

		

		
			
		

	} // class

} // namespace
