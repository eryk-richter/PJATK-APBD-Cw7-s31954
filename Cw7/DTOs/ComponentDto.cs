using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record ComponentDto(
    [MaxLength(10)] string Code,
    [MaxLength(300)] string Name,
    string Description,
    string ComponentTypeName,
    [MaxLength(300)] string ComponentManufacturerName
    );