using UserAPI;
using UserAPI.Controllers;



var builder = WebApplication.CreateBuilder(args);
// Initialize the logger
Logger.Initialize("log.txt");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure logger
//builder.Logging.ClearProviders();
//builder.Logging.AddConsole(options =>
//{
//    options.IncludeScopes = true;
//    options.TimestampFormat = "yyyy-MM-dd HH:mm:ss.fff ";
//});

//C: \Users\User\Development\C#\UserAPI\UserAPI\UserAPI.csproj
//var logger = new Logger("path/to/logfile.txt");
//logger.Log("log file was created");


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
    app.UseSwagger();
    app.UseSwaggerUI();
    }

app.UseAuthorization();

app.MapControllers();
// Log a message
Logger.Log("Application started.");


app.Run();
