using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using techstore.Data;
using techstore.Services;

Env.Load();

var host = Environment.GetEnvironmentVariable("DB_HOST");
var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var userName = Environment.GetEnvironmentVariable("DB_USERNAME");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={port};database={databaseName};uid={userName};password={password}";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));
builder.Services.AddScoped<CategoryService, CategoryService>();
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

app.MapGet("/", () => Results.Content(@"
    <!DOCTYPE html>
    <html lang='es'>
    <head>
        <meta charset='UTF-8'>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>TechStore</title>
        <style>
            body {
                font-family: 'Arial', sans-serif;
                background-color: #f0f0f0;
                color: #333;
                display: flex;
                flex-direction: column;
                align-items: center;
                justify-content: center;
                height: 100vh;
                margin: 0;
                padding: 20px;
                box-sizing: border-box;
            }
            h1 {
                font-size: 3rem;
                color: #fa7b20;
                margin-bottom: 20px;
                text-shadow: 5px 3px black;
            }
            p {
                font-size: 1.5rem;
                color: #4a90e2;
                margin-bottom: 20px;
            }
            a {
                color: #4a90e2;
                text-decoration: none;
                font-weight: bold;
                border-bottom: 2px solid #4a90e2;
                transition: color 0.3s, border-color 0.3s;
            }
            a:hover {
                color: #fa7b20;
                border-color: #fa7b20;
            }
            span {
                color: #6594e0;
            }
        </style>
    </head>
    <body>
        <h1>Bienvenido a <span> TechStore </span>  API</h1>
        <p>Consulta la documentación en <a href='/swagger/index.html'>Swagger</a>.</p>
    </body>
    </html>
", "text/html"));


app.MapControllers();

app.Run();
