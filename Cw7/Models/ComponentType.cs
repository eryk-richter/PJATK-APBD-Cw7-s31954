using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw7.Models;

[Table("ComponentTypes")]
public class ComponentType
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(30)]
    public string Abbreviation { get; set; } = string.Empty;
    
    public string Name { get; set; } = string.Empty;
    
    public IEnumerable<Component> Components { get; set; } = [];
}