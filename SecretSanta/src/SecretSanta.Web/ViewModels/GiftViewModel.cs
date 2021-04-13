using System.ComponentModel.DataAnnotations;
namespace SecretSanta.Web.ViewModels{
    public class GiftViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; } = "";

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; } = "";

        [Required]
        [Url]
        [Display(Name = "Url")]
        public string Url { get; set; } = "";

        [Required]
        [Display(Name = "Priority")]
        public int Priority { get; set; } = 0;

        [Display(Name = "User Id")]
        public int userId { get; set; }
    }
}