namespace JogoDeDadosConsoleApp
{
    internal partial class Program
    {
        public class JogoDosDados
        {
           public  static int ArmazenarPosicao(int posicao, int numeroGerado)
            {
                posicao = posicao + numeroGerado;
                return posicao;
            }
           public  static int GerarNumero()
            {
                Random geradorNumeros = new Random();

                int numero = geradorNumeros.Next(1, 7);
                return numero;
            }

        }
    }
}
