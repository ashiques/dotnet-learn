using GameStore.Api.Controllers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGameController();

app.Run();
