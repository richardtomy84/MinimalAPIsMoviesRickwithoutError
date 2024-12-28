var builder = WebApplication.CreateBuilder(args);

//string lastName = "Gavilan";
string? lastName = null;

string lastNameInUpperCase = lastName?.ToUpper();

var app = builder.Build();

app.MapGet("/", () => "Hello World! " + lastNameInUpperCase);

app.Run();
