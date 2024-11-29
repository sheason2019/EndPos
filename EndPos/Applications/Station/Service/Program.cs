namespace EndPos.Applications.Station.Service;

public class Program
{
    static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOpenApi();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.MapGet("/hello-world", () => "Hello World").WithName("GetHelloWorld");

        app.Run();
    }
}

