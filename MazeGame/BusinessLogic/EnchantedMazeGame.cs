namespace BusinessLogic
{
    class EnchantedMazeGame : MazeGame
    {
        public EnchantedMazeGame()
        {
        }
        public override Room MakeRoom(int number)
        {
            return new EnchantedRoom(number, this.CastSpell());
        }
        public override Door MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }
        protected Spell CastSpell()
        {
            return new Spell();
        }
    }
}
