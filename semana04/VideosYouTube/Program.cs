using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Vídeo 1
        Video video1 = new Video("Guia Completo de Git e GitHub para Iniciantes", "Código Eficiente", 780);
        video1.AdicionarComentario(new Comentario("Mariana Silva", "Excelente explicação sobre branches e merge, salvou meu semestre!"));
        video1.AdicionarComentario(new Comentario("Felipe Costa", "Direto ao ponto e sem enrolação, parabéns pelo conteúdo."));
        video1.AdicionarComentario(new Comentario("Aline Duarte", "Você usa qual tema no terminal? Ficou muito bonito e legível."));
        video1.AdicionarComentario(new Comentario("Rodrigo Santos", "Finalmente entendi a diferença entre git fetch e git pull!"));
        videos.Add(video1);

        // Vídeo 2
        Video video2 = new Video("Como Montar um Setup Minimalista e Produtivo", "Tech & Design", 950);
        video2.AdicionarComentario(new Comentario("Lucas Ferreira", "A organização dos cabos embaixo da mesa ficou impecável!"));
        video2.AdicionarComentario(new Comentario("Beatriz Lima", "Onde você comprou esse suporte ergonômico de madeira para o teclado?"));
        video2.AdicionarComentario(new Comentario("Gustavo Henrique", "Inspirador! Vou aplicar essa iluminação indireta no meu quarto hoje mesmo."));
        videos.Add(video2);

        // Vídeo 3
        Video video3 = new Video("Receita de Pão Artesanal de Fermentação Natural", "Padaria em Casa", 1120);
        video3.AdicionarComentario(new Comentario("Cláudia Ramos", "A casca ficou super crocante seguindo a dica da panela de ferro."));
        video3.AdicionarComentario(new Comentario("Thiago Mendes", "Qual a hidratação ideal para utilizar com farinhas nacionais?"));
        video3.AdicionarComentario(new Comentario("Juliana Castro", "Melhor tutorial que já assisti, meu primeiro levain deu super certo!"));
        video3.AdicionarComentario(new Comentario("Renato Moreira", "Vídeo terapêutico e receita muito bem detalhada, nota 10!"));
        videos.Add(video3);

        // Vídeo 4
        Video video4 = new Video("Dicas Essenciais de Fotografia com Smartphone", "Olhar Criativo", 620);
        video4.AdicionarComentario(new Comentario("Larissa Souza", "A regra dos terços e o uso da luz natural transformaram minhas fotos."));
        video4.AdicionarComentario(new Comentario("Eduardo Paiva", "Sensacional a dica sobre travar o foco e ajustar a exposição manual."));
        video4.AdicionarComentario(new Comentario("Camila Nogueira", "Adorei a parte de edição rápida sem precisar de aplicativos pagos!"));
        videos.Add(video4);

        // Exibir cada vídeo da lista
        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Título:                {video.ObterTitulo()}");
            Console.WriteLine($"Autor:                 {video.ObterAutor()}");
            Console.WriteLine($"Duração:               {video.ObterDuracao()} segundos");
            Console.WriteLine($"Número de comentários: {video.ObterQuantidadeComentarios()}");
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine($"  - {comentario.ObterAutor()}: \"{comentario.ObterConteudo()}\"");
            }

            Console.WriteLine();
        }
    }
}