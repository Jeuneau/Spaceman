using System;
using System.Numerics;
using Raylib_cs;

namespace Movement;


class Enemy : MoverNode
{

    	//Vector2 Velocity;
		//Vector2 Acceleration;	
		//private float topspeed= 1000;
    public Enemy() : base("resources/Alien.png")
    {
	   
    }

     public override void Update(float deltaTime) {
        Move(deltaTime);
        WrapEdges();
		
	}

    /*private void Follow(float deltaTime)
		{
			Vector2 enemy = Raylib.GetMousePosition();
			//Console.WriteLine(mouse);
			Acceleration= enemy - Position;
			Acceleration= Vector2.Normalize(Acceleration);
			
			Velocity+= Acceleration;

		
			

			
			//Position = mouse; // incorrect!!

			// TODO implement
			// Position += Velocity * deltaTime;
			Position+= Velocity* deltaTime;
		}*/

   /*public void WrapEdges(float deltaTime)
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_height = TextureSize.Y;

			
			
			
			if (Position.X > scr_width - spr_width/2)
			{
				Position.X = 0;
			}
			if (Position.Y > scr_height - spr_height/2)
			{
				Position.Y = 0;
			}

			

			

			
            

            
			if (Position.X > scr_width) {
                Position.X = 0;
            }
            if (Position.X < 0) {
                Position.X = scr_width;
            }
            if (Position.Y > scr_height) {
                Position.Y = 0;
            }
            if (Position.Y < 0) {
                Position.Y = scr_height;
            }
			*/
		}