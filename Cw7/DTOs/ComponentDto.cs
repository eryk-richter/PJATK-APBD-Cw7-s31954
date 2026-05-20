using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record ComponentDto(
    [MaxLength(10)] string Code,
    [MaxLength(300)] string Name,
    string Description,
    ManufacturerDto Manufacturer,
    TypeDto Type
    );