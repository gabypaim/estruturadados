namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio { get; set; }

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

    public bool RemoverDoInicio()
    {
        if (Inicio == null)
        {
            return false;
        }
        
        Inicio = Inicio.Proximo;
        return true;
    }

    public int Contar()
    {

        No? atual = Inicio;
        int quantidade = 0;

        while (atual != null)
        {
            atual = atual.Proximo;
            quantidade++;
        }
        return  quantidade;
    }
    
    public void Listar()
    {
        No? atual = Inicio;

        while (atual != null)
        {
            Console.WriteLine($"* {atual.Valor}");
            atual = atual.Proximo;
        }
    }
}