using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record CreatePcRequestDto(
    [MaxLength(50)] string Name,
    float Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock
);