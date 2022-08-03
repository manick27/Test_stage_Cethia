using System.ComponentModel.DataAnnotations;

namespace Projet.Views.Home;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string? Description { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public int Price { get; set; }

    public string? IdUser { get; set; }
}
