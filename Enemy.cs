using System;
using System.Numerics;
using Raylib_cs;

namespace Movement;


class Enemy : MoverNode
{
	private float topspeed= 500;

    	//Vector2 Velocity;
		//Vector2 Acceleration;	
		//private float topspeed= 1000;
    public Enemy() : base("resources/Alien.png")
    {
	  
    }

     public override void Update(float deltaTime) {
    	Move(deltaTime);
        WrapEdges();
		Follow(deltaTime);
		if((Velocity.Length()>topspeed))
		{
			Velocity= Vector2.Normalize(Velocity)* topspeed;
		}
		
	}  

	private void Follow(float deltaTime)
		{
			Vector2 mouse = Raylib.GetMousePosition();
			// Console.WriteLine(mouse);
			Acceleration= mouse - Position;
			Acceleration= Vector2.Normalize(Acceleration);
			
			Velocity+= Acceleration;

		
			

			
			//Position = mouse; // incorrect!!

			// TODO implement
			// Position += Velocity * deltaTime;
			Position+= Velocity* deltaTime;
		}
}