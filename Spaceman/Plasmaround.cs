using System;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{


class Plasmaround : MoverNode {
        public Plasmaround() : base("resources/Plasmaround.png")
        {
            
            Plasmaround myObj= new Plasmaround();
            Position= Player.position;
        }

        public static Vector2 position { get; internal set; }
    }
}

  
  


  

 
 

      

      
