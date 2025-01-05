var builder = WebApplication.CreateBuilder(args);

//string lastName = "Gavilan";
string? lastName = null;

var lastNameProject = builder.Configuration.GetValue<string>("lastName");

string lastNameInUpperCase = lastName?.ToUpper();



var app = builder.Build();

app.MapGet("/", () => "Hello World! " + lastNameInUpperCase + "\n"+ lastNameProject);

app.Run();
