using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mf_dev_backend_2023.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int Km { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de Combustível")]
        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
