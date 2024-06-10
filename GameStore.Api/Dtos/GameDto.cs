using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class GameDto(
    int Id,
    [Required][StringLength(50)] string Name,
    [Required][StringLength(20)] string Genre,
    [Range(1, 200)] decimal price,
    DateOnly ReleaseDate
);
