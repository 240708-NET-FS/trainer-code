using AspDemoApi.Data;
using AspDemoApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS 
builder.Services.AddCors(co => {
    co.AddPolicy("CORS" , pb =>{
        pb.WithOrigins("*")
        .AllowAnyHeader();
    });
});
//CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS

// Add services to the container.
//The below add json options adds an option to let the json serializer to ignore cycles
//Otherwise when we get a trainer and include the ownedpokemons the json serializer
//Would get stuck in an infinite loop because pokemons also have an owner field
//Which would need the owned pokemons... which would need the owners... and so on... infinitely
builder.Services.AddControllers()
.AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });


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

//CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS
app.UseCors("CORS"); //<-USE CORS with your policy name
//CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS CORS

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();