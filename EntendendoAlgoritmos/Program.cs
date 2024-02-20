using EntendendoAlgoritmos.Classes;

List<int> lista = [1, 3, 5, 7, 9];
List<int> listaDesordenada = [5, 3, 6, 2, 10];

//Console.WriteLine(PesquisaBinaria.Pesquisa(lista, 3));
//Console.WriteLine(PesquisaBinaria.Pesquisa(lista, -1));

Console.WriteLine(string.Join(',', ArraysEListasEncadeadas.OrdenacaoPorSelecao(listaDesordenada)));
