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
}

