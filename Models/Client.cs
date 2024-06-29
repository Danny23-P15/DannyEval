using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace gasimmoeval.Models;
[Table("client")]
public class Client
{
    [Key]
    [Column("id")]
    public string? Id { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("nom")]
    public string? Nom { get; set; }

}