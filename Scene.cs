using System;
using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;
 

namespace Movement
{
	class Scene : SceneNode
	{


		//private GUI gui;		
		List<Plasmaround> plasmarounds;

		public Plasmaround p;
		List<Enemy> enemies;
        private Enemy enemy;
        private Enemy enemy2;
        private Enemy enemy3;

		private Enemy enemy4;
		private Enemy enemy5;

		private Enemy enemy6;
        private Enemy enemy7;
        private Enemy enemy8;

		private Enemy enemy9;
		private Enemy enemy10;

		//public int dead_enemies;

		//private float score;

		public Vector2 distance_vec;

		

		double distance;

        // private fields
        private Player player;

		public int health;

		Node hp;

		bool Collision;

		

		

		private Gameover gameover;

		private Youwon youwon;

		private GUI gui;

		

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
			enemy6= new Enemy();
			enemy7= new Enemy();
			enemy8= new Enemy();
			enemy9= new Enemy();
			enemy10= new Enemy();

			
			AddChild(enemy);
			AddChild(enemy2);
			AddChild(enemy3);
			AddChild(enemy4);
			AddChild(enemy5);
			AddChild(enemy6);
			AddChild(enemy7);
			AddChild(enemy8);
			AddChild(enemy9);
			AddChild(enemy10);
			
			enemies.Add(enemy);
			enemies.Add(enemy2);
			enemies.Add(enemy3);
			enemies.Add(enemy4);
			enemies.Add(enemy5);
			enemies.Add(enemy6);
			enemies.Add(enemy7);
			enemies.Add(enemy8);
			enemies.Add(enemy9);
			enemies.Add(enemy10);

			enemy.Position = new Vector2(Settings.ScreenSize.X / 32, Settings.ScreenSize.Y / 32);
			enemy2.Position= new Vector2(Settings.ScreenSize.X / 12, Settings.ScreenSize.Y / 12*7);
			enemy3.Position= new Vector2(Settings.ScreenSize.X / 8*7, Settings.ScreenSize.Y / 8*2);
			enemy4.Position = new Vector2(Settings.ScreenSize.X / 16*3, Settings.ScreenSize.Y / 16*9);
			enemy5.Position = new Vector2(Settings.ScreenSize.X / 64*4, Settings.ScreenSize.Y / 64*4);
			enemy6.Position = new Vector2(Settings.ScreenSize.X / 32*7, Settings.ScreenSize.Y / 32*2);
			enemy7.Position= new Vector2(Settings.ScreenSize.X / 12*8, Settings.ScreenSize.Y / 12*5);
			enemy8.Position= new Vector2(Settings.ScreenSize.X / 8*2, Settings.ScreenSize.Y / 8*7);
			enemy9.Position = new Vector2(Settings.ScreenSize.X / 16*6, Settings.ScreenSize.Y / 16);
			enemy10.Position = new Vector2(Settings.ScreenSize.X / 64, Settings.ScreenSize.Y / 64*4);
		


			

			gameover= new Gameover();
			youwon= new Youwon();

			gui= new GUI();
			AddChild(gui);
			
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
					player.Damage(3);	
					}
			}

			//score= dead_enemies;

			//collision coderen per enemy
			for (int i = 0; i < plasmarounds.Count; i++)
            {
				for (int e = 0; e < enemies.Count; e++) {
					
					if (CalculateDistance(plasmarounds[i].Position, enemies[e].Position) < 10)
					{
						RemoveChild(enemies[e]);
						enemies.RemoveAt(e);
						dead_enemies++;
						
						RemoveChild(plasmarounds[i]);		
					}

				}
				

            }
			gui.Scale.X= player.health /10;

			if(dead_enemies>= 10) {
				AddChild(youwon);
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
			if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
				player.Reverse();
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
