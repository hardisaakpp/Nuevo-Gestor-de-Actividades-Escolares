namespace Planificador.Shared.Entities
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}