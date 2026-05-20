using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record PcDetailsDto (
    int Id,
    [MaxLength(50)] string Name,
    float Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock,
    IEnumerable<PcComponentDto> Components
    );