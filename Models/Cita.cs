using System.Text.Json.Serialization;

namespace Simulacro.Models{
    public class Cita{
        public int? Id { get; set;}
        public DateTime? Fecha {get; set;}
        public string? Estado {get; set;}
        public int? PacienteId {get; set;}
        public int? MedicoId {get; set;}
        public Paciente? Pacientes {get; set;}
        public Medico? Medicos {get; set;}
        [JsonIgnore]
        public ICollection<Tratamiento>? tratamientos {get; set;}
    }
}