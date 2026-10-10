namespace Fsg.EstruturaDados;

class Program
{
    static void Main()
    {
        Lista lista = new Lista();
        lista.InserirNoInicio(5);
        lista.InserirNoFinal(10);
        lista.Mostrar();
        
    }
}