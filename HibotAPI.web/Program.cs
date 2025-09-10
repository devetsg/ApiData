using HibotAPI.web.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<sg368newContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("EurekaConnection"));
});




//builder.Services.AddControllers();

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    {
        // Configuración opcional de Newtonsoft.Json
        options.SerializerSettings.Formatting = Formatting.Indented;
        // Configuración para manejar DateOnly y TimeOnly
        options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.IsoDateTimeConverter());
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
    });

//CORS
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("_MyPolicy", opt =>
    {
        opt.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});


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
app.UseCors("_MyPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
