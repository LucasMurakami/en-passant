using System;
using System.ComponentModel.DataAnnotations;

//using AspNetCoreGeneratedDocument;
using en_passant.Models.Enum;
namespace en_passant.Models
{
    public class Game
    {
        public long Id { get; set; }

        [StringLength(100, MinimumLength =1, ErrorMessage = "O nome deve ter entre 1 e 100 caracteres.")]
        public required string Name { get; set; }
        [StringLength(100)]
        public string? Fornecedor { get; set; }
        public DateTime Year { get; set; }
        public Material? MadeOf { get; set; } // if is a board game 
        public Category Category { get; set; }
        public GameType GameType { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
    }


}