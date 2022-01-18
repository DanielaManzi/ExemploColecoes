namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubleSort (ref int[] array)
        {
            int temp =0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if (array[j]> array[j+1])//comparar se "j" é maior que o proximo (j+1 =seguinte)
                    {
                        temp = array [j+1]; //entao TEMPORARIA RECEBE O VALOR DE "J+1"
                        array [j+1] = array [j]; //posicao que ele esta ele recebera a posicao atual do array (no lugar que estava j+1)
                        array[j] = temp;//o array passa a recebe o valor da variavel temporaria, para não perder o valor.
                    }
                }
            }
        }
        public void ImprimirArray (int[]array)
        {
            var linha = string.Join(", ", array);
            //for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(linha);
                //System.Console.WriteLine(array[i]);
            }
        }
        public void Ordenar (ref int []array)
        {
            Array.Sort(array); 
        }
        public void Copíar (ref int []array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }
    }
}