using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informa o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informa a placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informa o Ano de Fabricação!")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informa o Ano do modelo!")]
        [Display(Name = "Ano do Veiculo")]
        public int AnoModelo { get; set; }
        public ICollection<Consumo> Consumos { get; set; }
    }
}
