using System.ComponentModel.DataAnnotations;

namespace en_passant.Models.Enum
{
    public enum Material
    {
        [Display(Name = "Madeira")]
        Wood,
        [Display(Name = "Plástico")]
        Plastic,
        [Display(Name = "Vidro")]
        Glass
    }


}