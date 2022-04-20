using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPensadoras.Models;


public class Pensadora
{
    public Pensadora()
    {
        Frases = new Collection<Frase>();
    }

    public int PensadoraId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(80)]
    public string? Ocupacao { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nacionalidade { get; set; }

    [StringLength(600)]
    public string? Descricao { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime DataDeNascimento { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime? DataDeFalecimento { get; set; }
    public ICollection<Frase>? Frases { get; set; }
}

