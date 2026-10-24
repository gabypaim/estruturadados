namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio  { get; set; }
    
    public void InserirOrdenadoDecrescente(int pontuacao)
    {
        No novoNo = new No();
        novoNo.Valor = pontuacao;

        if (Inicio == null || pontuacao > Inicio.Valor)
        {
            novoNo.Proximo = Inicio;
            Inicio = novoNo;
            return;
        }

        No atual = Inicio;

        while (atual.Proximo != null &&
               atual.Proximo.Valor >= pontuacao)
        {
            atual = atual.Proximo;
        }

        novoNo.Proximo = atual.Proximo;
        atual.Proximo = novoNo;
    }
    
    
    public void ExibirTop(int n)
    {
        No? atual = Inicio;
        int quantidade = 0;

        while (atual != null && quantidade < n)
        {
            Console.Write(atual.Valor + " ");

            atual = atual.Proximo;
            quantidade++;
        }

        Console.WriteLine();
    }


}