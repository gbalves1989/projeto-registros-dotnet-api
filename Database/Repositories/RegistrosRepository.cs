using Microsoft.EntityFrameworkCore;
using RegistrosEntradaSaidaAPI.Database.Entities;

namespace RegistrosEntradaSaidaAPI.Database.Repositories
{
    public class RegistrosRepository : RegistrosRepoInterface
    {
        private readonly DatabaseConnection _context;

        public RegistrosRepository(DatabaseConnection context)
        {
            _context = context;
        }

        public async Task AddAsync(Registros registro)
        {
            await _context.RegistrosEntradaSaida.AddAsync(registro);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Registros>> GetAllAsync(int? veiculoId = null)
        {
            IQueryable<Registros> query = _context.RegistrosEntradaSaida;

            if (veiculoId.HasValue)
            {
                query = query.Where(r => r.VeiculoId == veiculoId.Value);
            }

            return await query.ToListAsync();
        }

        public async Task<Registros?> GetByIdAsync(int id)
        {
            return await _context.RegistrosEntradaSaida.FindAsync(id);
        }

        public async Task UpdateAsync(Registros registro)
        {
            _context.RegistrosEntradaSaida.Update(registro);
            await _context.SaveChangesAsync();
        }
    }
}
