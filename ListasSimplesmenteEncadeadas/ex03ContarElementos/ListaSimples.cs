namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio {  get; set; }

    public void InseriorNoInicio(int valor)
    {
        No novoNo = new No();

        novoNo.Valor = valor;
        novoNo.Proximo = Inicio;

        Inicio = novoNo;
    }

    public void InserirNoFinal(int valor)
    {
        No novoNo = new No();

        novoNo.Valor = valor;
        novoNo.Proximo = null;

       if (Inicio == null)
       {
            Inicio = novoNo;
            return;
       }

        No? atual = Inicio;

        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }

        atual.Proximo = novoNo;
    }

    public int Contar()
    {
        No? atual = Inicio;
        int quantidade = 0;
        
        while (atual != null)
        {
            quantidade++;
            atual = atual.Proximo;
        }

        return quantidade;
    }

    public void Mostrar()
    {
        No? atual = Inicio;

        while (atual != null)
        {
            Console.WriteLine(atual.Valor);
            atual = atual.Proximo;
        }
    }
}
