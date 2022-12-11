using System;
using Raylib_cs;

namespace Movement
{
	class Scene : SceneNode
	{

		public int NUM_Shoots= 50;
		// private fields
		private Player player;

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
		}

		/*public void Shoot() {			
			for(int i=0; i<51;i++) {
				Make Plasmashot
			}	
		}*/
			
		

	} // class

} // namespace
