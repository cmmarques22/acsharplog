using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WildSOS.api.DTOs;
using WildSOS.api.Models;

namespace WildSOS.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspeciesController : ControllerBase
    {
        private readonly WildSosContext _context;

        public EspeciesController(WildSosContext context)
        {
            _context = context;
        }

        // GET: api/Especies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EspecieDto>>> GetEspecies()
        {
            List<EspecieDto> result = new List<EspecieDto>();

            var especies = await _context.Especies.ToListAsync();
            foreach (var especie in especies)
            {
                result.Add(new EspecieDto().ModelToDto(especie));
            }

            return Ok(result);
        }

        // GET: api/Especies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EspecieDto>> GetEspecie(int id)
        {
            var especie = await _context.Especies.FindAsync(id);
            //duvida
            if (especie == null)
            {
                return NotFound();
            }

            return Ok(new EspecieDto().ModelToDto(especie));
            ;
        }

        // PUT: api/Especies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecie(int id, EspecieDto especie)
        {
            if (id != especie.IdEspecie)
            {
                return BadRequest();
            }

            if (!EspecieExists(id))
            {
                return NotFound();
            }

            Especie especieModel = especie.DtoToModel();

            _context.Entry(especieModel).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return Ok();
        }

        // POST: api/Especies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Especie>> PostEspecie(EspecieDto especie)
        {
            _context.Especies.Add(especie.DtoToModel());
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EspecieExists(especie.IdEspecie))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEspecie", new { id = especie.IdEspecie }, especie);
        }

        // DELETE: api/Especies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEspecie(int id)
        {
            var especie = await _context.Especies.FindAsync(id);
            if (especie == null)
            {
                return NotFound();
            }

            _context.Especies.Remove(especie);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool EspecieExists(int id)
        {
            return _context.Especies.Any(e => e.IdEspecie == id);
        }

       

        [HttpGet("CountTipoOcorrencias")]
        public async Task<ActionResult<IEnumerable<EspecieDto>>> CountTipoOcorrencias()
        {

            var count = await _context.TipoOcorrencia.CountAsync();


            return Ok(count);
        }

        [HttpGet("CountEspecies")]
        public async Task<ActionResult<IEnumerable<EspecieDto>>> CountEspecies()
        {

            var count = await _context.Especies.CountAsync();


            return Ok(count);
        }


    }
}
