
using System;
public class OperacoesPilha{
    public static string inverte(string s){
        Pilha p = new Pilha(s.Length);
        foreach (char c in s){
            p.empilha(c);
        }
        string resultado = "";

        while (!p.vazia()){
            resultado += (char)p.desempilha();
        }

        return resultado;
    }
    public static bool balanceado(string expr){
        Pilha p = new Pilha(expr.Length);

        foreach (char c in expr){
            if (c == '(' || c == '[' || c == '{'){
                p.empilha(c);
            }
            else if (c == ')' || c == ']' || c == '}'){
                if (p.vazia()){
                    return false;
                }

                char abertura = (char)p.desempilha();

                if (c == ')' && abertura != '('){
                    return false;
                }

                if (c == ']' && abertura != '['){
                    return false;
                }

                if (c == '}' && abertura != '{'){
                    return false;
                }
            }
        }
        return p.vazia();
    }
}
