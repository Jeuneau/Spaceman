using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{
	class Scene : SceneNode
	{

		List<Plasmaround> plasmarounds;
		// private fields
		private Player player;

		
		// constructor + call base constructor
		public Scene(String t) : base(t)
		{
			player = new Player();
			AddChild(player);
			plasmarounds = new List<Plasmaround>();
			//enemy = new Enemy();
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
				Plasmaround p = player.Shoot();
				AddChild(p);
				plasmarounds.Add(p);
				
				

    			//instance.Plasmaspawn();
				//add to scene
			}
		}

		  

		

		

		
			
		

	} // class

} // namespace
