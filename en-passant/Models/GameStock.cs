namespace en_passant.Models;

public class GameStock
{
    public long Id { get; set; }
    public required Game Game { get; set; }
    public int? Quantity { get; set; }
}