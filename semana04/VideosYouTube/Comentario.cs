using System;

public class Comentario
{
    private string _autorComentario;
    private string _conteudoTexto;

    public Comentario(string autorComentario, string conteudoTexto)
    {
        _autorComentario = autorComentario;
        _conteudoTexto = conteudoTexto;
    }

    public string ObterAutor()
    {
        return _autorComentario;
    }

    public string ObterConteudo()
    {
        return _conteudoTexto;
    }
}
