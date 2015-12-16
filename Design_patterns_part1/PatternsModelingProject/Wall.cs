using System;

namespace BusinessLogic
{
    class Wall : MapSite
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
