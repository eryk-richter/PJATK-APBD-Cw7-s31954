using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Cw7.DTOs;

public record PcDto(
    int Id,
    [MaxLength(50)] string Name,
    float Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock
    );