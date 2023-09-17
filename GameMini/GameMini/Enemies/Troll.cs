namespace GameMini.Enemies
{
    internal class Troll : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Troll attacks with a club!");
        }

        public void Block()
        {
            Console.WriteLine("Troll blocks with his arm!");
        }
    }
}
