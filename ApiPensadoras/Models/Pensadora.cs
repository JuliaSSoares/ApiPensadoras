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

    [StringLength(300)]
    public string? Descricao { get; set; }

    public DateTime DataDeNascimento { get; set; }
    public DateTime? DataDeFalecimento { get; set; }
    public ICollection<Frase>? Frases { get; set; }
}

