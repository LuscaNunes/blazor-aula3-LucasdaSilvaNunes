namespace AulaApp1.Components.Models;
using System.ComponentModel.DataAnnotations;


public class Categoria
{
    [Required(ErrorMessage = "Informe o nome.")]
    public string Nome { get; set; } = "";
    public int Quantidade { get; set; }
    
}