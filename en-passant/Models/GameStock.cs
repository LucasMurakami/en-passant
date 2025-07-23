namespace en_passant.Models;

public class GameStock
{
    public required long Id { get; set; }
    public required Game Game { get; set; }
    public int? Quantity { get; set; }
}