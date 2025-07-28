using RegistrosEntradaSaidaAPI.Database.Entities;
using RegistrosEntradaSaidaAPI.Requests;
using RegistrosEntradaSaidaAPI.Responses;

namespace RegistrosEntradaSaidaAPI.Services
{
    public interface RegistrosServInterface
    {
        Task<ApiResponse<IEnumerable<Registros>>> GetAllRegistrosAsync(int? veiculoId = null);
        Task<ApiResponse<Registros>> CreateRegistroAsync(RegistrosCreateRequest request);
        Task<ApiResponse<Registros>> UpdateRegistroAsync(int id, RegistrosUpdateRequest request);
    }
}
