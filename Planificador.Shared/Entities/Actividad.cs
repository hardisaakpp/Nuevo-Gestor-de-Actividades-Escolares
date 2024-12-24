using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Planificador.Shared.Entities
{
    public class Actividad
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required]
        public string NombreActividad { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Range(1, 60, ErrorMessage = "La duración debe estar entre 1 y 60 minutos.")]
        public int DuracionMinutos { get; set; }
    }
}
