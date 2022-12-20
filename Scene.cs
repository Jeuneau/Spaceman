using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{
	class Scene : SceneNode
	{

		List<Plasmaround> plasmarounds;
		List<Enemy> enemies;
        private Enemy enemy;

        // private fields
        private Player player;

		
		// constructor + call base constructor
		public Scene(String t) : base(t)
		{
			//for loop maken voor Player.isAlive
			player = new Player();
			AddChild(player);
			plasmarounds = new List<Plasmaround>();
			enemies= new List<Enemy>();
			enemy= new Enemy();
			AddChild(enemy);
			enemy.Position = new Vector2(Settings.ScreenSize.X / 4, Settings.ScreenSize.Y / 4);
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
				if (p!= null) {
					AddChild(p);
					plasmarounds.Add(p);
				}
			}
		}

		

		



		  

		

		

		
			
		

	} // class

   
} // namespace
