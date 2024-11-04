var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => 
{
    options.AddPolicy("MyCors", builder => 
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
var app = builder.Build();

app.UseCors("MyCors");
app.MapGet("/", () => "Hello World!");

app.Run();
