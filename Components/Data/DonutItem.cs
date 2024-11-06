using System.ComponentModel.DataAnnotations;

namespace DonutCo.Components.Data;

public class DonutItem
{
    [Key]
    public int id { get; set; }
    public string ImageUrl { get; set; }
    public string Name { get; set; }
    
    public string Type { get; set; }
    
    
}