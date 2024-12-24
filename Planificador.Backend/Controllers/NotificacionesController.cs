using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planificador.Backend.Data;
using Planificador.Shared.Entities;

namespace Planificador.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificacionesController : ControllerBase
    {
        private readonly DataContext _datacontext;
        public NotificacionesController(DataContext context)
        {
            _datacontext = context;
        }

        // Crear
        [HttpPost]
        public async Task<IActionResult> addNotification(Notificacion notificacion)
        {
            if (notificacion == null)
            {
                return BadRequest("Notificacion is null.");
            }

            // Ensure the Id is not set
            notificacion.Id = 0;

            _datacontext.Add(notificacion);
            await _datacontext.SaveChangesAsync();
            return Ok();
        }

        // Actualizar
        [HttpPut]
        public async Task<IActionResult> updateNotification(Notificacion notificacion)
        {
            if (notificacion == null)
            {
                return BadRequest("Notificacion is null.");
            }
            _datacontext.Update(notificacion);
            await _datacontext.SaveChangesAsync();
            return Ok();
        }

        // Remover
        [HttpDelete]
        public async Task<IActionResult> deleteNotification(int id)
        {
            var notificacion = await _datacontext.Notificaciones.FindAsync(id);
            if (notificacion == null)
            {
                return NotFound();
            }
            _datacontext.Notificaciones.Remove(notificacion);
            await _datacontext.SaveChangesAsync();
            return Ok();
        }

        // Leer
        [HttpGet("{id}")]
        public async Task<IActionResult> getNotifications(int id)
        {
            var notificaciones = await _datacontext.Notificaciones.SingleAsync(x => x.Id == id);
            
            Console.WriteLine(id);
            
            return Ok(id);
        }
    }
}