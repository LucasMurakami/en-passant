using System.ComponentModel;

namespace en_passant.Models;

public class GameStock
{
    public long Id { get; set; }
    public required Game Game { get; set; }
    [DefaultValue(1)]
    public int? Quantity { get; set; }
}