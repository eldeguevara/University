//1. usando entityframeworkd
using Microsoft.EntityFrameworkCore;
using UNIVERSITYAPI.DataAcces;

var builder = WebApplication.CreateBuilder(args);

// 2. conexion base de datos
const string CONNECTIONNAME = "UniversityDB";
var conexionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3. aderir context
builder.Services.AddDbContext<UniversityContext>(options => options.UseSqlServer(conexionString));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
