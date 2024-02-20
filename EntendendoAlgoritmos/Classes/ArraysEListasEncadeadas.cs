using System.Text;

namespace EntendendoAlgoritmos.Classes;
public class ArraysEListasEncadeadas
{
    public static int BuscaMenor(List<int> lista)
    {
        int menor = lista[0];
        int menorIndice = 0;

        foreach (int i in Enumerable.Range(1, lista.Count - 1))
        {
            if (lista[i] < menor)
            {
                menor = lista[i];
                menorIndice = i;
            }
        }

        return menorIndice;
    }

    public static List<int> OrdenacaoPorSelecao(List<int> lista)
    {
        List<int> result = [];

        foreach (int i in Enumerable.Range(1, lista.Count))
        {
            int menor = BuscaMenor(lista);
            result.Add(lista[menor]);
            lista.RemoveAt(menor);
        }

        return result;
    }
}
