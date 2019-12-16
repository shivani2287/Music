using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodCalculator.Models
{
    [Table("Artists")]
    public class Artists
    {
        [Key]
        public int ArtistId { get; set; }

        [Display(Name ="Name")]
        public string ArtistName { get; set; }

        [Display(Name = "Active From")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ActiveFrom { get; set; }
    }
}
