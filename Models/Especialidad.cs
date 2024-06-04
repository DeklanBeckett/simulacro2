using System.Text.Json.Serialization;

namespace Simulacro.Models{
    public class Especialidad{
        public int? Id {get; set;}
        public string? Nombre {get; set;}
        public string? Descripcion {get; set;}
        public string? Estado{get; set;}
        [JsonIgnore]
        public ICollection<Medico>? Medicos {get; set;}
    }
}