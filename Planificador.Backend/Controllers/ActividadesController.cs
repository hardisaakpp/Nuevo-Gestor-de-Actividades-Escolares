using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planificador.Backend.Data;
using Planificador.Shared.Entities;

namespace Planificador.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActividadesController : ControllerBase
    {
        private readonly DataContext _datacontext;
        public ActividadesController(DataContext context)
        {
            _datacontext = context;
        }

        // Crear
        [HttpPost]
        public async Task<IActionResult> addActivity(Actividad actividad)
        {
            if (actividad == null)
            {
                return BadRequest("Actividad is null.");
            }

            // Ensure the Id is not set
            actividad.Id = 0;

            _datacontext.Add(actividad);
            await _datacontext.SaveChangesAsync();
            return Ok();
        }

        // Actualizar
        [HttpPut]
        public async Task<IActionResult> updateActivity(Actividad actividad)
        {
            if (actividad == null)
            {
                return BadRequest("Actividad is null.");
            }
            _datacontext.Update(actividad);
            await _datacontext.SaveChangesAsync();
            return Ok();
        }

        // Remover
        [HttpDelete]
        public async Task<IActionResult> deleteActivity(int id)
        {
            var actividad = await _datacontext.Actividades.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }
            _datacontext.Actividades.Remove(actividad);
            await _datacontext.SaveChangesAsync();
            return Ok();
        }

        // Leer
        [HttpGet]
        public async Task<IActionResult> getActivities()
        {
            var actividades = await _datacontext.Actividades.ToListAsync();
            return Ok(actividades);
        }
    }
}
