using System;

namespace DesignPatterns.BridgePattern
{
    
    public abstract class SoftWare
    {
        public abstract void Run();
    }

    public class Camera : SoftWare
    {
        public override void Run()
        {
            Console.WriteLine("running the camera.");
        }
    }
    
    public class Game : SoftWare
    {
        public override void Run()
        {
            Console.WriteLine("running the game.");
        }
    }

    public class ThreeDTouch : SoftWare
    {
        public override void Run()
        {
            Console.WriteLine("running the 3d touch.");
        }
    }
}