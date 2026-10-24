namespace Fsg.EstruturaDados;

public class ListaSimples
{
    public No? Inicio { get; set; }
    
    public void RemoverDuplicados()
    {
        No? atual = Inicio;

        while (atual != null)
        {
            No? anterior = atual;
            No? comparado = atual.Proximo;

            while (comparado != null)
            {
                if (atual.Valor == comparado.Valor)
                {
                    anterior.Proximo = comparado.Proximo;
                    comparado = anterior.Proximo;
                }
                else
                {
                    anterior = comparado;
                    comparado = comparado.Proximo;
                }
            }

            atual = atual.Proximo;
        }
        
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

        No atual = Inicio;

        while (atual.Proximo != null)
        {
            atual = atual.Proximo;
        }

        atual.Proximo = novoNo;
    }
}