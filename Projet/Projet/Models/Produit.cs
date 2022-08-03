using System.ComponentModel.DataAnnotations;

namespace Projet.Views.Home;

public class Produit
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Brand { get; set; }

    [Required]
    public int Quantity { get; set; }

    public string? Description { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public int Price { get; set; }

    public string? IdUser { get; set; }
}
