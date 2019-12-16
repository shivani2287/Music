using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodCalculator.Models
{
    [Table("Genres")]
    public class Genres
    {
        [Key]
        public int GenreId { get; set; }

        public string Genre { get; set; }
    }
}
