using System.ComponentModel.DataAnnotations;

namespace en_passant.Models.Enum
{
    public enum GameType
    {
        [Display(Name = "Cartas")]
        Card,
        [Display(Name = "Tabuleiro")]
        Board
    }


}