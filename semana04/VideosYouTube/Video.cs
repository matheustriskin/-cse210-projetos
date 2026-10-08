using System;
using System.Collections.Generic;

public class Video
{
    private string _tituloVideo;
    private string _canalAutor;
    private int _duracaoSegundos;
    private List<Comentario> _listaComentarios;

    public Video(string tituloVideo, string canalAutor, int duracaoSegundos)
    {
        _tituloVideo = tituloVideo;
        _canalAutor = canalAutor;
        _duracaoSegundos = duracaoSegundos;
        _listaComentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario novoComentario)
    {
        _listaComentarios.Add(novoComentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _listaComentarios.Count;
    }

    public string ObterTitulo()
    {
        return _tituloVideo;
    }

    public string ObterAutor()
    {
        return _canalAutor;
    }

    public int ObterDuracao()
    {
        return _duracaoSegundos;
    }

    public List<Comentario> ObterComentarios()
    {
        return _listaComentarios;
    }
}
