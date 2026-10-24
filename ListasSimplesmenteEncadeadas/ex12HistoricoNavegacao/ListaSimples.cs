namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio { get; set; }
    
    public void InserirNoInicio(int valor)
    {
        No novoNo = new No();
        novoNo.Valor = valor;
        novoNo.Proximo = Inicio;
        Inicio = novoNo;
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
        int quantidade = 0;
        No? atual = Inicio;

        while (atual != null)
        {
            quantidade++;
            atual = atual.Proximo;
        }

        return quantidade;
    }
}