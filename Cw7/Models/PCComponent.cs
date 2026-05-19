using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Cw7.Models;

[Table("PCComponents"), PrimaryKey(nameof(PcId) , nameof(ComponentCode))]
public class PCComponent
{
    [Column("PCId")]
    public int PcId { get; set; }
    
    [Column(TypeName = "char(10)")]
    public string ComponentCode { get; set; } =  String.Empty;
    
    
    public int Amount { get; set; }

    [ForeignKey(nameof(PcId))]
    public Pc PCs { get; set; } = null!;
    
    [ForeignKey(nameof(ComponentCode))]
    public Component Component { get; set; } = null!;
}