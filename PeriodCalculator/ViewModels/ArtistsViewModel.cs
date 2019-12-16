using System;
namespace PeriodCalculator.ViewModels
{
    public class ArtistsViewModel
    {
        public ArtistsViewModel()
        {

        }

        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        public DateTime ActiveFrom { get; set; }
    }
}
