namespace RoboTupiquinin.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Robo Tupiniquim - Missão Marte");
            Console.WriteLine("---------------------------------------------");

            ExecutarRobo("PRIMEIRO");

            Console.WriteLine("Pressione ENTER para iniciar o SEGUNDO robô...");
            Console.ReadLine();

            ExecutarRobo("SEGUNDO");
        }
    }
}
