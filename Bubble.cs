using System;

public class Bubble
{
    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        comparacoes = 0;
        int n = v.Length;

        Pilha A = new Pilha(n);
        Pilha B = new Pilha(n);
        Pilha R = new Pilha(n);

        foreach (int valor in v)
        {
            A.empilha(valor);
        }

        for (int restantes = n; restantes >= 1; restantes--)
        {
            int carry = A.desempilha();

            for (int i = 1; i < restantes; i++)
            {
                int x = A.desempilha();
                comparacoes++;

                if (carry > x)
                {
                    B.empilha(x);
                }
                else
                {
                    B.empilha(carry);
                    carry = x;
                }
            }

            R.empilha(carry);

            Pilha temporaria = A;
            A = B;
            B = temporaria;
        }

        int[] resultado = new int[n];

        for (int i = 0; i < n; i++)
        {
            resultado[i] = R.desempilha();
        }

        return resultado;
    }
}