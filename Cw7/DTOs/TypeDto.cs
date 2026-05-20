using System.ComponentModel.DataAnnotations;

namespace Cw7.DTOs;

public record TypeDto (
    int Id,
    [MaxLength(30)] string Abbreviation,
    string Name
    );