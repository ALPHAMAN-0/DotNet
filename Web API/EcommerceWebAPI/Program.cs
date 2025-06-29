var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Map controllers
app.MapControllers();

// Minimal API endpoints
app.MapGet("/siam", () =>
{
    return "Welcome to the Siam API!";
});

app.MapPost("/hello", () =>
{
    return "Hello from the Siam API!";
});

// Print out the available routes
app.MapGet("/", () => 
{
    return "API is running. Available endpoints: /siam (GET), /hello (POST)";
});

app.Run();
