using RegistrosEntradaSaidaAPI.Database.Entities;
using RegistrosEntradaSaidaAPI.Database.Repositories;
using RegistrosEntradaSaidaAPI.Requests;
using RegistrosEntradaSaidaAPI.Responses;
using System.Net;

namespace RegistrosEntradaSaidaAPI.Services
{
    public class RegistrosService : RegistrosServInterface
    {
        private readonly RegistrosRepoInterface _repository;

        public RegistrosService(RegistrosRepoInterface repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse<Registros>> CreateRegistroAsync(RegistrosCreateRequest request)
        {
            Registros registro = new Registros();
            registro.VeiculoId = request.VeiculoId;
            registro.MotoristaId = request.MotoristaId;
            registro.DataEntrada = request.DataEntrada;
            registro.HoraEntrada = request.HoraEntrada;

            await _repository.AddAsync(registro);
            return new ApiResponse<Registros>((int)HttpStatusCode.Created, "Registro criado com sucesso.", registro);
        }

        public async Task<ApiResponse<IEnumerable<Registros>>> GetAllRegistrosAsync(int? veiculoId = null)
        {
            var registros = await _repository.GetAllAsync(veiculoId); 
            if (registros == null || !((List<Registros>)registros).Any())
            {
                return new ApiResponse<IEnumerable<Registros>>((int)HttpStatusCode.NotFound, "Nenhum registro encontrado.", new List<Registros>());
            }
            return new ApiResponse<IEnumerable<Registros>>((int)HttpStatusCode.OK, "Registros recuperados com sucesso.", registros);
        }

        public async Task<ApiResponse<Registros>> UpdateRegistroAsync(int id, RegistrosUpdateRequest request)
        {
            var registro = await _repository.GetByIdAsync(id);

            if (registro == null)
            {
                return new ApiResponse<Registros>((int)HttpStatusCode.NotFound, "Registro não encontrado.", null);
            }

            registro.DataSaida = request.DataSaida;
            registro.HoraSaida = request.HoraSaida;

            await _repository.UpdateAsync(registro);
            return new ApiResponse<Registros>((int)HttpStatusCode.Accepted, "Registro atualizado com sucesso.", registro);
        }
    }
}
