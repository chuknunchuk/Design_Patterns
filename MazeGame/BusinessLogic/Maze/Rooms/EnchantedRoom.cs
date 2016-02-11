namespace BusinessLogic
{
    class EnchantedRoom : Room
    {
        private Spell spell = null;
        public EnchantedRoom(int roomNo) : base (roomNo)
        {
        }

        public EnchantedRoom(int number, Spell spell) : base(number)
        {
            this.spell = spell;
        }
    }
}
