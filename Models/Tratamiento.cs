namespace Simulacro.Models{
    public class Tratamiento{
        public int? Id {get; set;}
        public string? Descripcion {get; set;}
        public string? Estado {get; set;}
        public int? CitaId {get; set;}
        public Cita? Citas {get; set;}
    }
}