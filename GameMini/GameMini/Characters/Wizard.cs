namespace GameMini.Characters
{
    internal class Wizard : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Wizard attacks with a spell!");
        }

        public void Block()
        {
            Console.WriteLine("Wizard raises a magical shield to block!");
        }
    }
}
