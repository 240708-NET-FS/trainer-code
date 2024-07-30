using AspDemoApi.Data;
using AspDemoApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Here we will register our dependencies (Services and DbContext, etc) so that we can satisfy our constructors
//and inject dependecies where needed
builder.Services.AddScoped<IPokemonService, PokemonService>();
builder.Services.AddScoped<ITrainerService, TrainerService>();

builder.Services.AddScoped<IPokeRepo, PokeRepo>();
builder.Services.AddScoped<ITrainerRepo, TrainerRepo>();


builder.Services.AddDbContext<PokemonDBContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Logging.AddConsole();

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
