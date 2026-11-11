namespace AeroBase.Models;

public class Part
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public int Quantity { get; set; }
    public string StorageLocation { get; set; } = "";
    public string Compatibility { get; set; } = "";
}
