using System.ComponentModel.DataAnnotations;

namespace Models;

public class Productos
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}