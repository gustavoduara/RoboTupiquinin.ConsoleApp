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

        static void ExecutarRobo(string nomeRobo)
        {
            Console.Write($"Informe os valores do tamanho do {nomeRobo} Grid (X espaço Y): ");
            string[] grid = Console.ReadLine()!.Split(' ');
            int limiteX = int.Parse(grid[0]);
            int limiteY = int.Parse(grid[1]);

        }
    }
}