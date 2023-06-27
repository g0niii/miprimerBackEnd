// 1 using para trabajar con entityFrameWork
using Microsoft.EntityFrameworkCore;
using myFirstBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);


// 2 conexion con la base de datos SQL EXPRESS
const string ConnectionName = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(ConnectionName);

// 3 agregar contexto al servicio y al contexto.-
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//El builder nos sirve para construir configuracion que va a usar nuestra aplicacion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//swagger para documentar la aplicacion

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
