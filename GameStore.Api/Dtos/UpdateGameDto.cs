namespace GameStore.Api.Dtos;

public record class UpdateGameDto(
    string Name,
    string Genre,
    decimal price,
    DateOnly ReleaseDate
);
