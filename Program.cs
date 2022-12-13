var builder = WebApplication.CreateBuilder(args).UseWasiConnectionListener();
var app = builder.Build();

Console.WriteLine("Starting from wasm!");

app.MapGet("/", () => "Hello World!");

app.Run();
