using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace gasimmoeval.Models;
[Table("proprietaire")]
public class Proprietaire
{
    [Key]
    [Column("id")]
    public string? Id { get; set; }

    [Column("nom")]
    public string? Nom { get; set; }

    [Column("numero")]
    public string? Numero { get; set; }
}