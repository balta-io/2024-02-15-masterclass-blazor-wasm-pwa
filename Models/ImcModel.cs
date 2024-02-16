using System.ComponentModel.DataAnnotations;

namespace Imc.Models;

public class ImcModel
{
    [Required(ErrorMessage = "Informe a altura")]
    [Range(1, 3, ErrorMessage = "Altura inválida")]
    public double? Height { get; set; }

    [Required(ErrorMessage = "Informe o peso")]
    [Range(15, 180, ErrorMessage = "Peso inválido")]
    public double? Weight { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public double Imc => (Weight ?? 1) / ((Height ?? 1) * (Height ?? 1));
}