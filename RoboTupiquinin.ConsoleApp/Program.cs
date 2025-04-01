namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posicoesIniciais = ["1 2 N", "3 3 L"];
            string[] comandosIniciais = ["EMEMEMEMM", "MMDMMDMDDM"];

            string[] nomesRobos = ["Gabriel", "Leonardo"];

            int quantidadeRobos = 2;

            Robo[] robos = new Robo[quantidadeRobos];

            for (int contador = 0; contador < robos.Length; contador++)
            {
                string[] coordenadasAtuais = posicoesIniciais[contador].Split(' ');

                Robo robo = new Robo();

                robo.nome = nomesRobos[contador];
                robo.posicaoX = Convert.ToInt32(coordenadasAtuais[0]);
                robo.posicaoY = Convert.ToInt32(coordenadasAtuais[1]);
                robo.direcao = Convert.ToChar(coordenadasAtuais[2]);

                char[] instrucoes = comandosIniciais[contador].ToCharArray();

                robo.Explorar(instrucoes);

                robos[contador] = robo;
            }

            foreach (Robo robo in robos)
                Console.WriteLine(robo.ObterLocalizacao());

            Console.ReadLine();
        }
    }
}