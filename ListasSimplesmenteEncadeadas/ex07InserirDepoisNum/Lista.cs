namespace Fsg.EstruturaDados;


public class Lista
{
    public No? Inicio { get; set; }

    public void InserirNoInicio(int valor)
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

        while (Inicio == null)
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
    public No? Buscar(int valor)
    {
        No? atual = Inicio;

        while (atual != null)
        {
            if (atual.Valor == valor)
            {
                return atual;
            }

            atual = atual.Proximo;
        }
        return null;
    }
    public bool InserirDepoisDe(int valorReferencia, int novoValor)
    {
        
        if (Inicio == null) // inicio for vazio
        {
            return false; //retorna falso e acaba o metodo
        }
        
        No? atual = Inicio; //começa

        while (atual != null && atual.Valor != valorReferencia) //enquanto o atual n for nulo e atual for diferente da ref
        {
            atual = atual.Proximo; // passa para o proximo
        }

        if (atual != null) // se o atual for diff de nulo
        {
            No novoNo = new No(); // cria o no e add o valor
            novoNo.Valor = novoValor;
            
            novoNo.Proximo = atual.Proximo; // o proximo do novoNo é o proximo do atual
            atual.Proximo = novoNo; // o atual agora fica antes do novoNo
            
            return true; // retorna true
        }

        return false; // retorna false se não encontrar
    }
}
