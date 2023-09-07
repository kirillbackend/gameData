using System.ComponentModel.DataAnnotations;

namespace GameBlocApi.Models.Entity
{
    public record class Game
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public double RatingOnMetacritic { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string? Platforms { get; set; }
        public string? Developer { get; set; }
        public string? Genre { get; set; }
        public DateTime Update { get; set; }
    }
}
