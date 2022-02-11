using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pontoInicial = new string[3];
            char[] separador = { ' ', ','};
            int posicaoX, posicaoY;
            char coordenadaAtual;

            for (int i = 0; i < 2; i++)
            {
            Console.WriteLine("Digite a posição inicial (X, Y) do robô e sua coordenadoa (N, S, L, O): (ex: 1 3 N)" );
            pontoInicial = Console.ReadLine().Split(separador, StringSplitOptions.RemoveEmptyEntries);

            posicaoX = Convert.ToInt32(pontoInicial[0]);
            posicaoY = Convert.ToInt32(pontoInicial[1]);
            coordenadaAtual = Convert.ToChar(pontoInicial[2].ToUpper());
            
            Console.WriteLine("Digite as instrições do robo: ");
            char[] vetorInstrucoes = Console.ReadLine().ToUpper().ToCharArray();

            for (int j = 0; j < vetorInstrucoes.Length; j++)
            {
                char instrucao = vetorInstrucoes[j];
                switch (instrucao)
                {
                    case 'E':
                        switch (coordenadaAtual)
                        {
                            case 'N':
                                coordenadaAtual = 'O';
                                break;
                            case 'S':
                                coordenadaAtual = 'L';
                                break;
                            case 'L':
                                coordenadaAtual = 'N';
                                break;
                            case 'O':
                                coordenadaAtual = 'S';
                                break;
                        }
                        break;
                    case 'D':
                        switch (coordenadaAtual)
                        {
                            case 'N':
                                coordenadaAtual= 'L';
                                break;
                            case 'S':
                                coordenadaAtual = 'O';
                                break;
                            case 'L':
                                coordenadaAtual = 'S';
                                break;
                            case 'O':
                                coordenadaAtual = 'N';
                                break;
                        }
                        break;
                    case 'M':
                        switch (coordenadaAtual)
                        {
                            case 'N':
                                posicaoY++;
                                break;
                            case 'S':
                                posicaoY--;
                                break;
                            case 'L':
                                posicaoX++;
                                break;
                            case 'O':
                                posicaoX--; 
                                break;

                            default:
                                break;
                        }
                        break;
                }

             }
                Console.WriteLine("{0} {1} {2}", posicaoX, posicaoY, coordenadaAtual);
            }
            Console.ReadKey();  
        }
    }
}
