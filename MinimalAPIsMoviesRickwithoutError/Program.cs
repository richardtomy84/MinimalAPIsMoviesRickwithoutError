using MinimalAPIsMoviesRickwithoutError.Entities;

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

app.MapGet("/genres", () =>
{
    var genres = new List<Genre>()
    {
        new Genre
        {
            Id=1,
            Name="Drama"
        },
        new Genre
        {
            Id= 2,
            Name ="Action"
        },
        new Genre
        {
            Id= 3,
            Name="Comedy"
        }
    };
        return genres;
    
});

//Middlewares Zone- End

app.Run();
