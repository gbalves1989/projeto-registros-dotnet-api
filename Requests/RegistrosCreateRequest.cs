using System.ComponentModel.DataAnnotations;

namespace RegistrosEntradaSaidaAPI.Requests
{
    public class RegistrosCreateRequest
    {
        [Required(ErrorMessage = "O ID do veículo é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O ID do veículo deve ser um número positivo.")]
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "O ID do motorista é obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "O ID do motorista deve ser um número positivo.")]
        public int MotoristaId { get; set; }

        [Required(ErrorMessage = "A data de entrada é obrigatória.")]
        public string DataEntrada { get; set; } = string.Empty;

        [Required(ErrorMessage = "A hora de entrada é obrigatória.")]
        public string HoraEntrada { get; set; } = string.Empty;

        // DataSaida e HoraSaida são opcionais na criação
        public string DataSaida { get; set; } = string.Empty;
        public string HoraSaida { get; set; } = string.Empty;
    }
}
