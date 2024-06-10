using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new GameDto(1,"FIFA 23", "Sports",100M,new DateOnly(2022,9,10)),
    new GameDto(2,"Super Mario","RPG",99.99M,new DateOnly(2018,9,10)),
    new GameDto(3,"Assasins Creed","RPG",50.99M,new DateOnly(2019,9,10)),
    new GameDto(4,"Mortal Kompat 2","Fighting",99.99M,new DateOnly(2021,9,10))
];

app.MapGet("/", () => "Hello World!");

// GET ALL games 
app.MapGet("/games", () => games);

// GET Game by ID
app.MapGet("/games/{id}", (int id) => games.Find(x => x.Id == id));

//DELETE game by ID
app.MapDelete("/games/{id}", (int id) =>
{
    int index = games.FindIndex(x => x.Id == id);
    games.RemoveAt(index);
    return Results.NoContent();
});

app.Run();
