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
	    Position = new Vector2(this.Position.X, this.Position.Y);
    }

     public override void Update(float deltaTime) {
    	Move(deltaTime);
        WrapEdges();
		
	}  
}