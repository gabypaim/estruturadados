namespace Fsg.EstruturaDados;

public class FilaDeAtendimento
{
    private ListaSimples _senhas = new ListaSimples();

    public void EmitirSenha(int numero)
    {
        _senhas.InserirNoFinal(numero);
    }

    public int? ChamarProxima()
    {
        if (_senhas.Inicio == null)
        {
            return null;
        }
        
        int numero = _senhas.Inicio.Valor;

        _senhas.RemoverDoInicio();
        
        return numero;
    }
    
    public int QuantidadeAguardando()
    {
        return _senhas.Contar();
    }

    public void MostrarAguardando()
    {
        _senhas.Listar();
    }
}