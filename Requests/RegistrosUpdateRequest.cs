using System.ComponentModel.DataAnnotations;

namespace RegistrosEntradaSaidaAPI.Requests
{
    public class RegistrosUpdateRequest
    {
        public string DataSaida { get; set; } = string.Empty;
        public string HoraSaida { get; set; } = string.Empty;
    }
}
