using System.Text.Json.Serialization;

namespace Simulacro.Models{
    public class Medico{
        public int? Id{get; set;}
        public string? NombreCompleto {get; set;}
        public string? Correo {get; set;}
        public string? Telefono {get; set;}
        public string? Estado {get; set;}
        public int? EspecialidadId {get; set;}
        public Especialidad? Especialidades {get; set;}

        [JsonIgnore]
        public ICollection<Cita>? Citas {get; set;}
    }
}