using System;

public class MetaEterna : Meta
{
    public MetaEterna(string nome, string descricao, int pontos) : base(nome, descricao, pontos)
    {
    }

    public override void RegistrarEvento()
    {
        // Metas eternas nunca são concluídas permanentemente,
        // apenas continuam pontuando a cada registro.
    }

    public override bool EstaConcluida()
    {
        return false;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaEterna:{_nome},{_descricao},{_pontos}";
    }
}
