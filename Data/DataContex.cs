using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;


using Microsoft.EntityFrameworkCore;

namespace Simulacro.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cita> Citas { get; set;}
        public DbSet<Especialidad> Especialidades { get; set;}
        public DbSet<Medico> Medicos { get; set;}
        public DbSet<Paciente> Pacientes { get; set;}
        public DbSet<Tratamiento> Tratamientos { get; set;}
    }
}