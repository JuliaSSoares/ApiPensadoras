using System.ComponentModel.DataAnnotations;

namespace ApiPensadoras.Models;

public class Frase
{
    public int FraseId { get; set; }

    [Required]
    [MaxLength(300)]
    public string? ConteudoFrase { get; set; }

    public DateTime? DataPublicacao { get; set; }
    public Pensadora? Pensadora { get; set; }
    public int PensadoraId { get; set; }

}

