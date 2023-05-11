
public abstract class Jogador
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Nacionalidade { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }

    public abstract void ImprimirDadosDoJogador();

    public int CalcularIdade()
    {
        int idade = DateTime.Now.Year - DataNascimento.Year;
        if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
        {
            idade--;
        }
        return idade;
    }

    public abstract int TempoAposentadoria();
}
