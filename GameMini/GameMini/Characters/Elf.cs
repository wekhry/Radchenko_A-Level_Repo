namespace GameMini.Characters
{
    internal class Elf : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Elf attacks with a lance!");
        }

        public void Block()
        {
            Console.WriteLine("Elf dodges to avoid the attack!");
        }
    }
}
