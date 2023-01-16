using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{
	class Scene : SceneNode
	{

		List<Plasmaround> plasmarounds;

		Plasmaround p;
		List<Enemy> enemies;
        private Enemy enemy;
        private Enemy enemy2;
        private Enemy enemy3;

		private Enemy enemy4;
		private Enemy enemy5;

		public Vector2 distance_vec;

		double distance;

		/*private Circle circle1;


		private Circle circle2;

		private Circle circle3;

		private Circle circle4;

		private Circle circle5;

		private Circle circle6;

		private Circle circle7;*/

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

			/*circle1= new Circle();
			circle2 = new Circle();
			circle3= new Circle();
			circle4= new Circle();
			circle5= new Circle();
			circle6= new Circle();
			circle7= new Circle();

			AddChild(circle1);
			AddChild(circle2);
			AddChild(circle3);
			AddChild(circle4);
			AddChild(circle5);
			AddChild(circle6);
			AddChild(circle7);

			circle1.Position.X= player.Position.X;
			circle2.Position= enemy.Position;
			circle3.Position= enemy2.Position;
			circle4.Position= enemy3.Position;
			circle5.Position= enemy4.Position;
			circle6.Position= enemy5.Position;
			circle7.Position= p.Position;*/


			
			bool Collision(Plasmaround plasmaround, Enemy enemies) {

				distance_vec= enemies.Position - plasmaround.Position;
				distance= distance_vec.Length(); 
				if(distance <= 67) {
					return true;
				}
				return false;
			}

			void CheckCollisions(Plasmaround plasmaround, Enemy enemies) {
				foreach(Plasmaround in  Player.plasmarounds) 
				{
					if(Collision()) {
						RemoveChild(p);

					}
				}
			}

			
		}

       















        // Update is called every frame
        public override void Update(float deltaTime)
		{
			base.Update(deltaTime);
			HandleInput(deltaTime);


			// todo loop through enemies
			for (var i = 0; i < enemies.Count; i++) {
			enemies[i].Follow(deltaTime, player.Position);
			

			/*Plasmaround p= enemies[i].Shoot();
			AddChild(p);
			plasmarounds.Add(p);
			enemies[i].Shoot();*/
			
			}

			CheckCollision();


			
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
