namespace JogoDeDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                int posicaoJogador = 0;
                int linhaDeChegada = 30;
                int posicaoComputador = 0;
                bool jogador;
                bool jogoAcabou;

                ExibirCabecalho();

                while (jogoAcabou = false)
                {

                
                int numeroJogador = Jogar(jogador = true);
                posicaoJogador = ArmazenarPosicao(posicaoJogador, numeroJogador);
                MostrarPosicao(posicaoJogador, linhaDeChegada, jogador = true);
                posicaoJogador = BonusOuNao(posicaoJogador, jogador = true);

                int numeroComputador = Jogar(jogador = false);
                posicaoComputador = ArmazenarPosicao(posicaoComputador, numeroComputador);
                MostrarPosicao(posicaoComputador, linhaDeChegada, jogador = false);
                posicaoComputador = BonusOuNao(posicaoComputador, jogador = false);

                jogoAcabou = GanhouOuNao(posicaoJogador, posicaoComputador, linhaDeChegada);
                }
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
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Agora é sua vez, pressione Enter para jogar");
                Console.WriteLine("--------------------------------------");
                Console.ReadLine();

                numero = GerarNumero();

                Console.WriteLine($"O Numero sorteado foi {numero}");
                Console.WriteLine("--------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Agora é a vez do computador, pressione Enter para ver");
                Console.WriteLine("--------------------------------------");
                Console.ReadLine();

                numero = GerarNumero();

                Console.WriteLine($"O Numero sorteado foi {numero}");
                Console.WriteLine("--------------------------------------");
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
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Sua Posição é {posicaoAtual} de {linhaDeChegada}");
                Console.WriteLine("--------------------------------------");
                Console.ReadLine();
            }               
            else
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"A posição do Computador é {posicaoAtual} de {linhaDeChegada}");
                Console.WriteLine("--------------------------------------");
                Console.ReadLine();
            }
                
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
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Parabéns, Você ganhou a Corrida!!");
                Console.WriteLine("--------------------------------------");
                return true;
            }
            else if (posicaoComputador >= linhaDeChegada)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Que Pena, O computador venceu a corrida, tente novamente!!");
                Console.WriteLine("--------------------------------------");
                return true;
            } else
             return false;
            
            
        }

        static int BonusOuNao(int posicao, bool jogador)
        {
            if(jogador)
            {
                if (posicao == 10 || posicao == 15 || posicao == 20 || posicao == 5)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"Que sorte, você ganhou um bônus de 3 casas devido estar na casa {posicao}");
                    Console.WriteLine($"Antes sua posição era {posicao}");
                    posicao = posicao + 3;
                    Console.WriteLine($"Agora sua posição é {posicao}");
                    Console.WriteLine("--------------------------------------");
                    Console.ReadLine();
                } else if (posicao == 8 || posicao == 13 || posicao == 18 || posicao == 21)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"Que azar, você ganhou um ônus de 2 casas devido estar na casa {posicao}");
                    Console.WriteLine($"Antes sua posição era {posicao}");
                    posicao = posicao - 2;
                    Console.WriteLine($"Agora sua posição é {posicao}");
                    Console.WriteLine("--------------------------------------");
                    Console.ReadLine();
                }
            } else
            {
                if (posicao == 10 || posicao == 15 || posicao == 20 || posicao == 5)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"Que azar, o computador ganhou um bônus de 3 casas devido estar na casa {posicao}");
                    Console.WriteLine($"Antes a posição dele era {posicao}");
                    posicao = posicao + 3;
                    Console.WriteLine($"Agora a posição dele é {posicao}");
                    Console.WriteLine("--------------------------------------");
                    Console.ReadLine();
                }
                else if (posicao == 8 || posicao == 13 || posicao == 18 || posicao == 21)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"Que sorte, o computador ganhou um ônus de 2 casas devido estar na casa {posicao}");
                    Console.WriteLine($"Antes a posição dele era {posicao}");
                    posicao = posicao - 2;
                    Console.WriteLine($"Agora a posição dele é {posicao}");
                    Console.WriteLine("--------------------------------------");
                    Console.ReadLine();
                }
            }
            return posicao;

        }
    }
}
