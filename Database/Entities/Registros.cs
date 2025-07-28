using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrosEntradaSaidaAPI.Database.Entities
{
    [Table("Registros")]
    public class Registros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int VeiculoId { get; set; }

        [Required]
        public int MotoristaId { get; set; }

        [Required]
        public string DataEntrada { get; set; } = string.Empty; 

        [Required]
        public string HoraEntrada { get; set; } = string.Empty;

        public string? DataSaida { get; set; } = string.Empty;

        public string? HoraSaida { get; set; } = string.Empty;
    }
}
