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
    
    public No? Buscar(int valor)
    {
        if (Inicio == null)
        {
            return null;
        }

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
    
    public void Remover(int valor)
    {
        if (Inicio == null) 
        {
            return;
        }

        if (Inicio.Valor == valor) 
        {
            Inicio = Inicio.Proximo; 
            return; 
        }
        
        No? anterior = null;
        No? atual =  Inicio;

        while (atual != null && atual.Valor != valor)
        {
            anterior = atual; 
            atual = atual.Proximo; 
        }

        if (atual == null)
        {
            return; 
        }
        
        anterior!.Proximo = atual.Proximo; 
    }
    
    public void Mostrar()
    {
        No? atual = Inicio; 

        while (atual != null) 
        {
            Console.WriteLine($"* {atual.Valor}");
            atual = atual.Proximo;
        }
    }
}