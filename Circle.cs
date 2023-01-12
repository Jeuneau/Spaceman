using System; 
using System.Numerics; 
using Raylib_cs;

namespace Movement
{

class Circle : Node {
    public float radius = 5;

    public Circle() : base() {
        Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
    }
   
}

}