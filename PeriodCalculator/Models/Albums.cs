using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodCalculator.Models
{
    [Table("Albums")]
    public class Albums
    { 
        [Key]
        public int AlbumId { get; set; }

        [Display(Name ="Name")]
        public string AlbumName { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Artist")]
        public int? ArtistId { get; set; }

        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Display(Name = "Released On")]
        public int? ReleaseYear { get; set; }
    }
}
