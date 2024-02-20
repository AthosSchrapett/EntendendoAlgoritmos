namespace EntendendoAlgoritmos.Classes;
public class ArraysEListasEncadeadas
{
    public static int BuscaMenor(int[] arr)
    {
        int menor = arr[0];
        int menorIndice = 0;

        foreach (int i in Enumerable.Range(1, arr.Length - 1))
        {
            if (arr[i] < menor)
            {
                menor = arr[i];
                menorIndice = i;
            }
        }

        return menorIndice;
    }
}
