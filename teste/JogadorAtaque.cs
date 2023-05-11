

public class JogadorAtaque : Jogador
{
    public override void ImprimirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Nacionalidade: {Nacionalidade}");
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Peso: {Peso}");
    }

    public override int TempoAposentadoria()
    {
        int idade = CalcularIdade();
        int tempoParaAposentadoria = 35 - idade;
        return tempoParaAposentadoria;
    }
}
