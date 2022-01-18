using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main (string[] args)
        {
        //ORDENANDO ARRAY
        OperacoesArray op = new OperacoesArray();
        int []array = new int [5]{6,3,8,9,2};
        int []arrayCopia = new int [10];//para copia os valores do array anterior

        //System.Console.WriteLine("Array original:");
        //op.ImprimirArray(array);
        //op.OrdenarBubleSort(ref array);
        //op.Ordenar(ref array);
        
        //System.Console.WriteLine("Array Ordenado:");
        //op.ImprimirArray(array);

        System.Console.WriteLine("Array antes da copia:");
        op.ImprimirArray(arrayCopia);

        op.Copíar (ref array, ref arrayCopia);
        System.Console.WriteLine("Array após a copia:");
        op.ImprimirArray(arrayCopia);

        //criando um array
        //     int [,] matriz = new int[4,2]
        //     {
        //         {8,8},
        //         {10,20},
        //         {50,100},
        //         {90,200}
        //     };
          
        //    for (int i = 0; i < matriz.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matriz.GetLength(1); j++)
        //        {
        //            System.Console.WriteLine(matriz[i,j]);
        //        }
        //    }
            // int []arrayInteiros =new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("percorrendo o array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {

            //     System.Console.WriteLine(arrayInteiros[i]);
            // }
            //  System.Console.WriteLine("percorrendo o array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}