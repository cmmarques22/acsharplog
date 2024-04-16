using Microsoft.EntityFrameworkCore;
using WildSOS.api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WildSosContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));
builder.Services.AddCors(o => o.AddPolicy(name: "MyAllowSpecificOrigins", policy =>
{
    policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
}));
builder.Services.AddCors(o => o.AddPolicy(name: "AllowAll",
                policy =>
                {
                    policy.AllowAnyOrigin()
                        .WithMethods("PUT", "DELETE", "GET", "POST");
                }));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
        builder =>
        {
            builder.WithOrigins(
                    "http://localhost:4200"
                )
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});


var app = builder.Build();


// Adicionar o uso da política CORS antes de MapControllers
app.UseCors("AllowAngularOrigins");
app.UseCors("MyAllowSpecificOrigins");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowAll");

app.Run();
