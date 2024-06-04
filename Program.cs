using Microsoft.EntityFrameworkCore;
using Simulacro.Data;
using Simulacro.Services;
using Simulacro2.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnetion"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));
builder.Services.AddControllers();

builder.Services.AddScoped<IPacientesRepository,PacientesRepository>();
builder.Services.AddScoped<IMedicosRepository, MedicosRepository>();
builder.Services.AddScoped<IEspecialidadesRepository, EspecialidadesRepository>();
builder.Services.AddScoped<ICitasRepository, CitasRepository>();
builder.Services.AddScoped<ITratamientosRepository, TratamientoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();

app.Run();


