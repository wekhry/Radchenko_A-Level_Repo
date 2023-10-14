namespace GameMini.Enemies
{
    internal class Goblin : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Goblin attacks with a knife!");
        }

        public void Block()
        {
            Console.WriteLine("Goblin blocks with a hard skin!");
        }
    }
}
