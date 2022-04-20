using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPensadoras.Models;

public class Frase
{
    public int FraseId { get; set; }

    [Required]
    [MaxLength(600)]
    public string? ConteudoFrase { get; set; }
    public Pensadora? Pensadora { get; set; }
    public int PensadoraId { get; set; }

}

