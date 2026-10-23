public class OrdenacaoPilha
{
    public static Pilha ordenaPilha(Pilha p)
    {
        Pilha auxiliar = new Pilha(p.tamanho());

        while (!p.vazia())
        {
            int t = p.desempilha();
            while (!auxiliar.vazia() &&
                   auxiliar.consultaTopo() > t)
            {
                p.empilha(auxiliar.desempilha());
            }
            auxiliar.empilha(t);
        }
        return auxiliar;
    }
}