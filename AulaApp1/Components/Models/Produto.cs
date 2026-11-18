using System.ComponentModel.DataAnnotations;

namespace AulaApp1.Components.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "Informe o nozme.")]
        public string Nome { get; set; } = "";

        [Range(0.01, 100000, ErrorMessage = "Preço maior que zero.")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }

}
