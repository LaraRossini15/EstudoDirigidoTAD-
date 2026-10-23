using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Parte 1: Testes da Pilha ===");

        Pilha pilha = new Pilha(5);

        pilha.empilha(10);
        pilha.empilha(20);
        pilha.empilha(30);

        Console.WriteLine("Elementos da pilha:");
        pilha.mostra();

        Console.WriteLine("Elemento do topo: " + pilha.consultaTopo());
        Console.WriteLine("Tamanho da pilha: " + pilha.tamanho());

        Console.WriteLine("Elemento removido: " + pilha.desempilha());

        Console.WriteLine("Pilha após remover o topo:");
        pilha.mostra();

        Console.WriteLine("A pilha está vazia? " + pilha.vazia());
        Console.WriteLine();
        Console.WriteLine("=== Parte 3.1: Inverter String ===");

        string texto = "Cidade Conectada";
        string textoInvertido = OperacoesPilha.inverte(texto);

        Console.WriteLine("Texto original: " + texto);
        Console.WriteLine("Texto invertido: " + textoInvertido);
        Console.WriteLine();
        Console.WriteLine("=== Parte 3.2: Verificar Balanceamento ===");

        string expressao1 = "{[()]}";
        string expressao2 = "{[(])}";

        Console.WriteLine(
            expressao1 + " -> " +
            (OperacoesPilha.balanceado(expressao1)
                ? "Balanceada"
                : "Nao balanceada")
        );

        Console.WriteLine(
            expressao2 + " -> " +
            (OperacoesPilha.balanceado(expressao2)
                ? "Balanceada"
                : "Nao balanceada")
        );

        Console.WriteLine();
        Console.WriteLine("=== Parte 4: Bubble Sort com Pilhas ===");

        int[] vetor = { 5, 2, 9, 1, 7 };

        int[] ordenado = Bubble.bubblePilhas(
            vetor,
            out int comparacoes
        );

        Console.WriteLine(
            "Vetor original: " + string.Join(", ", vetor)
        );

        Console.WriteLine(
            "Vetor ordenado: " + string.Join(", ", ordenado)
        );

        Console.WriteLine(
            "Quantidade de comparacoes: " + comparacoes
        );
        int[] vetorOrdenado = { 1, 2, 3, 4, 5 };

        int[] resultadoOrdenado = Bubble.bubblePilhas(
            vetorOrdenado,
            out int comparacoesOrdenado
        );

        Console.WriteLine();

        Console.WriteLine(
            "Vetor ja ordenado: " +
            string.Join(", ", vetorOrdenado)
        );

        Console.WriteLine(
            "Resultado: " +
            string.Join(", ", resultadoOrdenado)
        );

        Console.WriteLine(
            "Quantidade de comparacoes: " +
            comparacoesOrdenado
        );
        Console.WriteLine();
        Console.WriteLine("=== Desafio: Ordenar Pilha ===");

        Pilha pilhaDesordenada = new Pilha(5);

        pilhaDesordenada.empilha(3);
        pilhaDesordenada.empilha(1);
        pilhaDesordenada.empilha(5);
        pilhaDesordenada.empilha(2);
        pilhaDesordenada.empilha(4);

        Console.WriteLine("Pilha original (base para topo):");
        pilhaDesordenada.mostra();

        Pilha pilhaOrdenada =
            OrdenacaoPilha.ordenaPilha(pilhaDesordenada);

        Console.WriteLine("Pilha ordenada (base para topo):");
        pilhaOrdenada.mostra();

        Console.WriteLine(
            "Maior valor no topo: " +
            pilhaOrdenada.consultaTopo()
        );
    }
}