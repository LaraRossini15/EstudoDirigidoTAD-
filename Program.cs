
using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("=== Parte 1: Pilha ===");
        Pilha p = new Pilha(5);
        p.empilha(1);
        p.empilha(3);
        p.empilha(5);
        p.empilha(7);
        p.mostra();

        Console.WriteLine(p.desempilha());
        Console.WriteLine(p.consultaTopo());

        p.empilha(8);
        p.empilha(9);
        p.mostra();

        Console.WriteLine(p.cheia());
        try{
            p.empilha(2);
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("\n=== Parte 3.1: Inverter texto ===");
        Console.WriteLine(OperacoesPilha.inverte("PUCMINAS"));
        Console.WriteLine("\n=== Parte 3.2: Balanceamento ===");
        Console.WriteLine(OperacoesPilha.balanceado("(a+b)*[c-d]"));
        Console.WriteLine(OperacoesPilha.balanceado("{[()]}"));
        Console.WriteLine(OperacoesPilha.balanceado("((a)"));
        Console.WriteLine(OperacoesPilha.balanceado("a+b)"));
        Console.WriteLine(OperacoesPilha.balanceado("([)]"));
    }
}
