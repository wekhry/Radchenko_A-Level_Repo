namespace GameMini.Characters
{
    internal class Warrior : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with a sword!");
        }

        public void Block()
        {
            Console.WriteLine("Warrior blocks with a parry!");
        }
    }
}
