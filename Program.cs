using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using RegistrosEntradaSaidaAPI.Database;
using RegistrosEntradaSaidaAPI.Database.Repositories;
using RegistrosEntradaSaidaAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Env.Load();

builder.Services.AddDbContext<DatabaseConnection>(options =>
    options.UseNpgsql(Env.GetString("DATABASE_URL")));

builder.Services.AddScoped<RegistrosRepoInterface, RegistrosRepository>();
builder.Services.AddScoped<RegistrosServInterface, RegistrosService>();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Registros Entrada Saida API", Version = "v1" });

    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Registros Entrada Saida API v1");
        //c.RoutePrefix = string.Empty; 
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
