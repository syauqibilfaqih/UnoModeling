using UnoModellingPractice.GameObjects;

namespace UnoModellingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager manager = new GameManager(6);

            manager.PlayGame();

            Console.ReadKey();
        }
    }
}
