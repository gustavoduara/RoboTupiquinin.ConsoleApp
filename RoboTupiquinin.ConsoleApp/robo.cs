namespace RoboTupiniquim
{
    public class Robo
    {
        public string nome;

        public int posicaoX;
        public int posicaoY;
        public char direcao;

        public void Explorar(char[] instrucoes)
        {
            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    VirarEsquerda();

                else if (instrucaoAtual == 'D')
                    VirarDireita();

                else if (instrucaoAtual == 'M')
                    Mover();
            }
        }

        public void Mover()
        {
            if (direcao == 'N')
                posicaoY++;

            else if (direcao == 'S')
                posicaoY--;

            else if (direcao == 'O')
                posicaoX--;

            else if (direcao == 'L')
                posicaoX++;
        }

        public void VirarEsquerda()
        {
            if (direcao == 'N')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'N';
        }

        public void VirarDireita()
        {
            if (direcao == 'N')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'N';
        }

        public string ObterLocalizacao()
        {
            return $"{posicaoX} {posicaoY} {direcao}";
        }
    }
}