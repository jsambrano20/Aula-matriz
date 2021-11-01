using System;

namespace Aulamatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] mat = new int[5, 5];*/ //Primeiro linha depois - Colunas 8*inicia em 0*


            //int i, j;
            //int[,] a = new int[3, 4];
            //for (i = 0; i < 3; i++)//linha
            //{
            //    for (j = 0; j < 4; j++)//coluna
            //    {
            //        Console.WriteLine("Digite o elemtno [" + i + "," + j + "]");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 3; i++)//linha
            //{
            //    for (j = 0; j < 4; j++)//coluna
            //    {
            //        Console.Write(a[i,j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //EXERC
            //int i, j, soma=0;
            //int[,] a = new int[4, 4];

            //for (i = 0; i < 4; i++)//linha
            //{
            //    for (j = 0; j < 4; j++)//coluna
            //    {
            //        Console.WriteLine("Digite o elemtno [" + i + "," + j + "]");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //    for (i = 0; i < 4; i++)
            //{
            //    for ( j = 0; j < 4; j++)
            //    {
            //        soma += a[i, j];


            //    }
            //    Console.Write(a[i, j] + " ");
            //}

            //EXERC1
            //int i, j;
            //int[,] a = new int[4, 3];
            //for (i = 0; i < 4; i++)//linha
            //{
            //    for (j = 0; j < 3; j++)//coluna
            //    {
            //        Console.WriteLine("Digite o elemtno [" + i + "," + j + "]");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 4; i++)//linha
            //{
            //    for (j = 0; j < 3; j++)//coluna
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write(a[i, j] + " ");
            //        }
            //    }
            //}
            //for (i = 0; i < 4; i++)//linha
            //{
            //    for (j = 0; j < 3; j++)//coluna
            //    {
            //        if (j == 1)
            //        {
            //            a[i, j] = a[i, j] * 2;
            //        }
            //        if (i == 2)
            //        {
            //            a[i, j] = a[i, j] * 2;
            //        }

            //    }


            //}
            //for (i = 0; i < 4; i++)//linha
            //{
            //    for (j = 0; j < 3; j++)//coluna
            //    {


            //        Console.WriteLine(a[i,j] + " ");

            //    }
            //}

            //exerc
            //int i, j;
            //int[,] a = new int[3, 3];
            //for (i = 0; i < 3; i++)//linha
            //{
            //    for (j = 0; j < 3; j++)//coluna
            //    {
            //        a[i, j] = i * j;
            //    }
            //}
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        if (i == j)
            //            Console.WriteLine("LINHA =  "+ i +"COLUNA = "+ j + " "+ a[i,j]);
            //    }
            //}

            //EXERC
            //int i, j, somap = 0, somas = 0;
            //int[,] a = new int[3, 3];
            //for (i = 0; i < 3; i++)//linha
            //{
            //    for (j = 0; j < 3; j++)//coluna
            //    {
            //        a[i, j] = i * j;
            //    }
            //}
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        if (i == j)
            //        {
            //            somap += a[i, j];
            //        }
            //        if (i + j == 2)
            //        {
            //            somas += a[i, j];
            //        }
            //    }
            //}
            //  if(somas==somap)
            //    Console.WriteLine("SOMAS IGUAIS");
            //  else
            //    Console.WriteLine("Somas não iguais");



            ////EXER
            ////Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos
            ////da diagonal principal(da esquerda para a direita) são os mesmos da diagonal
            ////secundária(direita pra esquerda).

            //int i, j, c = 0;
            //int[,] a = new int[5, 5];
            //int[] p = new int[5];
            //int[] s = new int[5];
            //for (i = 0; i < 5; i++)//linha
            //{
            //    for (j = 0; j < 5; j++)//coluna
            //        a[i, j] = int.Parse(Console.ReadLine());

            //}
            //for (i = 0; i < 5; i++)//linha{
            //{
            //    for (j = 0; j < 5; j++)

            //        if (i == j)
            //        {
            //            p[c] = a[i, j];
            //        }
            //    if ((i + j) == 4)
            //    {
            //        s[c] = a[i, j];
            //    }
            //}

            //for (j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(p[i]);
            //    Console.WriteLine(s[i]);
            //    if (p[i] == s[j])
            //        c++;
            //}

            //if (c == 5)
            //    Console.WriteLine("elementos dp e ds iguais");
            //else
            //    Console.WriteLine("diferentes");



            //Escreva um algoritmo para transpor uma matriz 3x4
            //    para outra 4x3.Transpor uma matriz significa
            //    transformar suas linhas em colunas e vice - versa.

            //int[,] matriz = new int[3, 4];
            //int i, j;
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)//coluna
            //    {
            //        Console.WriteLine("Digite o elemtno [" + i + "," + j + "]");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j] + " ");


            //    }
            //    Console.WriteLine();
            //}
            //for (i = 0; i < 4; i++)
            //{ 
            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.Write(" " + matriz[j, i] + " ");


            //    }
            //    Console.WriteLine();
            //}


            int gg, gi, cont=0, cont1=0, cont2=0, cont3=0, resultado;

            Console.WriteLine("Numeros de gols do grêmio");
            gg = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Numeros de gols do inter");
            gi = int.Parse(Console.ReadLine());

            if (gg>gi)  
            {
                Console.WriteLine("Gremio vencedor");
                cont1 = cont1 + 1;
            }
            if (gi>gg)
            {
                Console.WriteLine("Inter vencedor ");
                cont2 = cont2 + 1;

            }
            else
            {
                Console.WriteLine("Empate");
                cont3 = cont3 + 1;
            }

            cont = cont + 1;
            Console.WriteLine(" Novo Grenal 1.SIM 2.NÃO? ");
            resultado = int.Parse(Console.ReadLine());

            if (resultado == 1 )
            {
                Console.WriteLine("Grenais: " + cont);
                Console.WriteLine("Numeros de vitorias inter: " + cont2);
                Console.WriteLine("Numeros de vitorias gremio: " + cont1);
                Console.WriteLine("Numeros de empate foi: " + cont3);
                if (cont2>cont1)
                {
                    Console.WriteLine("Inter venceu mais: ");
                }
                else if (cont1>cont2)
                {
                    Console.WriteLine("Gremio venceu mais: ");

                }
                else
                {
                    Console.WriteLine("Sem vencedor ");
                }

            }
            else if (resultado == 2)
            {
                Console.WriteLine("Encerrado ");
            }



        }
    }
}



















