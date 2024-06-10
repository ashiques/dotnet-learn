using GameStore.Api.Dtos;

namespace GameStore.Api.Controllers;

public static class GamesController
{


    private static readonly string GetRoute = "GetGame";
    private static readonly List<GameDto> games = [
        new GameDto(1,"FIFA 23", "Sports",100M,new DateOnly(2022,9,10)),
    new GameDto(2,"Super Mario","RPG",99.99M,new DateOnly(2018,9,10)),
    new GameDto(3,"Assasins Creed","RPG",50.99M,new DateOnly(2019,9,10)),
    new GameDto(4,"Mortal Kompat 2","Fighting",99.99M,new DateOnly(2021,9,10))
    ];


    public static RouteGroupBuilder MapGameController(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");

        // Adding minimal validation library to enable validation for all the Dtos
        var group = app.MapGroup("games").WithParameterValidation();

        // GET ALL games 
        group.MapGet("/", () => games);

        // GET Game by ID
        group.MapGet("/{id}", (int id) =>
        {
            GameDto? game = games.Find(x => x.Id == id);
            return game is null ? Results.NotFound() : Results.Ok(game);

        }).WithName(GetRoute);


        // POST Game
        group.MapPost("/", (CreateGameDto createGameDto) =>
        {
            // add into Game Object
            GameDto game = new(
                games.Count + 1,
                createGameDto.Name,
                createGameDto.Genre,
                createGameDto.Price,
                createGameDto.ReleaseDate
            );
            // adding into games list
            games.Add(game);

            return Results.CreatedAtRoute(GetRoute, new { id = game.Id }, game);

        });

        // PUT Game
        group.MapPut("/{id}", (int id, UpdateGameDto updateGameDto) =>
        {
            //Find the object by Id
            var index = games.FindIndex(x => x.Id == id);
            if (index == -1)
            {
                Results.NotFound();
            }
            games[index] = new(
                id,
                updateGameDto.Name,
                updateGameDto.Genre,
                updateGameDto.price,
                updateGameDto.ReleaseDate
           );

            return Results.NoContent();

        });

        //DELETE game by ID
        group.MapDelete("/{id}", (int id) =>
        {
            int index = games.FindIndex(x => x.Id == id);
            games.RemoveAt(index);
            return Results.NoContent();
        });
        return group;
    }
}
