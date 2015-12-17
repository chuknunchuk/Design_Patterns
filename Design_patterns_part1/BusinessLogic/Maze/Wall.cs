using System;

namespace BusinessLogic
{
    public class Wall : MapSite
    {
        public Wall()
        {
            
        }
        public override void Enter()
        {
            Console.WriteLine("The Wall");
        }
    }
}
