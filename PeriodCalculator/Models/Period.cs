using System;
using System.ComponentModel.DataAnnotations;

namespace PeriodCalculator.Models
{
    public class Period
    {
        public Period()
        {
        }

        public int Id { get; set; }

        public int? Months { get; set; }

        public int? Days { get; set; }

        public int? Years { get; set; }

        public int? Hours { get; set; }

        public int? Minutes { get; set; }

        public int? Seconds { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime EndDate { get; set; }
    }
}
