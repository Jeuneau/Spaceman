using System;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{


class Plasmaround : MoverNode {
        public Plasmaround() : base("resources/Plasmaround.png")
        {
          Position= Player.position;  
           
        }



        public static Vector2 position { get; internal set; }

        public void Plasmaspawn() {
          Plasmaround p= new Plasmaround();
          AddChild(p);
          
          
        }
     
    }
}

  
  


  

 
 

      

      
