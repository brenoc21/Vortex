using System;

namespace Vortex
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, Q, X, sum;
            Console.WriteLine("Informe o tempo restante na jogada: ");
            T = int.Parse(Console.ReadLine());
            while( 0 >= T || T > 24 ){
                Console.WriteLine("Tempo invalido, o tempo deve ter entre 1 e 24 segundos.");
                Console.WriteLine("Informe o tempo restante na jogada: ");
            T = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe quantos jogadores estão em quadra: ");
            Q = int.Parse(Console.ReadLine());
            while( Q < 2 || Q > 5 ){
                Console.WriteLine("Quantidade de jogadores inválida. Só podem haver de 2 a 5 jogadores em quadra.");
                Console.WriteLine("Informe quantos jogadores estão em quadra: ");
            Q = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe o tempo de deslocamento dos jogadores entre passes: ");
            X = int.Parse(Console.ReadLine());
            while(X <= 0 || X > Q-1 ){
                Console.WriteLine("Tempo de deslocamento inválido, o deslocamento deve ser maior que 0 e menor que o número de jogadores.");
                Console.WriteLine("Informe o tempo de deslocamento dos jogadores entre passes: ");
            X = int.Parse(Console.ReadLine());
            }
            
            sum = UltimatePlayCalculator(T,Q,X);
            Console.WriteLine("Um total de "+ sum + " estiveram livres entre as jogadas.");
        }
        static int UltimatePlayCalculator(int T, int Q, int X){
            int sum = 0;
            int C = 0;
            for(int i = Q-1; i > (Q-X); i--){
                C+= i - (Q-X);
            }
            sum = (T*(Q-X)) + C;
            return sum;
        }
    }
}
