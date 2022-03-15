using System;

namespace MatrizEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite M e N da matriz m x n");
            string[] a = Console.ReadLine().Split(" ");
            int m = int.Parse(a[0]);
            int n = int.Parse(a[1]);
            
            int[,] matriz = new int[m, n];
            for (int i = 0; i<m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');// leitura dos dados separados por espaço
                for (int j=0; j<n;j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            int x, count = 0 ;
       
            x = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i,j] == x)
                    { 
                        count++;
                        if (i > 0)
                        {
                            Console.WriteLine(matriz[i - 1, j]);
                        } //linha de cima 
                        if (i < m - 1 )
                        {
                            Console.WriteLine(matriz[i + 1, j]); //de baixo
                        }
                        if (j < n - 1)//menor q m (colunas)
                        {
                            Console.WriteLine(matriz[i, j + 1]);//direita
                        }
                        if (j > 0) 
                        {
                            Console.WriteLine(matriz[i, j - 1]);//esquerda
                        }
                    }
                }
            }

        }

        
    }
}