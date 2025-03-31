namespace RoboTupiniquimin.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Robo Tupiniquim - Missão Marte");
            Console.WriteLine("---------------------------------------------");
            do
            {
                ExecutarRobo("PRIMEIRO");

                Console.WriteLine("Pressione ENTER para iniciar o SEGUNDO robô...");
                Console.ReadLine();

                ExecutarRobo("SEGUNDO");

                Console.Clear();
                Console.WriteLine("Deseja continuar? (S para Sim, N para Não): ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta != "S")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }

            } while (true);
        }

        static void ExecutarRobo(string nomeRobo)
        {
            Console.Write($"Informe os valores do tamanho do {nomeRobo} Grid (X espaço Y): ");
            string[] grid = Console.ReadLine()!.Split(' ');
            int limiteX = int.Parse(grid[0]);
            int limiteY = int.Parse(grid[1]);

            Console.WriteLine($"Informe a posição inicial do {nomeRobo} Robô no grid (X e Y) e o sentido que ele está: (ex: N,S,L, ou O):  ");
            string[] posicoes = Console.ReadLine()!.Split(' ');
            int posicaoX = int.Parse(posicoes[0]);
            int posicaoY = int.Parse(posicoes[1]);
            char direcao = char.Parse(posicoes[2]);

            Console.WriteLine($"Informe os comandos que o {nomeRobo} Robô deve executar:(Ex:EMEMEMEMM) ");
            char[] instrucoes = Console.ReadLine()!.ToCharArray();

            (posicaoX, posicaoY, direcao) = MoverRobo(posicaoX, posicaoY, direcao, instrucoes);

            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
            Console.ReadLine();
        }

        static (int, int, char) MoverRobo(int x, int y, char direcao, char[] instrucoes)
        {
            foreach (char instrucao in instrucoes)
            {
                switch (instrucao)
                {
                    case 'D':
                        direcao = VirarDireita(direcao);
                        break;
                    case 'E':
                        direcao = VirarEsquerda(direcao);
                        break;
                    case 'M':
                        (x, y) = Movimentar(x, y, direcao);
                        break;
                }
            }
            return (x, y, direcao);
        }

        static char VirarDireita(char direcao) => direcao switch
        {
            'N' => 'L',
            'L' => 'S',
            'S' => 'O',
            'O' => 'N',
            _ => direcao
        };

        static char VirarEsquerda(char direcao) => direcao switch
        {
            'N' => 'O',
            'O' => 'S',
            'S' => 'L',
            'L' => 'N',
            _ => direcao
        };

        static (int, int) Movimentar(int x, int y, char direcao) => direcao switch
        {
            'N' => (x, y + 1),
            'S' => (x, y - 1),
            'L' => (x + 1, y),
            'O' => (x - 1, y),
            _ => (x, y)
        };
    }
}
