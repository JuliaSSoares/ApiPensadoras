namespace ApiPensadoras.Models;

public class Frase
{
    public int FraseId { get; set; }
    public string? ConteudoFrase { get; set; }
    public DateTime? DataPublicacao { get; set; }
    public int PensadoraID { get; set; }   
    public Pensadora? Pensadora { get; set; }   
}

