using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;
 

namespace Movement
{
	class Scene : SceneNode
	{

		List<Score> scores;
		List<Plasmaround> plasmarounds;

		public Plasmaround p;
		List<Enemy> enemies;
        private Enemy enemy;
        private Enemy enemy2;
        private Enemy enemy3;

		private Enemy enemy4;
		private Enemy enemy5;

		private int dead_enemies= 0;

		private int scoreplayer;

		public Vector2 distance_vec;

		

		double distance;

        // private fields
        private Player player;

		public int health;

		bool Collision;

		

		

		private Gameover gameover;

		private Youwon youwon;

		private Score score;
		private Score score2;
		private Score score3;
		private Score score4;
		private Score score5;

		// constructor + call base constructor
		public Scene(String t) : base(t)
		{
			//for loop maken voor enemies als Player.isAlive
			player = new Player();
			AddChild(player);
			plasmarounds = new List<Plasmaround>();
			enemies= new List<Enemy>();
			scores= new List<Score>();
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

			score= new Score();
			score2= new Score();
			score3= new Score();
			score4= new Score();
			score5= new Score();

			scores.Add(score);
			scores.Add(score2);
			scores.Add(score3);
			scores.Add(score4);
			scores.Add(score5);

			score2.Position= new Vector2(Settings.ScreenSize.X / 8*2, Settings.ScreenSize.Y / 8);
			score3.Position= new Vector2(Settings.ScreenSize.X / 8*3, Settings.ScreenSize.Y / 8);
			score4.Position= new Vector2(Settings.ScreenSize.X / 8*4, Settings.ScreenSize.Y / 8);
			score5.Position= new Vector2(Settings.ScreenSize.X / 8*5, Settings.ScreenSize.Y / 8);


			

			gameover= new Gameover();
			youwon= new Youwon();
			
		}

        // Update is called every frame
        public override void Update(float deltaTime)
		{
			if(!player.IsAlive()) 
			{ 
				AddChild(gameover);
				return;
			}
			
			
			
			base.Update(deltaTime);
			HandleInput(deltaTime);


			// todo loop through enemies
			for (var i = 0; i < enemies.Count; i++) {
			enemies[i].Follow(deltaTime, player.Position);
			}
			 for (int e = 0; e < enemies.Count; e++)
            {
                	if (CalculateDistance(player.Position, enemies[e].Position) < 1)
                	{
					player.Damage(5);	
					}
			}

			//collision coderen per enemy
			for (int i = 0; i < plasmarounds.Count; i++)
            {
				for (int e = 0; e < enemies.Count; e++) {
					
					if (CalculateDistance(plasmarounds[i].Position, enemies[e].Position) < 20)
					{
						RemoveChild(enemies[e]);
						enemies.RemoveAt(e);
						dead_enemies++;

						for (int dead_enemies= 0; dead_enemies <= 5; dead_enemies++) {
							AddChild(score);
						}
						
						
						
						
						if(dead_enemies>= 5) {
							AddChild(youwon);
						}
					}
				}

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

		private float CalculateDistance(Vector2 a, Vector2 b)
        {
            return Vector2.Distance(a, b);
        }
			
		
		

	} // class
	
   
} // namespace
