namespace Planificador.Shared.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        public int ActividadId { get; set; } // Foreign key property
        public Actividad Actividad { get; set; } // Navigation property
    }
}