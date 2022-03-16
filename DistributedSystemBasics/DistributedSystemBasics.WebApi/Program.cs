using DistributedSystemBasics.WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IMathUtilities, MathUtilities>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

static IResult Adder(int x, int y, IMathUtilities mu)
{
    // Zwei Zahlen addieren, die beide < 1000 sind.
    if (x < 1000 && y < 1000) { return Results.Ok(mu.Add(x, y)); }
    return Results.BadRequest();
}

app.MapGet("/ping", () => "pong");
app.MapGet("/hello", (string name) => $"Hello {name}");
app.MapGet("/add", Adder);
app.MapGet("/measure", () => new Measurement(DateTime.Now, Random.Shared.NextDouble()));

app.MapPost("/add", (Parameters p, IMathUtilities mu) => mu.Add(p.X, p.Y));

var pets = new List<Pet>(); // "DB"
app.MapPost("/pets", (Pet p) => pets.Add(p));
app.MapGet("/pets", () => pets);
app.MapDelete("/pets/{name}", (string name) => {
    var pet = pets.FirstOrDefault(p => p.Name == name);
    if (pet == null) { return Results.NotFound(); }
    pets.Remove(pet);
    return Results.NoContent();
});

app.Run();

record Measurement(DateTime Timestamp, double Value);
record Parameters(int X, int Y);

record Pet(string Type, string Name, int Age);
