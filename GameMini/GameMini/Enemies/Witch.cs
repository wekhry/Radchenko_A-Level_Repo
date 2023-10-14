namespace GameMini.Enemies
{
    internal class Witch :ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Witch casts a spell!");
        }

        public void Block()
        {
            Console.WriteLine("Witch creates a magical shield to block!");
        }
    }
}
