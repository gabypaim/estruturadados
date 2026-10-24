namespace Fsg.EstruturaDados;


public class HistoricoNavegacao
{
    private ListaSimples _paginas = new ListaSimples();

    public void Visitar(int idPagina)
    {
        _paginas.InserirNoInicio(idPagina);
    }

    public int? PaginaAtual()
    {
        if (_paginas.Inicio == null)
        {
            return null;
        }

        return _paginas.Inicio.Valor;
    }

    public int? Voltar()
    {
        if (_paginas.Inicio == null ||
            _paginas.Inicio.Proximo == null)
        {
            return null;
        }

        _paginas.RemoverDoInicio();

        return _paginas.Inicio.Valor;
    }
}
