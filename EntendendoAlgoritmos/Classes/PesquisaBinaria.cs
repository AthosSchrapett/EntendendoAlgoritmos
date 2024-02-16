namespace EntendendoAlgoritmos.Classes;
public class PesquisaBinaria
{
    public static string Pesquisa(int[] lista, int item)
    {
        int baixo = 0;
        int alto = lista.Length - 1;

        while (baixo <= alto)
        {
            int meio = (baixo + alto) / 2;
            int chute = lista[meio];

            if (chute == item)
                return $"Nº {item} encontrado";
            else if (chute > item)
                alto = meio - 1;
            else
                baixo = meio + 1;
        }

        return $"Nº {item} não encontrado";
    }
}
