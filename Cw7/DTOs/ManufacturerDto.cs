using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record ManufacturerDto(
    int Id,
    [MaxLength(30)] string Abbreviation,
    [MaxLength(300)] string Fullname,
    DateTime FoundationDate
    );