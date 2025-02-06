using System.ComponentModel.DataAnnotations;

namespace Models;

public class Ordenes
{
    [Key]
    public int Id { get; set; }

    public required string Name { get; set; }
    
    public decimal Cantidad { get; set; }

    public required string Sucursal { get; set; }
    
    public bool Activo { get; set; }
}