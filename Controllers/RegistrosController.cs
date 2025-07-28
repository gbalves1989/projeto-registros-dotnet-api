using Microsoft.AspNetCore.Mvc;
using RegistrosEntradaSaidaAPI.Database.Entities;
using RegistrosEntradaSaidaAPI.Requests;
using RegistrosEntradaSaidaAPI.Responses;
using RegistrosEntradaSaidaAPI.Services;
using System.Net;

namespace RegistrosEntradaSaidaAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RegistrosController : ControllerBase
    {
        private readonly RegistrosServInterface _service;

        public RegistrosController(RegistrosServInterface service)
        {
            _service = service;
        }

        /// <summary>
        /// Cria um novo registro de entrada e saída.
        /// </summary>
        /// <param name="registro">Os dados do registro.</param>
        /// <returns>Registro criado com sucesso.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<Registros>), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> Create([FromBody] RegistrosCreateRequest request)
        {
            var response = await _service.CreateRegistroAsync(request);
            return StatusCode(response.StatusCode, response);
        }

        /// <summary>
        /// Obtém todos os registros de entrada e saída por ID do veículo.
        /// </summary>
        /// <param name="veiculoId">O ID do veículo.</param>
        /// <returns>Registros recuperados com sucesso.</returns>
        [HttpGet("{veiculoId}")]
        [ProducesResponseType(typeof(ApiResponse<IEnumerable<Registros>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll(int veiculoId)
        {
            var response = await _service.GetAllRegistrosAsync(veiculoId);
            return StatusCode(response.StatusCode, response);
        }

        /// <summary>
        /// Atualiza um registro de entrada e saída existente.
        /// </summary>
        /// <param name="id">O ID do registro a ser atualizado.</param>
        /// <param name="registro">Os novos dados de data e hora de saída.</param>
        /// <returns>Registro atualizado com sucesso.</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ApiResponse<Registros>), (int)HttpStatusCode.Accepted)]
        [ProducesResponseType(typeof(ApiResponse<Registros>), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Update(int id, [FromBody] RegistrosUpdateRequest request)
        {
            var response = await _service.UpdateRegistroAsync(id, request);
            return StatusCode(response.StatusCode, response);
        }
    }
}
