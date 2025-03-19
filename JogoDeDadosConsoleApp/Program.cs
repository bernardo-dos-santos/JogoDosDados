namespace JogoDeDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoJogador = 0;
            int linhaDeChegada = 30;
            int posicaoComputador = 0;
            bool jogador;
            bool jogoAcabou;
            while (true)
            {

                

                int numeroJogador = Jogar(jogador = true);
                posicaoJogador = ArmazenarPosicao(posicaoJogador, numeroJogador);
                MostrarPosicao(posicaoJogador, linhaDeChegada, jogador = true);

                int numeroComputador = Jogar(jogador = false);
                posicaoJogador = ArmazenarPosicao(posicaoComputador, numeroComputador);
                MostrarPosicao(posicaoComputador, linhaDeChegada, jogador = false);

                jogoAcabou = GanhouOuNao(posicaoJogador, posicaoComputador, linhaDeChegada);

                if (jogoAcabou)
                {
                    Console.WriteLine("Deseja Continuar? (s/n)");
                    string continuar = Console.ReadLine()!.ToUpper();
                    if (continuar != "S")
                        break;
                }


            }

        }

        static void ExibirCabecalho()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Regras do Jogo: ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("O jogo será uma corrida entre você e o computador");
            Console.WriteLine("Seu Objetivo é chegar na casa 30");
            Console.WriteLine("Nas Casas 5, 10 ,15 e 20, você terá um bônus de +3 casas");
            Console.WriteLine("Nas Casas 8, 13 ,18 e 21, você terá um ônus de -2 casas");
            Console.WriteLine("--------------------------------------");
        }
        static int Jogar(bool jogador)
        {
            int numero;
            if (jogador)
            {
                Console.WriteLine("Agora é sua vez, pressione Enter para jogar");
                Console.ReadLine();

                numero = GerarNumero();

                Console.WriteLine($"O Numero sorteado foi {numero}");
            }
            else
            {
                Console.WriteLine("Agora é a vez do computador, pressione Enter para ver");
                Console.ReadLine();

                numero = GerarNumero();

                Console.WriteLine($"O Numero sorteado foi {numero}");
            }
            return numero;
        }

        static int ArmazenarPosicao(int posicao, int numeroGerado)
        {
            posicao = posicao + numeroGerado;
            return posicao;
        }

        static void MostrarPosicao(int posicaoAtual, int linhaDeChegada, bool Jogador)
        {
            if (Jogador)
                Console.WriteLine($"Sua Posição é {posicaoAtual} de {linhaDeChegada}");
            else
                Console.WriteLine($"A posição do Computador é {posicaoAtual} de {linhaDeChegada}");
        }

        static int GerarNumero()
        {
            Random geradorNumeros = new Random();

            int numero = geradorNumeros.Next(1, 7);
            return numero;
        }

        static bool GanhouOuNao(int posicaoJogador, int posicaoComputador, int linhaDeChegada)
        {
            if (posicaoJogador >= linhaDeChegada)
            {
                Console.WriteLine("Parabéns, Você ganhou a Corrida!!");
                return true;
            }
            else if (posicaoComputador >= linhaDeChegada)
            {
                Console.WriteLine("Que Pena, O computador venceu a corrida, tente novamente!!");
                return true;
            }
            return false;
        }
    }
}
