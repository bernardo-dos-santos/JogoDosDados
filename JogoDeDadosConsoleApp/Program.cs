namespace JogoDeDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posicaoJogador = 0;
            int linhaDeChegada = 30;
            while (true)
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

                Console.WriteLine("Agora é sua vez, pressione Enter para jogar");
                Console.ReadLine();

                Random geradorNumeros = new Random();

                int numeroJogador = geradorNumeros.Next(1, 7);

                Console.WriteLine($"O Numero sorteado foi {numeroJogador}");
                posicaoJogador = posicaoJogador + numeroJogador;

                Console.WriteLine($"Sua Posição é  {posicaoJogador} de {linhaDeChegada}");





            }
            
        }
    }
}
