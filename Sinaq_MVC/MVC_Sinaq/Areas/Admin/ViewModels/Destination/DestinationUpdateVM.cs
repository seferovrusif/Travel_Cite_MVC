using System.ComponentModel.DataAnnotations;

namespace MVC_Sinaq.Areas.Admin.ViewModels.Destination
{
    public class DestinationupdateVM
    {
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public float Price { get; set; }
        [Required, Range(0, 5)]
        public float Rate { get; set; }
    }
}
