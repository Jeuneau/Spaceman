using System;
using Raylib_cs;
using System.Numerics; 

namespace Movement
{


class Plasmaround : MoverNode {
        public Plasmaround() : base("resources/Plasmaround.png")
        {
         
           
        }



       

        

        public override void Update(float deltaTime) {
			    Move(deltaTime);
		    }
     
    }
}

  
  


  

 
 

      

      
