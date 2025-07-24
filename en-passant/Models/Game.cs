using System;
//using AspNetCoreGeneratedDocument;
using en_passant.Models.Enum;
namespace en_passant.Models
{
    public class Game
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Fornecedor { get; set; }
        public DateTime Year { get; set; }
        public Material? MadeOf { get; set; } // if is a board game 
        public Category Category { get; set; }
        public GameType GameType { get; set; }
        public string? Description{ get; set; }
    }


}