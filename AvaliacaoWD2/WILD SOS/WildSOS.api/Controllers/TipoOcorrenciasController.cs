using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WildSOS.api.DTOs;
using WildSOS.api.Models;

namespace WildSOS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoOcorrenciasController : ControllerBase
    {
        private readonly WildSosContext _context;

        public TipoOcorrenciasController(WildSosContext context)
        {
            _context = context;
        }

        // GET: api/TipoOcorrencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoOcorrenciaDto>>> GetTipoOcorrencia()
        {
            List<TipoOcorrenciaDto> result = new List<TipoOcorrenciaDto>();

            var tipoOcorrencias = await _context.TipoOcorrencia.ToListAsync();

            foreach (var tipoOcorrencia in tipoOcorrencias)
            {
                result.Add(new TipoOcorrenciaDto().ModelToDto(tipoOcorrencia));
            }

            return Ok(result);
        }

        // GET: api/TipoOcorrencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoOcorrencia>> GetTipoOcorrencia(int id)
        {
            var tipoOcorrencia = await _context.TipoOcorrencia.FindAsync(id);

            if (tipoOcorrencia == null)
            {
                return NotFound();
            }

            return Ok(new TipoOcorrenciaDto().ModelToDto(tipoOcorrencia));
        }

        // PUT: api/TipoOcorrencias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoOcorrencia(int id, TipoOcorrenciaDto tipoOcorrencia)
        {
            if (id != tipoOcorrencia.IdTipoOcorrencia)
            {
                return BadRequest();
            }

            if (!TipoOcorrenciaExists(id))
            {
                return NotFound();
            }

            TipoOcorrencia tipoOcorrenciaModel = tipoOcorrencia.DtoToModel();

            _context.Entry(tipoOcorrenciaModel).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok();
        }

        // POST: api/TipoOcorrencias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoOcorrencia>> PostTipoOcorrencia(TipoOcorrenciaDto tipoOcorrencia)
        {

            _context.TipoOcorrencia.Add(tipoOcorrencia.DtoToModel());
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TipoOcorrenciaExists(tipoOcorrencia.IdTipoOcorrencia))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTipoOcorrencia", new { id = tipoOcorrencia.IdTipoOcorrencia }, tipoOcorrencia);
        }

        // DELETE: api/TipoOcorrencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoOcorrencia(int id)
        {
            var tipoOcorrencia = await _context.TipoOcorrencia.FindAsync(id);
            if (tipoOcorrencia == null)
            {
                return NotFound();
            }

            _context.TipoOcorrencia.Remove(tipoOcorrencia);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool TipoOcorrenciaExists(int id)
        {
            return _context.TipoOcorrencia.Any(e => e.IdTipoOcorrencia == id);
        }
    }
}
