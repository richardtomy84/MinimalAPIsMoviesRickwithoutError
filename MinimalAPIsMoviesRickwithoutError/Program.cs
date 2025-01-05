var builder = WebApplication.CreateBuilder(args);

//string lastName = "Gavilan";
//Services Zone - Begin



string? lastName = null;

var lastNameProject = builder.Configuration.GetValue<string>("lastName");

string lastNameInUpperCase = lastName?.ToUpper();

//Services Zone - End

var app = builder.Build();


//Middlewares Zone- Begin

app.MapGet("/", () => "Hello World! " + lastNameInUpperCase + "\n"+ lastNameProject);

//Middlewares Zone- End

app.Run();
