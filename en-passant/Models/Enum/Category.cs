using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace en_passant.Models.Enum
{
    public enum Category
    {
        [Display(Name = "Estratégia")]
        Strategy,
        [Display(Name = "Clássico")]
        Classic,
        [Display(Name = "Aventura")]
        Adventure
    }
    
}