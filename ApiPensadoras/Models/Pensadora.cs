namespace ApiPensadoras.Models;

public class Pensadora
{
    public int PensadoraId { get; set; }
    public string? Nome { get; set; }
    public string? Ocupacao { get; set; }
    public string? Nacionalidade { get; set; } 
    public DateTime DataDeNascimento { get; set; }
    public DateTime? DataDeFalecimento { get; set; } 
    public string? Descricao { get; set; }
}

