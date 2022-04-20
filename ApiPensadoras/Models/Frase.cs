using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPensadoras.Models;

public class Frase
{
    public int FraseId { get; set; }

    [Required]
    [MaxLength(600)]
    public string? ConteudoFrase { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime? DataPublicacao { get; set; }
    public Pensadora? Pensadora { get; set; }
    public int PensadoraId { get; set; }

}

