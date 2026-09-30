using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Testa a classe base Tarefa
        Tarefa t1 = new Tarefa("Lucas Andrade", "Geometria Básica");
        Console.WriteLine(t1.ObterResumo());
        Console.WriteLine();

        // 2. Testa a classe derivada TarefaDeMatematica
        TarefaDeMatematica t2 = new TarefaDeMatematica("Camila Duarte", "Trigonometria", "8.2", "12-25");
        Console.WriteLine(t2.ObterResumo());
        Console.WriteLine(t2.ObterListaDeTarefas());
        Console.WriteLine();

        // 3. Testa a classe derivada TarefaDeRedacao
        TarefaDeRedacao t3 = new TarefaDeRedacao("Gabriel Ferreira", "Literatura Brasileira", "A Importância de Machado de Assis");
        Console.WriteLine(t3.ObterResumo());
        Console.WriteLine(t3.ObterInformacoesDaRedacao());
    }
}
