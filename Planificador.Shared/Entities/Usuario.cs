using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planificador.Shared.Entities
{
    public class Usuario
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Nombre { get; set; }
        public string Correo { get; set; }
        public string PasswordHash { get; set; }
        public List<Actividad> Actividades { get; set; } = new();
    }
}
