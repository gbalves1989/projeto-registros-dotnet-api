using RegistrosEntradaSaidaAPI.Database.Entities;

namespace RegistrosEntradaSaidaAPI.Database.Repositories
{
    public interface RegistrosRepoInterface
    {
        Task<IEnumerable<Registros>> GetAllAsync(int? veiculoId = null);
        Task<Registros?> GetByIdAsync(int id);
        Task AddAsync(Registros registro);
        Task UpdateAsync(Registros registro);
    }
}
