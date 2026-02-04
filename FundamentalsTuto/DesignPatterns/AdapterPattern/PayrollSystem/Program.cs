var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(); // register controllers

var app = builder.Build();

// Configure middleware
app.UseHttpsRedirection();

app.UseAuthorization();

// Map controllers
app.MapControllers();   // enables PayrollCalculatorController

app.Run();
