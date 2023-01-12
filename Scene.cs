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
        private Enemy enemy2;
        private Enemy enemy3;

		private Enemy enemy4;

		private Circle circle1;

		private Circle circle2;

		 private Enemy enemy5;


        // private fields
        private Player player;

		bool Collision;

		
		// constructor + call base constructor
		public Scene(String t) : base(t)
		{
			//for loop maken voor enemies als Player.isAlive
			player = new Player();
			AddChild(player);
			plasmarounds = new List<Plasmaround>();
			enemies= new List<Enemy>();
			enemy= new Enemy();
			enemy2= new Enemy();
			enemy3= new Enemy();
			enemy4= new Enemy();
			enemy5= new Enemy();
			
			AddChild(enemy);
			AddChild(enemy2);
			AddChild(enemy3);
			AddChild(enemy4);
			AddChild(enemy5);
			
			enemies.Add(enemy);
			enemies.Add(enemy2);
			enemies.Add(enemy3);
			enemies.Add(enemy4);
			enemies.Add(enemy5);

			enemy.Position = new Vector2(Settings.ScreenSize.X / 32, Settings.ScreenSize.Y / 32);
			enemy2.Position= new Vector2(Settings.ScreenSize.X / 12, Settings.ScreenSize.Y / 12);
			enemy3.Position= new Vector2(Settings.ScreenSize.X / 8, Settings.ScreenSize.Y / 8);
			enemy4.Position = new Vector2(Settings.ScreenSize.X / 16, Settings.ScreenSize.Y / 16);
			enemy5.Position = new Vector2(Settings.ScreenSize.X / 64, Settings.ScreenSize.Y / 64);

			/*AddChild(circle1);
			AddChild(circle2);

			bool Collision(circle1, circle2) {
				if((circle1.radius + circle2.radius) > d) {
					return true;
				}
				return false;
			}

			void CheckCollisions() {
				foreach(plasmaround in Enemy.plasmarounds) {
					if(Collision(plasmarounds.player)) {

					}
				}
			}*/
		}





        

        // Update is called every frame
        public override void Update(float deltaTime)
		{
			base.Update(deltaTime);
			HandleInput(deltaTime);


			// todo loop through enemies
			for (var i = 0; i < enemies.Count; i++) {
			enemies[i].Follow(deltaTime, player.Position);
			/*enemy2.Follow(deltaTime, player.Position);
			enemy3.Follow(deltaTime, player.Position);*/
			}
			
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
