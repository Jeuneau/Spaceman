using System; // Console
using System.Numerics; // Vector2
using Raylib_cs; // Color

namespace Movement {
    class Score : MoverNode {

        public Score() : base("resources/Score.png") {
            Position= new Vector2(Settings.ScreenSize.X / 8, Settings.ScreenSize.Y / 8);


        }

    }
}




